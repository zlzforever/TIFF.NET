using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagImageFileFormat;

public class TIFF
{
    private readonly List<ImageFileDirectory> _imageFileDirectories = [];

    /// <summary>
    /// 是否小端序
    /// </summary>
    public bool IsLittleEndian { get; private set; }

    /// <summary>
    /// TIFF Version 42 是普通版本
    /// 43 是 BigTIFF
    /// </summary>
    public short Version { get; private set; }

    /// <summary>
    /// 第一个 IFD 的偏移量
    /// 使用 Long 是为了适配 BigTIFF
    /// </summary>
    public long OffsetToFirstIFD { get; private set; }

    public IReadOnlyCollection<ImageFileDirectory> ImageFileDirectories => _imageFileDirectories;

    private TIFF()
    {
    }

    public static TIFF Load(BinaryReader reader)
    {
        var tiff = new TIFF();

        tiff.ReadByteOrder(reader);
        tiff.ReadVersion(reader);
        tiff.ReadOffsetToFirstIFD(reader);

        var offset = tiff.OffsetToFirstIFD;
        while (reader.BaseStream.Position < reader.BaseStream.Length)
        {
            var ifd = tiff.ReadImageFileDirectory(reader, offset);
            offset = ifd.OffsetToNextIFD;
            if (offset == 0)
            {
                break;
            }
        }

        return tiff;
    }

    public static TIFF Load(Stream stream)
    {
        var reader = new BinaryReader(stream);
        return Load(reader);
    }

    public ImageFileDirectory ReadImageFileDirectory(BinaryReader reader, long offset)
    {
        var ifd = ImageFileDirectory.Read(reader, offset, IsLittleEndian, Version);
        ifd.SetIndex(_imageFileDirectories.Count);
        _imageFileDirectories.Add(ifd);
        return ifd;
    }

    public DirectoryEntry GetDirectoryEntry(int directoryNumber, TIFFTag tag)
    {
        var ifd = _imageFileDirectories.ElementAtOrDefault(directoryNumber);
        return ifd?.GetDirectoryEntry(tag);
    }

    public dynamic GetField(BinaryReader reader, int directoryNumber, TIFFTag tag)
    {
        var de = GetDirectoryEntry(directoryNumber, tag);
        return de?.GetValue(reader, IsLittleEndian, Version);
    }

    public Task<int[]> GetTileAsync(Stream stream, int level, int col, int row)
    {
        return GetTileAsync(new BinaryReaderAccessor(new BinaryReader(stream)), level, col, row);
    }

    public Task<int[]> GetTileAsync(BinaryReader reader, int level, int col, int row)
    {
        return GetTileAsync(new BinaryReaderAccessor(reader), level, col, row);
    }

    public async Task<int[]> GetTileAsync(IByteAccessor reader, int level, int col, int row)
    {
        var idf = _imageFileDirectories[level];
        var bytes = await idf.GetBytes(reader, col, row);
        var data = new int[idf.TileWidth * idf.TileLength];
        var numbers = bytes.Length / 3;
        for (var i = 0; i < numbers; i++)
        {
            var start = i * 3;
            var r = bytes[start];
            var g = bytes[start + 1];
            var b = bytes[start + 2];
            data[i] = BitConverter.ToInt32([r, g, b, byte.MaxValue], 0);
        }

        return data;
    }

    public async Task<byte[]> GetBytesAsync(IByteAccessor reader, int level, int col, int row)
    {
        var idf = _imageFileDirectories[level];
        var bytes = await idf.GetBytes(reader, col, row);
        return bytes;
    }

    private void ReadByteOrder(BinaryReader reader)
    {
        reader.BaseStream.Seek(0, SeekOrigin.Begin);
        var endianFlag = Encoding.UTF8.GetString(reader.ReadBytes(2));
        IsLittleEndian = endianFlag switch
        {
            Utility.ByteOrderLittleEndian => true,
            Utility.ByteOrderBigEndian => false,
            _ => throw new InvalidDataException("无效的字节序")
        };
    }

    private void ReadVersion(BinaryReader reader)
    {
        reader.BaseStream.Seek(2, SeekOrigin.Begin);
        var version = reader.ReadInt16();
        if (version != Utility.TiffVersion && version != Utility.BigTiffVersion)
        {
            throw new InvalidDataException("无效的 TIFF 版本");
        }

        Version = version;
    }

    /// <summary>
    /// TIFF 4 byte
    /// BigTIFF 8 byte
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    private void ReadOffsetToFirstIFD(BinaryReader reader)
    {
        if (Version != Utility.BigTiffVersion)
        {
            reader.BaseStream.Seek(4, SeekOrigin.Begin);
            OffsetToFirstIFD = reader.ReadInt32(IsLittleEndian);
        }
        else
        {
            reader.BaseStream.Seek(8, SeekOrigin.Begin);
            OffsetToFirstIFD = reader.ReadInt64(IsLittleEndian);
        }
    }
}
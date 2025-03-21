using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TagImageFileFormat;

public class ImageFileDirectory
{
    private readonly Dictionary<ushort, DirectoryEntry> _directoryEntries = new();

    public IReadOnlyDictionary<ushort, DirectoryEntry> DirectoryEntries => _directoryEntries;
    public int Index { get; private set; }
    public long NumberOfDirectoryEntries { get; private set; }
    public long OffsetToNextIFD { get; private set; }
    public long[] StripOffsets { get; private set; }
    public long RowsPerStrip { get; private set; }
    public long[] StripByteCounts { get; private set; }
    public long[] TileOffsets { get; private set; }
    public long[] TileByteCounts { get; private set; }
    public long ImageLength { get; private set; }
    public long ImageWidth { get; private set; }
    public ushort[] BitsPerSample { get; private set; }
    public ushort Compression { get; private set; } = 1;
    public ushort[] PhotometricInterpretation { get; private set; }
    public ushort Orientation { get; private set; }
    public ushort SamplesPerPixel { get; private set; }
    public ulong[] XResolution { get; private set; }
    public ulong[] YResolution { get; private set; }
    public ushort[] ResolutionUnit { get; private set; }
    public uint TileWidth { get; private set; }
    public uint TileLength { get; private set; }
    public ushort PlanarConfiguration { get; private set; }

    /// <summary>
    /// 列数
    /// </summary>
    public uint NumOfTileWidth { get; private set; }

    /// <summary>
    /// 行数
    /// </summary>
    public uint NumOfTileLength { get; private set; }

    public ulong NewSubfileType { get; private set; }
    public SampleFormat SampleFormat { get; private set; }

    public void AddDirectoryEntry(DirectoryEntry entry)
    {
        _directoryEntries.Add(entry.Tag, entry);
    }

    private void LoadProperties(BinaryReader reader, bool isLittleEndian, short version)
    {
        // NewSubfileType 254 Long
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(NewSubfileType)], out var newSubfileType))
        {
            // 必然存于 ValueOrOffset 中
            var v = newSubfileType.GetValue(reader, isLittleEndian, version);
            NewSubfileType = v[0];
        }

        // ImageWidth 256 SHORT/LONG
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(ImageWidth)], out var imageWidth))
        {
            var v = imageWidth.GetValue(reader, isLittleEndian, version);
            ImageWidth = Convert.ToInt64(v[0]);
        }

        // ImageLength 257 SHORT/LONG
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(ImageLength)], out var imageLength))
        {
            var v = imageLength.GetValue(reader, isLittleEndian, version);
            ImageLength = Convert.ToInt64(v[0]);
        }

        // BitsPerSample 258 SHORT
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(BitsPerSample)], out var bitsPerSample))
        {
            var v = bitsPerSample.GetValue(reader, isLittleEndian, version);
            BitsPerSample = v;
        }

        // Compression 259 SHORT
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(Compression)], out var compression))
        {
            var v = compression.GetValue(reader, isLittleEndian, version);
            Compression = v[0];
        }

        // PhotometricInterpretation 262 SHORT
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(PhotometricInterpretation)],
                out var photometricInterpretation))
        {
            var v = photometricInterpretation.GetValue(reader, isLittleEndian, version);
            PhotometricInterpretation = v;
        }

        // StripOffsets 273 SHORT/LONG
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(StripOffsets)],
                out var stripOffsets))
        {
            var v = stripOffsets.GetValue(reader, isLittleEndian, version);
            StripOffsets = ConvertArray<long>((IList)v);
        }

        // Orientation 274 SHORT
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(Orientation)],
                out var orientation))
        {
            var v = orientation.GetValue(reader, isLittleEndian, version);
            Orientation = v[0];
        }

        // SamplesPerPixel 277
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(SamplesPerPixel)],
                out var samplesPerPixel))
        {
            var v = samplesPerPixel.GetValue(reader, isLittleEndian, version);
            SamplesPerPixel = v[0];
        }

        // RowsPerStrip 278
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(RowsPerStrip)],
                out var rowsPerStrip))
        {
            var v = rowsPerStrip.GetValue(reader, isLittleEndian, version);
            RowsPerStrip = Convert.ToInt64(v[0]);
        }

        // StripByteCounts 279
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(StripByteCounts)],
                out var stripByteCounts))
        {
            var v = stripByteCounts.GetValue(reader, isLittleEndian, version);
            StripByteCounts = ConvertArray<long>((IList)v);
        }

        // XResolution 282 rational
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(XResolution)],
                out var xResolution))
        {
            var v = xResolution.GetValue(reader, isLittleEndian, version);
            XResolution = ConvertArray<ulong>((IList)v);
        }

        // YResolution 283 rational
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(YResolution)],
                out var yResolution))
        {
            var v = yResolution.GetValue(reader, isLittleEndian, version);
            YResolution = ConvertArray<ulong>((IList)v);
        }

        // PlanarConfiguration 284 SHORT
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(PlanarConfiguration)],
                out var planarConfiguration))
        {
            var v = planarConfiguration.GetValue(reader, isLittleEndian, version);
            PlanarConfiguration = v[0];
        }

        // ResolutionUnit 296 SHORT
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(ResolutionUnit)],
                out var resolutionUnit))
        {
            var v = resolutionUnit.GetValue(reader, isLittleEndian, version);
            ResolutionUnit = ConvertArray<ushort>((IList)v);
        }

        // TileWidth 322
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(TileWidth)],
                out var tileWidth))
        {
            var v = tileWidth.GetValue(reader, isLittleEndian, version);
            TileWidth = Convert.ToUInt32(v[0]);
        }

        // TileLength 323
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(TileLength)],
                out var tileLength))
        {
            var v = tileLength.GetValue(reader, isLittleEndian, version);
            TileLength = Convert.ToUInt32(v[0]);
        }

        // TileOffsets 324
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(TileOffsets)], out var tileOffsets))
        {
            var v = tileOffsets.GetValue(reader, isLittleEndian, version);
            // 不会为空
            // 如果为空， 则 DE 中不应该有值才对
            TileOffsets = ConvertArray<long>((IList)v);
        }

        // TileByteCounts 325 
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(TileByteCounts)], out var tileByteCounts))
        {
            var v = tileByteCounts.GetValue(reader, isLittleEndian, version);
            // 不会为空
            // 如果为空， 则 DE 中不应该有值才对
            TileByteCounts = ConvertArray<long>((IList)v);
        }

        // TileLength 339
        if (_directoryEntries.TryGetValue(Utility.PropertyMapTag[nameof(SampleFormat)],
                out var sampleFormat))
        {
            var v = sampleFormat.GetValue(reader, isLittleEndian, version);
            SampleFormat = (SampleFormat)Convert.ToUInt32(v[0]);
        }

        NumOfTileWidth = TileWidth == 0
            ? 0
            : (uint)(ImageWidth / TileWidth) + (uint)(ImageWidth % TileWidth == 0 ? 0 : 1);
        NumOfTileLength = TileLength == 0
            ? 0
            : (uint)ImageLength / TileLength +
              (uint)(ImageLength % TileLength == 0 ? 0 : 1);
    }

    public async Task<byte[]> GetBytes(IByteAccessor reader, int col, int row)
    {
        var index = row * NumOfTileWidth + col;
        var bytes = await reader.ReadBytes(TileOffsets[index], (int)TileByteCounts[index]);
        return bytes;
    }

    public async Task<int[]> GetTile(IByteAccessor reader, int col, int row)
    {
        var index = row * NumOfTileWidth + col;
        var bytes = await reader.ReadBytes(TileOffsets[index], (int)TileByteCounts[index]);
        var data = new int[TileWidth * TileLength];
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

    public static ImageFileDirectory Read(BinaryReader reader, long offset, bool isLittleEndian, short version)
    {
        reader.BaseStream.Seek(offset, SeekOrigin.Begin);
        var ifd = new ImageFileDirectory();
        var entryCount = ifd.ReadEntryCount(reader, isLittleEndian, version);

        for (var i = 0; i < entryCount; i++)
        {
            var de = DirectoryEntry.Read(reader, isLittleEndian, version);
            ifd.AddDirectoryEntry(de);
        }

        ifd.ReadOffsetToNextIFD(reader, isLittleEndian, version);
        ifd.LoadProperties(reader, isLittleEndian, version);
        return ifd;
    }

    public void SetIndex(int index)
    {
        Index = index;
    }

    public DirectoryEntry GetDirectoryEntry(TIFFTag tag)
    {
        return _directoryEntries.TryGetValue((ushort)tag, out var value) ? value : null;
    }

    /// <summary>
    /// TIFF 4 byte
    /// BigTIFF 8 byte
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="isLittleEndian"></param>
    /// <param name="version"></param>
    /// <returns></returns>
    private long ReadOffsetToNextIFD(BinaryReader reader, bool isLittleEndian, short version)
    {
        OffsetToNextIFD = version == Utility.BigTiffVersion
            ? reader.ReadInt64(isLittleEndian)
            : reader.ReadInt32(isLittleEndian);
        return OffsetToNextIFD;
    }

    /// <summary>
    /// TIFF 2 byte
    /// BigTIFF 4 byte
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="isLittleEndian"></param>
    /// <param name="version"></param>
    /// <returns></returns>
    private long ReadEntryCount(BinaryReader reader, bool isLittleEndian, short version)
    {
        NumberOfDirectoryEntries = version == Utility.BigTiffVersion
            ? reader.ReadInt64(isLittleEndian)
            : reader.ReadInt16(isLittleEndian);
        return NumberOfDirectoryEntries;
    }

    private static T[] ConvertArray<T>(IList list)
    {
        var targetType = typeof(T);
        var array = (T[])Array.CreateInstance(targetType, list.Count);
        for (var i = 0; i < list.Count; i++)
        {
            var value = list[i];
            array.SetValue(Convert.ChangeType(value, targetType), i);
        }

        return array;
    }
}
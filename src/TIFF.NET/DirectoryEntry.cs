using System;
using System.IO;
using System.Text;

namespace TagImageFileFormat;

public class DirectoryEntry
{
    public ushort Tag { get; private set; }
    public DataType Type { get; private set; }
    public long Count { get; private set; }
    public byte[] ValueOrOffset { get; private set; }

    public static DirectoryEntry Read(BinaryReader reader, bool isLittleEndian, short version)
    {
        var de = new DirectoryEntry();
        de.ReadTag(reader, isLittleEndian);
        de.ReadDataType(reader, isLittleEndian);
        de.ReadCount(reader, isLittleEndian, version);
        de.ReadValueOrOffset(reader, version);

        return de;
    }

    /// <summary>
    /// 除了字符串、byte[]，其他类型都是对应数据类型的数组
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="isLittleEndian"></param>
    /// <param name="version"></param>
    /// <returns></returns>
    public dynamic GetValue(BinaryReader reader, bool isLittleEndian, short version)
    {
        // byte 数组长度
        var length = Count * Utility.GetSize(Type);
        var valueOrOffsetByteLenght = version == Utility.BigTiffVersion ? 8 : 4;

        if (length <= valueOrOffsetByteLenght)
        {
            var binaryReader = new BinaryReader(new MemoryStream(ValueOrOffset));
            var result = ReadValue(binaryReader, isLittleEndian);
            return result;
        }
        else
        {
            var offset = version == Utility.BigTiffVersion
                ? BitConverter.ToInt64(ValueOrOffset, 0)
                : BitConverter.ToInt32(ValueOrOffset, 0);
            reader.BaseStream.Seek(offset, SeekOrigin.Begin);
            var result = ReadValue(reader, isLittleEndian);
            return result;
        }
    }

    public override string ToString()
    {
        return $"Tag {Tag} Type {Type} Count {Count} ValueOrOffset {ValueOrOffset}";
    }

    private dynamic ReadValue(BinaryReader reader, bool isLittleEndian)
    {
        dynamic result;
        switch (Type)
        {
            case DataType.Double:
            {
                var v = new double[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadDouble(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.Sbyte:
            {
                var v = new sbyte[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadSByte();
                }

                result = v;
                break;
            }
            case DataType.Long:
            {
                var v = new uint[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadUInt32(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.SLong:
            {
                var v = new int[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadInt32(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.Long8:
            {
                var v = new ulong[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadUInt64(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.SLong8:
            {
                var v = new long[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadInt64(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.Rational:
            {
                var v = new uint[2];

                for (var i = 0; i < 2; i++)
                {
                    v[i] = reader.ReadUInt32(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.SRational:
            {
                var v = new int[2];

                for (var i = 0; i < 2; i++)
                {
                    v[i] = reader.ReadInt32(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.Float:
            {
                var v = new float[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadSingle(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.Short:
            {
                var v = new ushort[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadUInt16(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.SShort:
            {
                var v = new short[Count];

                for (var i = 0; i < Count; i++)
                {
                    v[i] = reader.ReadInt16(isLittleEndian);
                }

                result = v;
                break;
            }
            case DataType.Ascii:
            {
                if (Count > int.MaxValue)
                {
                    throw new InvalidDataException("ASCII character exceeds maximum length.");
                }

                var bytes = reader.ReadBytes((int)Count);
                // ASCII, UT8 都不存在大小端问题
                result = Encoding.ASCII.GetString(bytes);
                break;
            }
            case DataType.Undefined:
            case DataType.IFD8:
            case DataType.Byte:
            default:
            {
                if (Count > int.MaxValue)
                {
                    throw new InvalidDataException("Exceeds maximum length.");
                }

                result = reader.ReadBytes((int)Count);
                break;
            }
        }

        return result;
    }

    /// <summary>
    /// TIFF 2 byte
    /// BigTIFF 2 byte
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="isLittleEndian"></param>
    /// <returns></returns>
    private ushort ReadTag(BinaryReader reader, bool isLittleEndian)
    {
        Tag = reader.ReadUInt16(isLittleEndian);
        return Tag;
    }

    /// <summary>
    /// TIFF 2 byte
    /// BigTIFF 2 byte
    /// </summary>
    /// <param name="reader"></param>
    /// <param name="isLittleEndian"></param>
    /// <returns></returns>
    private DataType ReadDataType(BinaryReader reader, bool isLittleEndian)
    {
        Type = (DataType)reader.ReadUInt16(isLittleEndian);
        return Type;
    }

    private long ReadCount(BinaryReader reader, bool isLittleEndian, short version)
    {
        Count = version != Utility.BigTiffVersion
            ? reader.ReadUInt32(isLittleEndian)
            : reader.ReadInt64(isLittleEndian);
        return Count;
    }

    /// <summary>
    /// TIFF 4 byte
    /// BigTIFF 8 byte
    /// </summary>
    /// <param name="reader"></param>
    ///  /// <param name="version"></param>
    /// <returns></returns>
    private byte[] ReadValueOrOffset(BinaryReader reader, short version)
    {
        var lenght = version == Utility.BigTiffVersion ? 8 : 4;
        ValueOrOffset = reader.ReadBytes(lenght);
        return ValueOrOffset;
    }
}
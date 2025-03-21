using System;
using System.IO;

namespace TagImageFileFormat;

public static class BinaryReaderExtensions
{
    public static ushort ReadUInt16(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(2);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToUInt16(bytes, 0);
    }

    public static short ReadInt16(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(2);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToInt16(bytes, 0);
    }

    public static uint ReadUInt32(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(4);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToUInt32(bytes, 0);
    }

    public static int ReadInt32(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(4);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToInt32(bytes, 0);
    }

    public static double ReadDouble(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(8);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToDouble(bytes, 0);
    }

    public static float ReadSingle(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(4);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToSingle(bytes, 0);
    }

    public static ulong ReadUInt64(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(8);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToUInt64(bytes, 0);
    }

    public static long ReadInt64(this BinaryReader reader, bool isLittleEndian)
    {
        var bytes = reader.ReadBytes(8);
        if (BitConverter.IsLittleEndian != isLittleEndian)
        {
            Array.Reverse(bytes);
        }

        return BitConverter.ToInt64(bytes, 0);
    }
}
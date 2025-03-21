using System;
using System.Collections.Generic;
using System.Linq;

namespace TagImageFileFormat;

internal static class Utility
{
    public const string ByteOrderLittleEndian = "II";
    public const string ByteOrderBigEndian = "MM";
    public const int TiffVersion = 42;
    public const short BigTiffVersion = 43;

    public static readonly Dictionary<ushort, string> TagMapProperty = new()
    {
        { 254, "NewSubfileType" },
        { 256, "ImageWidth" },
        { 257, "ImageLength" },
        { 258, "BitsPerSample" },
        { 259, "Compression" },
        { 262, "PhotometricInterpretation" },
        { 273, "StripOffsets" },
        { 274, "Orientation" },
        { 277, "SamplesPerPixel" },
        { 278, "RowsPerStrip" },
        { 279, "StripByteCounts" },
        { 282, "XResolution" },
        { 283, "YResolution" },
        { 284, "PlanarConfiguration" },
        { 296, "ResolutionUnit" },
        { 305, "Software" },
        { 306, "DateTime" },
        { 322, "TileWidth" },
        { 323, "TileLength" },
        { 324, "TileOffsets" },
        { 325, "TileByteCounts" },
        { 339, "SampleFormat" },
        { 33550, "ModelPixelScaleTag" },
        { 33922, "ModelTiepointTag" },
        { 34264, "ModelTransformationTag" },
        { 34735, "GeoKeyDirectoryTag" },
        { 34736, "GeoDoubleParamsTag" },
        { 34737, "GeoAsciiParamsTag" }
    };

    public static readonly Dictionary<string, ushort> PropertyMapTag =
        TagMapProperty.ToDictionary(x => x.Value, x => x.Key);

    public static uint GetSize(DataType dataType)
    {
        return dataType switch
        {
            DataType.Ascii => 1,
            DataType.Byte => 1,
            DataType.Sbyte => 1,
            DataType.Undefined => 1,
            DataType.Short => 2,
            DataType.SShort => 2,
            DataType.Long => 4,
            DataType.SLong => 4,
            DataType.Long8 => 8,
            DataType.SLong8 => 8,
            DataType.Rational => 8,
            DataType.SRational => 8,
            DataType.Float => 4,
            DataType.Double => 8,
            DataType.IFD8 => 8,
            _ => throw new ArgumentOutOfRangeException(nameof(dataType), dataType, null)
        };
    }
}
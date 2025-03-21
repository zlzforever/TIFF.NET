namespace TagImageFileFormat;

public enum DataType
{
    /// <summary>
    /// 1 byte
    /// </summary>
    Byte = 1,

    /// <summary>
    /// 1 byte
    /// </summary>
    Ascii = 2,

    /// <summary>
    /// 2 byte
    /// </summary>
    Short = 3,

    /// <summary>
    /// 4 byte
    /// </summary>
    Long = 4,

    /// <summary>
    /// 8 byte, 2 longs
    /// </summary>
    Rational = 5,

    /// <summary>
    /// 1 byte
    /// </summary>
    Sbyte = 6,

    /// <summary>
    /// 1 byte
    /// </summary>
    Undefined = 7,

    /// <summary>
    /// 2 byte
    /// </summary>
    SShort = 8,

    /// <summary>
    /// 4 byte
    /// </summary>
    SLong = 9,

    /// <summary>
    /// 8 byte, 2 slongs
    /// </summary>
    SRational = 10,

    /// <summary>
    /// 4 byte
    /// </summary>
    Float = 11,

    /// <summary>
    /// 8 byte
    /// </summary>
    Double = 12,

    /// <summary>
    /// 
    /// </summary>
    Long8 = 16,

    SLong8 = 17,

    IFD8 = 18
}
namespace TagImageFileFormat;

public enum SampleFormat
{
    /// <summary>Unsigned integer data</summary>
    UINT = 1,
    /// <summary>Signed integer data</summary>
    INT = 2,
    /// <summary>IEEE floating point data</summary>
    IEEEFP = 3,
    /// <summary>Untyped data</summary>
    VOID = 4,
    /// <summary>Complex signed int</summary>
    COMPLEXINT = 5,
    /// <summary>Complex ieee floating</summary>
    COMPLEXIEEEFP = 6,
}
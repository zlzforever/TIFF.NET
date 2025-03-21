using System.Threading.Tasks;

namespace TagImageFileFormat;

public interface IByteAccessor
{
    Task<byte[]> ReadBytes(long offset, int length);
}
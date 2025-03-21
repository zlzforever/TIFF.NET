using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;

namespace TagImageFileFormat;

public class MemoryMappedViewByteAccessor(MemoryMappedViewAccessor viewAccessor) : IByteAccessor
{
    public Task<byte[]> ReadBytes(long offset, int length)
    {
        var bytes = new byte[length];
        viewAccessor.ReadArray(offset, bytes, 0, length);
        return Task.FromResult(bytes);
    }
}
using System.IO;
using System.Threading.Tasks;

namespace TagImageFileFormat;

public class BinaryReaderAccessor(BinaryReader reader) : IByteAccessor
{
    public Task<byte[]> ReadBytes(long offset, int length)
    {
        reader.BaseStream.Seek(offset, SeekOrigin.Begin);
        return Task.FromResult(reader.ReadBytes(length));
    }
}
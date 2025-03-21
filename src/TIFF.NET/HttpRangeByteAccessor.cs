#if NETSTANDARD2_0
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TagImageFileFormat;

public class HttpRangeByteAccessor(string url) : IByteAccessor
{
    private static readonly HttpClient HttpClient = new();

    public async Task<byte[]> ReadBytes(long offset, int length)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Range = new RangeHeaderValue(offset, length);
        var response = await HttpClient.SendAsync(request);
        var bytes = await response.Content.ReadAsByteArrayAsync();
        return bytes;
    }
}
#endif
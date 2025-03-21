# TIFF.NET

## Introduction

This is a .NET library for reading TIFF files. It is based on the TIFF 6.0 specification and supports all the
compression types and color spaces defined in the specification.

## Design

1. Load a TIFF object from a stream. The TIFF object contains the header and the IFD.
2. Get necessary information from the TIFF header/IFD/de.
3. Get the image data from a stream/memory mapped file.
4. Get the image data from a remote stream.

## Sample

```csharp
        using var reader = new BinaryReader(stream);
        var tiff = TIFF.Load(stream); // cache this object
        
        var memoryMappedFile = MemoryMappedFile.CreateFromFile("path", FileMode.Open, null, 0L, MemoryMappedFileAccess.Read)
        using var viewAccessor = memoryMappedFile.CreateViewAccessor(0, 0, MemoryMappedFileAccess.Read);
        var byteAccessor = new MemoryMappedViewByteAccessor(accessor);
        // var bytes = await tiff.GetBytesAsync(byteAccessor, 0, 0, 0);
        var imageBytes = await tiff.GetTileAsync(byteAccessor, 0, 0, 0); // RGB int[]
        var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
        // save image via SkiaSharp
        try
        {
            using var skiaImage =
                SKImage.FromPixels(
                    new SKImageInfo(512, 512, SKColorType.Rgba8888, SKAlphaType.Premul),
                    handle.AddrOfPinnedObject());
            using var bitmap = SKBitmap.FromImage(skiaImage);
            using var imageStream = new MemoryStream();
            bitmap.Encode(imageStream, SKEncodedImageFormat.Png, 100);
            File.WriteAllBytes("image_path", imageStream.ToArray());
        }
        finally
        {
            handle.Free();
        }
```

## HTTP Range Request

```csharp

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

```
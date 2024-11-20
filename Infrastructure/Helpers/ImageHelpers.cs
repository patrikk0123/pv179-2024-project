using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;

namespace Infrastructure.Helpers;

public static class ImageHelpers
{
    public static byte[] CreateImagePreview(
        byte[] imageBytes,
        int maxWidth = 300,
        int maxHeight = 300,
        int quality = 75
    )
    {
        using var inputStream = new MemoryStream(imageBytes);
        using Image image = Image.Load(inputStream);

        image.Mutate(x =>
            x.Resize(
                new ResizeOptions { Size = new Size(maxWidth, maxHeight), Mode = ResizeMode.Max }
            )
        );

        using var outputStream = new MemoryStream();
        image.Save(outputStream, new JpegEncoder { Quality = quality });

        return outputStream.ToArray();
    }
}

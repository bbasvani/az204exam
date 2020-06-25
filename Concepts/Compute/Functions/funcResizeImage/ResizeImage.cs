using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

using ImageResizer.Resizing;

//using SixLabors.ImageSharp;
//using SixLabors.ImageSharp.Formats;
//using SixLabors.ImageSharp.PixelFormats;
//using SixLabors.ImageSharp.Processing;

namespace funcResizeImage
{
    public static class ResizeImage
    {
        //[FunctionName("ResizeImage")]
        //public static void Run([BlobTrigger("samples-images/{name}", Connection = "cnsa")]Stream myBlob, string name, ILogger log)
        //{
        //    log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        //}

        [FunctionName("ResizeImage")]
        public static void Run([BlobTrigger("sample-images/{name}")] Stream inputImage,
        //[Blob("sample-images-sm/{name}", FileAccess.Write)] Stream imageSmall,
        [Blob("sample-images-md/{name}", FileAccess.Write)] Stream resizedImage)
        {
            //IImageFormat format;

            //using (Image<Rgba32> input = Image.Load<Rgba32>(image, out format))
            //{
            //    ResizeImage(input, imageSmall, ImageSize.Small, format);
            //}

            //image.Position = 0;
            //using (Image<Rgba32> input = Image.Load<Rgba32>(image, out format))
            //{
            //    ResizeImage(input, imageMedium, ImageSize.Medium, format);
            //}
            
            var settings = new ImageResizer.ResizeSettings
            {
                MaxWidth=400,
                Format="png"
            };
        }
    }
}

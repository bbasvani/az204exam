using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace funcResizeImage
{
    public static class ResizeImage
    {
        [FunctionName("ResizeImage")]
        public static void Run([BlobTrigger("samples-images/{name}", Connection = "cnsa")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}

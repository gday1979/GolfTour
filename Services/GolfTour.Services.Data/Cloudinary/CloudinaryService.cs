namespace GolfTour.Services.Data.Cloudinary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using GolfTour.Services.Data.Helpers;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Options;

    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary cloudinary;

        public CloudinaryService(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public async Task DeleteImage(Cloudinary cloudinary, string name)
        {
            var delParams = new DelResParams()
            {
                    PublicIds = new List<string> { name },
                    Invalidate = true,
            };

            await cloudinary.DeleteResourcesAsync(delParams);
        }

        public async Task<string> UploadAsync(IFormFile file, string fileName)
        {
            byte[] destinationImage;

            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            destinationImage = memoryStream.ToArray();

            using var destinationStream = new MemoryStream(destinationImage);

            fileName = fileName.Replace("&", "And");
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(fileName, destinationStream),
                PublicId = fileName,
            };
            var result = await this.cloudinary.UploadAsync(uploadParams);
            return result.Uri.AbsoluteUri;
        }
    }
}

using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Models.Interfaces;

namespace WAWillClinicFrontEnd.Models.Services
{
    public class BlobManager : IBlob
    {
        public IConfiguration Configuration { get; }

        public CloudStorageAccount StorageAccount { get; set; }
        public CloudBlobClient BlobStorage { get; set; }

        public BlobManager(IConfiguration configuration)
        {
            Configuration = configuration;

            StorageAccount = CloudStorageAccount.Parse(Configuration["BlobConnection"]);
            BlobStorage = StorageAccount.CreateCloudBlobClient();
        }

        public async Task<bool> DeleteAsync(string blobName)
        {
            CloudBlobContainer container = await GetContainerAsync();
            var blob = container.GetBlobReference(blobName);
            bool result = blob.DeleteIfExists();
            return result;
        }

        public async Task<CloudBlob> GetBlob(string imageName)
        {
            var container = await GetContainerAsync();
            CloudBlob blob = container.GetBlobReference(imageName);

            return blob;
        }

        public async Task<CloudBlobContainer> GetContainerAsync()
        {
            CloudBlobContainer container = BlobStorage.GetContainerReference("willclinicresources");
            await container.CreateIfNotExistsAsync();
            await container.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            return container;
        }

        public async Task<CloudBlob> UploadFromFileAsync(string imageName, string filePath)
        {
            CloudBlobContainer container = await GetContainerAsync();
            CloudBlockBlob blobBlock = container.GetBlockBlobReference(imageName);
            await blobBlock.UploadFromFileAsync(filePath);

            CloudBlob blob = await GetBlob(imageName);
            return blob;
        }
    }
}

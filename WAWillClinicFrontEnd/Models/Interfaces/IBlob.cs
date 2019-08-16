using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models.Interfaces
{
    public interface IBlob
    {
        Task<CloudBlobContainer> GetContainerAsync();

        Task<CloudBlob> GetBlob(string imageName);

        Task<CloudBlob> UploadFromFileAsync(string imageName, string filePath);

        Task<bool> DeleteAsync(string blobName);
    }
}

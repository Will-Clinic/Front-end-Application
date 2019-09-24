using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Storage.Blob;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Models.Interfaces;

namespace WAWillClinicFrontEnd.Pages
{
    [Authorize(Policy = "Admin")]
    public class ResourceDetailModel : PageModel
    {
        private IResource _context;
        private IBlob _blob;

        public ResourceDetailModel(IResource context, IBlob blob)
        {
            _context = context;
            _blob = blob;
        }

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Resource Resource { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public async Task OnGet()
        {
            Resource = await _context.GetResourceById(ID.GetValueOrDefault()) ?? new Resource();
        }

        public async Task<IActionResult> OnPost()
        {
            Resource resource = await _context.GetResourceById(ID.GetValueOrDefault()) ?? new Resource();
            resource.Title = Resource.Title;
            resource.Type = Resource.Type;
            resource.Link = Resource.Link;
            resource.ImageName = Resource.ImageName;
            resource.ImageURL = Resource.ImageURL;
            resource.Description = Resource.Description;

            if (ID != null)
            {
                var filePath = Path.GetTempFileName();

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);
                }

                await _blob.DeleteAsync(resource.ImageName);

                CloudBlob blob = await _blob.UploadFromFileAsync(Image.FileName, filePath);
                var blobURI = blob.Uri;
                resource.ImageURL = blobURI.ToString();
                resource.ImageName = Image.FileName;

                await _context.UpdateResource(resource);
            }
            else
            {
                var filePath = Path.GetTempFileName();

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);
                }

                CloudBlob blob = await _blob.UploadFromFileAsync(Image.FileName, filePath);
                var blobURI = blob.Uri;
                resource.ImageURL = blobURI.ToString();
                resource.ImageName = Image.FileName;

                await _context.CreateResource(resource);
            }

            return RedirectToPage("ResourcesManager");
        }
    }
}
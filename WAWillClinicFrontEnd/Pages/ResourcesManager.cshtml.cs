using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Models.Interfaces;

namespace WAWillClinicFrontEnd.Pages
{
    public class ResourcesManagerModel : PageModel
    {
        private IResource _context;
        private IBlob _blob;

        public ResourcesManagerModel(IResource context, IBlob blob)
        {
            _context = context;
            _blob = blob;
        }

        [BindProperty]
        public List<Resource> AllResources { get; set; }

        [BindProperty]
        public List<Resource> AllResourcesByType { get; set; }

        [BindProperty]
        public Resource ResourceItem { get; set; }


        [BindProperty]
        public ResourceType TypeResource { get; set; }

        public async Task OnGet()
        {
            AllResources = await _context.GetAllResources();
        }

        public async Task OnPost()
        {
            AllResourcesByType = await _context.GetAllResourcesByType(TypeResource);
        }

        public async Task<IActionResult> OnPostDelete()
        {
            var idResource = Request.Form["id"];
            int id = Convert.ToInt32(idResource);

            Resource resource = await _context.GetResourceById(id);

            if (resource != null)
            {
                await _blob.GetBlob(resource.ImageName);
                await _blob.DeleteAsync(resource.ImageName);
                await _context.DeleteResource(id);
            }

            return RedirectToPage();
        }

    }
}
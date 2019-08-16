using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Storage.Blob;
using WAWillClinicFrontEnd.Models;
using WAWillClinicFrontEnd.Models.Interfaces;

namespace WAWillClinicFrontEnd.Pages
{
    public class ResourceDetailModel : PageModel
    {
        private IResource _context;
        private IBlob _blob;

        public ResourceDetailModel(IResource context, IBlob blob)
        {
            _context = context;
            _blob = blob;
        }

        [BindProperty]
        public Resource ResourceItem { get; set; }

        [BindProperty]
        public CloudBlob Blob { get; set; }

        public async Task OnGet(int id)
        {
            ResourceItem = await _context.GetResourceById(id);
        }
    }
}
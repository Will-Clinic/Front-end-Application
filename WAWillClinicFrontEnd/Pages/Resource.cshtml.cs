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

    public class ResourceModel : PageModel
    {
        private IResource _context;

        public List<Resource> AllResourcesByType { get; set; }

        public List<Resource> AllResources { get; set; }

        [BindProperty]
        public ResourceType TypeResource { get; set; }


        public ResourceModel(IResource context)
        {
            _context = context;
        }

        public async Task OnGet()
        {
            AllResources = await _context.GetAllResources();
        }

        public async Task OnPost()
        {
            AllResourcesByType = await _context.GetAllResourcesByType(TypeResource);
        }
    }
}
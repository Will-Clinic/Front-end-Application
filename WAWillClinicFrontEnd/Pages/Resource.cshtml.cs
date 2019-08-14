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

        public ResourceModel(IResource context)
        {
            _context = context;
        }

        public async Task OnGet()
        {
            // on get i need to grab all of the resources from the Db using a interface to that table.
           AllResourcesByType = await _context.GetAllResources();
        }
    }
}
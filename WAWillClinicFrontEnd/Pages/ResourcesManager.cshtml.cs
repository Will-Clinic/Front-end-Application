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
        private IResource _resource;

        [BindProperty]
        public ResourceType TypeResource { get; set; }

        public List<Resource> Resources { get; set; }

        public ResourcesManagerModel(IResource resource)
        {
            _resource = resource;
        }

        public void OnGet()
        {

        }

        public async Task OnPostType()
        {
            Resources = await _resource.GetAllResourcesByType(TypeResource);
        }

        public async Task OnPostUpdate()
        {
            var id = Request.Form["resource.ID"];
            int resourceID = Convert.ToInt32(id);
            var name = Request.Form["resource.Title"];
            var link = Request.Form["resource.Link"];
            var image = Request.Form["resource.ImageURL"];
            var description = Request.Form["resource.Description"];
            var type = Request.Form["resource.Type"];
            int resourceType = Convert.ToInt32(type);

            Resource newResource = new Resource
            {
                ID = resourceID,
                Title = name,
                Link = link,
                ImageURL = image,
                Description = description,
                //need to find a way to convert to the type 
            };

            await _resource.UpdateResource(newResource);
        }

    }
}
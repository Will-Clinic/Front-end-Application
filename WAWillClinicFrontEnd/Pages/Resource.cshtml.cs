using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WAWillClinicFrontEnd.Pages
{
    public class ResourceModel : PageModel
    {
        public void OnGet()
        {
            // on get i need to grab all of the resources from the Db using a interface to that table.
        }
    }
}
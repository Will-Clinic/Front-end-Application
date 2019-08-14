using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WAWillClinicFrontEnd.Models.Resource;

namespace WAWillClinicFrontEnd.Models.Interfaces
{
    interface IResource
    {
        //Create
        Task CreateResource(Resource resource);

        //GrabAll
        Task<List<Resource>> GetAllResources();

        //GrabAllByType
        Task<List<Resource>> GetAllResourcesByType(ResourceType type);

        //GrabByID
        Task<Resource> GetResourceById(int id);

        //update
        Task UpdateResource(Resource resource);

        //Delete
        Task DeleteResource(int id);
    }
}

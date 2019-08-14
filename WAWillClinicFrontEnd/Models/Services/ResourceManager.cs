using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Models.Interfaces;
using static WAWillClinicFrontEnd.Models.Resource;

namespace WAWillClinicFrontEnd.Models.Services
{
    public class ResourceManager : IResource
    {
        /// <summary>
        /// Creates a Resource and Saves it to the Database
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public Task CreateResource(Resource resource)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a Resource and Saves Changes to the Database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteResource(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets All of the Resources from the Database
        /// </summary>
        /// <returns>Returns a List of all those resources</returns>
        public Task<List<Resource>> GetAllResources()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Grabs all the Resources of the same ResourceType
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Returns a List of all those resources</returns>
        public Task<List<Resource>> GetAllResourcesByType(ResourceType type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Grabs the Resource by id  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the Resource if found</returns>
        public Task<Resource> GetResourceById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the Resource if it's in the Database
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public Task UpdateResource(Resource resource)
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models.Interfaces;
using static WAWillClinicFrontEnd.Models.Resource;

namespace WAWillClinicFrontEnd.Models.Services
{
    public class ResourceManager : IResource
    {

        private UserDbContext _context;

        public ResourceManager(UserDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Creates a Resource and Saves it to the Database
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public async Task CreateResource(Resource resource)
        {
            _context.Resources.Add(resource);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a Resource and Saves Changes to the Database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteResource(int id)
        {
            Resource resource = await GetResourceById(id);
            if(resource != null)
            {
                _context.Resources.Remove(resource);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Gets All of the Resources from the Database
        /// </summary>
        /// <returns>Returns a List of all those resources</returns>
        public async Task<List<Resource>> GetAllResources()
        {
            return await _context.Resources.ToListAsync();
        }

        /// <summary>
        /// Grabs all the Resources of the same ResourceType
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Returns a List of all those resources</returns>
        public async Task<List<Resource>> GetAllResourcesByType(ResourceType type)
        {
            return await _context.Resources.Where(reso => reso.Type == type).ToListAsync();
        }

        /// <summary>
        /// Grabs the Resource by id  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the Resource if found</returns>
        public async Task<Resource> GetResourceById(int id)
        {
            Resource resource = await _context.Resources.FirstOrDefaultAsync(reso => reso.ID == id);
            return resource;
        }

        /// <summary>
        /// Updates the Resource if it's in the Database
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        public async Task UpdateResource(Resource resource)
        {
            _context.Resources.Update(resource);
            await _context.SaveChangesAsync();
        }
    }
}

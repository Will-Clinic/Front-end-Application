using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Data;
using WAWillClinicFrontEnd.Models.Interfaces;
using WAWillClinicFrontEnd.Models.ViewModels;

namespace WAWillClinicFrontEnd.Models.Services
{
    public class VolunteerManager : IVolunteer
    {
        private UserDbContext _context;

        public VolunteerManager(UserDbContext context)
        {
            _context = context;
        }

        public async Task CreateVolunteer(Volunteer volunteer)
        {
            _context.Volunteers.Add(volunteer);
            await _context.SaveChangesAsync();
        }

        public Task DeleteVolunteer(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Volunteer>> GetAllVolunteers()
        {
            throw new NotImplementedException();
        }

        public Task<Volunteer> GetVolunteerById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public Task UpdateVolunteer(Volunteer volunteer)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAWillClinicFrontEnd.Models.ViewModels;

namespace WAWillClinicFrontEnd.Models.Interfaces
{
    public interface IVolunteer
    {
        Task CreateVolunteer(Volunteer volunteer);

        Task<Volunteer> GetVolunteerById(int id);


        Task<List<Volunteer>> GetAllVolunteers();

        Task UpdateVolunteer(Volunteer volunteer);

        Task DeleteVolunteer(Volunteer volunteer);

        Task SaveChangesAsync();
    }
}

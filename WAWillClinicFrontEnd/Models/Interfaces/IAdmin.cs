using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAWillClinicFrontEnd.Models.Interfaces
{
    public interface IAdmin
    {
        Task CreateAdmin(ApplicationUser admin);

        Task<List<ApplicationUser>> GetAllAdmins();

        Task UpdateAdmin(ApplicationUser admin);

        Task DeleteAdmin(int id);
    }
}

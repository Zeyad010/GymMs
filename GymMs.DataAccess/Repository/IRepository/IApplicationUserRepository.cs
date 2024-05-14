using GymMs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMs.DataAccess.Repository.IRepository
{
    public interface IApplicationUserRepository : IRepository<ApplicationUserM>
    {
        public void Update(ApplicationUserM applicationUser);    
    }
}

using GymMs.DataAccess.Repository.IRepository;
using GymMs.DataAccess.Data;
using GymMs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GymMs.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUserM>, IApplicationUserRepository {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ApplicationUserM applicationUser)
        {
            _db.TbApplicationUser.Update(applicationUser);

        }


		public void Save()
		{
			_db.SaveChanges();
		}

	}
}

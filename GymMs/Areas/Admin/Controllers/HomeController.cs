using GymMs.Data;
using GymMs.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymMs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult List()
        {
            List<UserM> objUsersList =_db.TbUsers.ToList();

            return View(objUsersList);
        }


		public IActionResult Create() {
        
        
         return View();
        }

        [HttpPost]
		public IActionResult Create(UserM obj)
		{
            _db.TbUsers.Add(obj);
            _db.SaveChanges();

			return RedirectToAction("List");
		}



	}
}

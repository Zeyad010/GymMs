using GymMs.DataAccess.Data;
using GymMs.Models;
using GymMs.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymMs.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles =SD.Role_Admin)]
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _db;
		public HomeController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult List()
		{
			List<UserM> objUsersList = _db.TbUsers.ToList();

			return View(objUsersList);
		}


		public IActionResult Create()
		{


			return View();
		}
		// Test
		//Test 2
		public IActionResult Info(int? id)
		{
			if (id == null || id == 0)
			{



				return NotFound();

			}

			UserM? UserFromDb = _db.TbUsers.Find(id);

			if (UserFromDb == null)
			{

				return NotFound();
			}




			return View(UserFromDb);
		}

		[HttpPost]
		public IActionResult Create(UserM obj)
		{
			if (ModelState.IsValid)
			{


				_db.TbUsers.Add(obj);
				_db.SaveChanges(); 
				TempData["success"] = "Created Successfully";
				return RedirectToAction("List");


			}

			return View();
		}

		public IActionResult Edit(int? id) { 
			
			
			
			if(id == null||id==0) {
			
			
			
			return NotFound();
			
			}

			UserM? UserFromDb =_db.TbUsers.Find(id);
			
			if(UserFromDb ==null) {

				return NotFound();
			}
			
			
			
			return View(UserFromDb);
		}


		[HttpPost]
		public IActionResult Edit(UserM obj)
		{
			if (ModelState.IsValid)
			{


				_db.TbUsers.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("List");


			}

			return View();
		}



		public IActionResult Delete(int? id)
		{



			if (id == null || id == 0)
			{



				return NotFound();

			}

			UserM? UserFromDb = _db.TbUsers.Find(id);

			if (UserFromDb == null)
			{

				return NotFound();
			}


			return View(UserFromDb);
		}


		[HttpPost,ActionName("Delete")]
		public IActionResult DeletePOST(int? id)
		{
			UserM? obj = _db.TbUsers.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.TbUsers.Remove(obj);
			_db.SaveChanges();
			
			TempData["success"] = "Deleted Successfully";
				return RedirectToAction("List");
		}
		// Helo




	}
}

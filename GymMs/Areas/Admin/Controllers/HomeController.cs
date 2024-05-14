using GymMs.DataAccess.Data;
using GymMs.DataAccess.Repository.IRepository;
using GymMs.Models;
using GymMs.Models.ViewModels;
using GymMs.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GymMs.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles =SD.Role_Admin)]
	public class HomeController : Controller
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;	

		private readonly IApplicationUserRepository _ApplicationUser;
		public HomeController(IApplicationUserRepository db , UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_ApplicationUser = db;
			_roleManager = roleManager;
			_userManager = userManager;
		}
		public IActionResult List()
		{
			
			

			return View();
		}


		

	


		#region API CALLS

		[HttpGet]
		public IActionResult GetAll()
		{
			List<ApplicationUserM> objUserList = _ApplicationUser.GetAll().ToList();

			
			foreach (var user in objUserList) {

				user.Role= _userManager.GetRolesAsync(user).GetAwaiter().GetResult().FirstOrDefault();




			}

			return Json(new { data = objUserList });
		}


        #endregion

    }
}

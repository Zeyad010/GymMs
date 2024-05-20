using GymMs.DataAccess.Data;
using GymMs.DataAccess.Repository.IRepository;
using GymMs.Models;
using GymMs.Models.ViewModels;
using GymMs.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GymMs.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles =SD.Role_Admin)]
	public class UserController : Controller
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;	

		private readonly IApplicationUserRepository _ApplicationUser;
		public UserController(IApplicationUserRepository db , UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_ApplicationUser = db;
			_roleManager = roleManager;
			_userManager = userManager;
		}
		public IActionResult List()
		{
            List<ApplicationUserM> objUserList = _ApplicationUser.GetAll().ToList();


            return View();
		}

		public IActionResult RoleManagment(string userId)
		{

			RoleManagmentVM RoleVM = new RoleManagmentVM()
			{
				ApplicationUser = _ApplicationUser.Get(u => u.Id == userId),
				RoleList = _roleManager.Roles.Select(i => new SelectListItem
				{
					Text = i.Name,
					Value = i.Name
				}),
			};

			RoleVM.ApplicationUser.Role = _userManager.GetRolesAsync(_ApplicationUser.Get(u => u.Id == userId))
					.GetAwaiter().GetResult().FirstOrDefault();
			return View(RoleVM);
		}






		[HttpPost]
		public IActionResult RoleManagment(RoleManagmentVM roleManagmentVM)
		{

			string oldRole = _userManager.GetRolesAsync(_ApplicationUser.Get(u => u.Id == roleManagmentVM.ApplicationUser.Id))
					.GetAwaiter().GetResult().FirstOrDefault();

			ApplicationUserM applicationUser = _ApplicationUser.Get(u => u.Id == roleManagmentVM.ApplicationUser.Id);


			if (!(roleManagmentVM.ApplicationUser.Role == oldRole))
			{
				//a role was updated
				
				_ApplicationUser.Update(applicationUser);
				_ApplicationUser.Save();

				_userManager.RemoveFromRoleAsync(applicationUser, oldRole).GetAwaiter().GetResult();
				_userManager.AddToRoleAsync(applicationUser, roleManagmentVM.ApplicationUser.Role).GetAwaiter().GetResult();

			}
			

			return RedirectToAction("List");
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

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult AdminDashboard(string selectedUserId = null)
        {
          var lstUsers= _userManager.Users.ToList();
            var lstRoles = _roleManager.Roles.Select(r => r.Name).ToList();
            IdentityUser selectedUser=null;
            string[] selectedUserRoles = new string[] { };

            if (!string.IsNullOrEmpty(selectedUserId))
            {
                selectedUser = _userManager.FindByIdAsync(selectedUserId).Result;
                if (selectedUser != null)
                {
                    selectedUserRoles = _userManager.GetRolesAsync(selectedUser).Result.ToArray();
                }
            }
            ViewBag.SelectedUser = selectedUser;
            ViewBag.SelectedUserId = selectedUserId;
            ViewBag.SelectedUserRoles = selectedUserRoles;
            ViewBag.Users= lstUsers;
            ViewBag.AllRoles = lstRoles;
            return View();
        }

        [HttpPost]
        public IActionResult UpdateUser(string userId, string email, string userName, string password, string[] selectedRoles)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
          user.Email=email;
            user.UserName=userName;
            if (!string.IsNullOrEmpty(password))
            {
                var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;
                var passwordResult = _userManager.ResetPasswordAsync(user, token, password).Result;
            }
                var updateResult = _userManager.UpdateAsync(user).Result;
            //Chechikng what roles does the slected user has rn
            var currentRoles= _userManager.GetRolesAsync(user).Result;
            //Checking what new roles were selected by admin to add 
            var rolesToAdd = selectedRoles.Except(currentRoles);
            //Checking what new roles were selected by admin to remove
            var rolesToRemove = currentRoles.Except(selectedRoles);
            _userManager.AddToRolesAsync(user, rolesToAdd).Wait();
            _userManager.RemoveFromRolesAsync(user, rolesToRemove).Wait();

            return RedirectToAction("AdminDashboard");
        

        }

        [HttpPost]
        public IActionResult DeleteUser(string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            _userManager.DeleteAsync(user).Wait();
            return RedirectToAction("AdminDashboard");

        }

        [HttpPost]
        public IActionResult CreateUser(string email,  string password, string[] selectedRoles)
        {
            var newUser = new IdentityUser { Email = email, UserName = email};
            var result = _userManager.CreateAsync(newUser, password).Result;



            if (selectedRoles?.Length > 0)
            {
                _userManager.AddToRolesAsync(newUser, selectedRoles).Wait();
            }

            return RedirectToAction("AdminDashboard");
        }
    }
}

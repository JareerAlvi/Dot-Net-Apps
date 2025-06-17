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

            var emailResult = _userManager.SetEmailAsync(user, email).Result;
            if (!emailResult.Succeeded)
            {
                foreach (var error in emailResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            user.UserName = email;

            if (!string.IsNullOrEmpty(password))
            {
                var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;
                var passwordResult = _userManager.ResetPasswordAsync(user, token, password).Result;

                if (!passwordResult.Succeeded)
                {
                    foreach (var error in passwordResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            var updateResult = _userManager.UpdateAsync(user).Result;
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            if (!ModelState.IsValid)
            {
                var errorList = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .Where(msg => !string.IsNullOrWhiteSpace(msg))  // filter out empty messages
                    .ToList();

                if (errorList.Any())
                {
                    TempData["Errors"] = string.Join("|||", errorList);
                }

                return RedirectToAction("AdminDashboard", new { selectedUserId = user.Id });
            }

            // Update roles
            var currentRoles = _userManager.GetRolesAsync(user).Result;
            var rolesToAdd = selectedRoles.Except(currentRoles);
            var rolesToRemove = currentRoles.Except(selectedRoles);
            _userManager.AddToRolesAsync(user, rolesToAdd).Wait();
            _userManager.RemoveFromRolesAsync(user, rolesToRemove).Wait();

            return RedirectToAction("AdminDashboard");
        }



        [HttpPost]
        public IActionResult DeleteUser(string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            if(userId==)
            _userManager.DeleteAsync(user).Wait();
            return RedirectToAction("AdminDashboard");

        }

        [HttpPost]
        [HttpPost]
        public IActionResult CreateUser(string email, string password, string[] selectedRoles)
        {
            var newUser = new IdentityUser { Email = email, UserName = email };
            var result = _userManager.CreateAsync(newUser, password).Result;

            if (!result.Succeeded)
            {
                var errors = result.Errors
                    .Select(e => e.Description)
                    .Where(msg => !string.IsNullOrWhiteSpace(msg))
                    .ToList();

                if (errors.Any())
                {
                    TempData["Errors"] = string.Join("|||", errors);
                }

                return RedirectToAction("AdminDashboard");
            }


            if (selectedRoles?.Length > 0)
            {
                _userManager.AddToRolesAsync(newUser, selectedRoles).Wait();
            }

            return RedirectToAction("AdminDashboard");
        }

    }
}

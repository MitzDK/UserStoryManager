using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStoryManager.Models;
using UserStoryManager.Services;

namespace UserStoryManager.Pages.LogIn
{
    public class LoginPageModel : PageModel
    {
        public static User LoggedInUser { get; set; } = null;
        private UserService _userService;

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        public string Message { get; set; }
        public LoginPageModel(UserService userService)
        {
            _userService = userService;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            List<User> users = _userService.GetUsers();
            foreach (var user in users)
            {
                if (UserName.ToLower() == user.UserName.ToLower() && Password == user.Password)
                {
                    LoggedInUser = user;
                    var claims = new List<Claim> {new Claim(ClaimTypes.Name, UserName)};
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/UserStory/UserStories");
                }
            }
            Message = "Invalid Attempt";
            return Page();
        }
    }
}

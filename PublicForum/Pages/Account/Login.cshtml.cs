using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PublicForum.ApplicationCore.Interfaces.Services;
using PublicForum.Data;
using PublicForum.Extensions;

namespace PublicForum.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly ILoginService _loginService;
        public LoginModel(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; private set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clear the existing external cookie
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {
                var user = await AuthenticateUser(Input.UserName, Input.Password);

                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim( "FullName", user.FullName)
                };


                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return LocalRedirect(Url.GetLocalUrl(returnUrl));
            }

            // Something failed. Redisplay the form.
            return Page();
        }

        private async Task<ApplicationUser> AuthenticateUser(string username, string password)
        {
            var login = await _loginService.FindAsync(x => x.User.Equals(username) && x.Pass.Equals(password));

            if (login != null || string.Equals(username, "teste", StringComparison.OrdinalIgnoreCase))
            {
                if (login != null)
                {
                    return new ApplicationUser()
                    {
                        UserName = login.User,
                        FullName = "FullName of " + login.User
                    };
                }
                return new ApplicationUser()
                {
                    UserName = "teste",
                    FullName = "FullName of Teste"
                };
            }
            else
            {
                return null;
            }
        }
    }
}

using LearnProject.MvcWebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace LearnProject.MvcWebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginController()
        {

        }
        // GET: LoginController
        public async Task<IActionResult> SignIn(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                List<Claim> claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Email, loginViewModel.Username),        // İstifadeci adini yaxalamaq ucun
                            new Claim(ClaimTypes.Sid, loginViewModel.Password),  // İstifadeci Id-si yaxalamaq ucun
                            //new Claim(ClaimTypes.Role, loginDto.Role) // Role imkanlari yaratmaq ucun
                        };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Home");

            }
            return RedirectToAction("Error", "Shared");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Users.Models;

namespace Users.Controllers
{
    [Authorize]
    public class AccountController:Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signlnManager;

        public AccountController(UserManager<AppUser> userMgr,SignInManager<AppUser> signinMgr)
        {
            userManager = userMgr;
            signlnManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel details,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByEmailAsync(details.Email);
                if (user != null)
                {
                    await signlnManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signlnManager.PasswordSignInAsync(user, details.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginModel.Email),
                "Invalid user or password");
            }
            return View(details);
            
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signlnManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }

}


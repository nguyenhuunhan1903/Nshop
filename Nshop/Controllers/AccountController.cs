using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
/*using Microsoft.AspNetCore.Identity.EntityFrameworkCore;*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nshop.Models;
using Nshop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Nshop.Controllers
{
    
    public class AccountController : Controller
    {
        private NShopContext db = new NShopContext();
        //constructor sample
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager,
                                      SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult OpenLogin(string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View("Login",model);
        }
        public IActionResult OpenSignUp(RegisterViewModel model)
        {
            return View("Signup",model);
        }

        public async Task<IActionResult> Logout()
        {
         
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromForm]LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.AppUsers.FirstOrDefault(x=>x.Email==model.Email);
                var password = await _userManager.CheckPasswordAsync(user, model.Password);

                if (password)//true
                {
                    var result = await _signInManager.PasswordSignInAsync(user.UserName,
                    model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                       
                        if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))//false
                        {
                            return Redirect(model.ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View("Login",model);
        }

        
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromForm]RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new AppUser
                {
                    FirstName=model.FirstName,
                    UserName = model.Email,
                    LastName=model.LastName,
                    Dob=(DateTime)model.dob,
                    address=model.address,
                    PhoneNumber=model.NumberPhone,
                    Email = model.Email
                };
               
                    var result = await _userManager.CreateAsync(user, model.Password);

                    // If user is successfully created, sign-in the user using
                    // SignInManager and redirect to index action of HomeController
                    if (result.Succeeded)
                    {
                    
                    await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("index", "home");
                    }
                    // If there are any errors, add them to the ModelState object
                    // which will be displayed by the validation summary tag helper
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
               
            }

            return View("Signup",model);
        }
        public IActionResult OpenProfile()
        {
            var user = db.AppUsers.Find(_userManager.GetUserAsync(User).Result.Id);
            return View("Profile", user);
        }
        public IActionResult SaveProfile(AppUser user)
        {

            
            var userCurrent = _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                userCurrent.Result.UserName = user.Email;//vì cái này là duy nhất
                userCurrent.Result.FirstName = user.FirstName;
                userCurrent.Result.LastName = user.LastName;
                userCurrent.Result.Email = user.Email;
                userCurrent.Result.address = user.address;
                 var result=_userManager.UpdateAsync(userCurrent.Result);
                
                if (result.Result.Succeeded)
                {
                    ViewBag.Msg = "*Đã cập nhật xong dữ liệu";
                    return View("Profile", userCurrent.Result);
                }

                foreach (var error in result.Result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View("Profile", userCurrent.Result);
        }
    }
}


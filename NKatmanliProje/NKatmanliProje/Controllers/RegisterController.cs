using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NKatmanliProje.Models;

namespace NKatmanliProje.Controllers
{
    public class RegisterController : Controller
    {
        // userManager register islemi icin kullanilacak.
        private readonly UserManager<AppUser> _userManager;

        // constructor olustu
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        // await olacagi icin async Task kullanildi.
        public async Task<IActionResult> Index(UserRegister model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                UserName = model.Username,
                Gender = model.Gender,
                Email = model.Email,
            };
            if(model.Password == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser,model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
          
            return View(model);
        }
    }
}

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NKatmanliProje.Models;

namespace NKatmanliProje.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditModel uem = new UserEditModel();
            uem.Name = values.Name;
            uem.Surname = values.Surname;
            uem.Email = values.Email;
            uem.Gender = values.Gender;
            return View(uem);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user!.Name = p.Name;
            user!.Surname = p.Surname;
            user!.Email = p.Email;
            user!.Gender = p.Gender;
            user!.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Product");
            }
            return View();
        }
    }
}

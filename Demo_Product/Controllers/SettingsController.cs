using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager) //SettingsController sınıfı üzerinden Consractor oluşturdum.
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); //User.Identity.Name ile giriş yapan kullanıcının bilgilerini alır.
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.SurName = values.Surname;
            userEditViewModel.Email = values.Email;
            userEditViewModel.Gender = values.Gender;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user=_userManager.FindByNameAsync(User.Identity.Name).Result; //User.Identity.Name ile giriş yapan kullanıcının bilgilerini alır.
            user.Name = p.Name;
            user.Surname = p.SurName;
            user.Email = p.Email;
            user.Gender = p.Gender;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password); //Kullanıcının şifresini hashler.
            var result = await _userManager.UpdateAsync(user); //Kullanıcı bilgilerini günceller.
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description); //ModelState hatalarını ekler.
                }
            }
            return View(user);
        }
    }
}

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
            var values = await _userManager.FindByIdAsync(User.Identity.Name); //User.Identity.Name ile giriş yapan kullanıcının bilgilerini alır.
            return View();
        }
    }
}

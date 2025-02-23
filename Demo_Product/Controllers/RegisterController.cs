using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

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
        public async Task<IActionResult> Index(UserRegisterViewModel model) //UserRegisterViewModel sınıfından "model" parametresi ürettim.Await kullanacağım için async Task kulandım.
        {
            AppUser appUser = new AppUser()
            {
                Name= model.Name,
                Surname=model.SurName,
                UserName=model.UserName,
                Email=model.Email
            };
            if(model.Password==model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, model.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login"); //Login Controllerdaki index aksiyonuna gider.
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}

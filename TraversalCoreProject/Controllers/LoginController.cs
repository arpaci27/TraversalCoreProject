using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

		public LoginController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult SignUp()
		{
			return View();

		}

		[HttpPost]
		public async Task<IActionResult> SignUp(UserRegisterViewModel p)
		{
			return View();
		}

		[HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        //[HttpPost]
        //IActionResult SignIn()
        //{
        //    return View();
        //}
    }
}

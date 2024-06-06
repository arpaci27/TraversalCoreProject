using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
      
        }

        //[HttpPost]  
        //IActionResult SignUp()
        //{
        //    return View();
        //}
    
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

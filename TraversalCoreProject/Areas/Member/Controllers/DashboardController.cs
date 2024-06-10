using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserName = values.Name + "" + values.Surname;
            ViewBag.UserImage = values.ImageUrl;//Burdan devam 43. video 14.25 dk kaldığım yer
            return View();
        }
    }
}

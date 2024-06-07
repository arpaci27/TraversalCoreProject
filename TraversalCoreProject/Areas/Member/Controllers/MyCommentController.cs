using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    public class MyCommentController : Controller
    {
        [Area("Member")]
        [AllowAnonymous]        
        public IActionResult Index()
        {
            return View();
        }
    }
}

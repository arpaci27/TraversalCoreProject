using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager _commentManager =  new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentManager.TGetDestinationById(id);   
            return View(values);
        }
    }
}

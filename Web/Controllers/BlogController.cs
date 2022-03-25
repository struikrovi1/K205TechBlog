using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class BlogController : Controller

    {
        private readonly IBlogManager _blogManager;

        public BlogController(IBlogManager blogManager)
        {
            _blogManager = blogManager;
        }

        public IActionResult Detail(int? id)
        {
            var blog = _blogManager.GetById(id);
            return View(blog);
        }
    }
}

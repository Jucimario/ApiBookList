using Microsoft.AspNetCore.Mvc;

namespace APIBookList.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

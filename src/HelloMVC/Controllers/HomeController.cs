using HelloMVC.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            User user = new User()
            {
                Name = "My name",
                Address = "My address"
            };
            return View(user);
        }
    }
}

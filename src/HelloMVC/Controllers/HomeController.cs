using HelloMVC.Models;
using HelloMVC.Data;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.ConfigurationModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        IUserRepository _repository;

        public HomeController(IUserRepository repo)
        {
            _repository = repo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var user = _repository.GetUser();
            return View(user);
        }

        public IActionResult ManageStupid(string title)
        {
            return View("ManageStupid", title);
        }
    }
}

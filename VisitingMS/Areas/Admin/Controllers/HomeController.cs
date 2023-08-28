using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitingMS.DataAccess.Repository.IRepository;
using VisitingMS.Models;
using VisitingMS.Utility;

namespace VisitingMS.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUnitOfWork _db;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork db)
        {
            _logger = logger;
            _db = db;
        }


        public IActionResult Home()
        {
            return View();
        }

        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult Index()
        {
            var visitorsList = _db.UserRepository.GetAll(includeproperties: "Department").ToList();
            return View(visitorsList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _db.UserRepository.Get(u => u.Id == id, includeproperties: "Department");
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
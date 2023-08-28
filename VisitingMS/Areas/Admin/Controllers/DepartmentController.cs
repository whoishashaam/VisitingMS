using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitingMS.Data;
using VisitingMS.DataAccess.Repository.IRepository;
using VisitingMS.Models;
using VisitingMS.Utility;

namespace VisitingMS.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.Role_Admin)]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _db;
        public DepartmentController(IUnitOfWork db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var DepartmentList = _db.departmentRepository.GetAll().ToList();
            return View(DepartmentList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(DepartmentModel department)
        {
            if (ModelState.IsValid)
            {
                _db.departmentRepository.Add(department);
                _db.save();
                TempData["success"] = "category Created Sucessfully";

                return RedirectToAction("Index");
            }

            return View(department);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = _db.departmentRepository.Get(u => u.Id == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        [HttpPost]

        public IActionResult Edit(DepartmentModel department)
        {
            if (ModelState.IsValid)
            {

                _db.departmentRepository.Update(department);
                _db.save();
                TempData["success"] = "category updated Sucessfully";

                return RedirectToAction("Index");
            }

            return View(department);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = _db.departmentRepository.Get(u => u.Id == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = _db.departmentRepository.Get(u => u.Id == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        [HttpPost, ActionName("Delete")]

        public IActionResult DeleteConfirmed(int? id)
        {
            var department = _db.departmentRepository.Get(u => u.Id == id);
            if (department == null)
            {
                return NotFound();
            }

            _db.departmentRepository.Remove(department);
            _db.save();
            TempData["success"] = "category Removed Sucessfully";
            return RedirectToAction("Index");
        }
    }
}

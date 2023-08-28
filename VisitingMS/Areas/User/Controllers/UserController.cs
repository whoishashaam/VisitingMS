using Microsoft.AspNetCore.Mvc;
using global::VisitingMS.DataAccess.Repository.IRepository;
using global::VisitingMS.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using VisitingMS.Models.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using VisitingMS.Utility;

namespace VisitingMS.Areas.User.Controllers
{

    [Area("User")]
    [Authorize(Roles = SD.Role_User)]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UserController(IUnitOfWork db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;

            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var visitorsList = _db.UserRepository.GetAll(includeproperties: "Department").ToList();

            return View(visitorsList);
        }

        public IActionResult Upsert(int? id)
        {
            UserVM userVM = new UserVM()
            {
                User = new UserModel(),
                DepartmentList = _db.departmentRepository.GetAll().Select(u => new SelectListItem
                {
                    Text = u.DepartmentName,
                    Value = u.Id.ToString()
                })
            };

            if (id == null || id == 0)
            {
                return View(userVM);
            }
            else
            {
                userVM.User = _db.UserRepository.Get(u => u.Id == id);
                if (userVM.User == null)
                {
                    return NotFound();
                }

                return View(userVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(UserVM userVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string VisitorsPath = Path.Combine(wwwRootPath, @"Images\Visitors");

                    if (!string.IsNullOrEmpty(userVM.User.ImageUrl))
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, userVM.User.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(VisitorsPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    userVM.User.ImageUrl = @"\Images\Visitors\" + fileName;
                }

                if (userVM.User.Id == 0)
                {
                    _db.UserRepository.Add(userVM.User);
                }
                else
                {
                    _db.UserRepository.Update(userVM.User);
                }

                _db.save();
                TempData["success"] = "Category Created Successfully";

                return RedirectToAction("Index");
            }

            userVM.DepartmentList = _db.departmentRepository.GetAll().Select(u => new SelectListItem
            {
                Text = u.DepartmentName,
                Value = u.Id.ToString()
            });

            return View(userVM);
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _db.UserRepository.Get(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var user = _db.UserRepository.Get(u => u.Id == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(user);
        //}

        //[HttpPost, ActionName("Delete")]

        //public IActionResult DeleteConfirmed(int? id)
        //{
        //    var user = _db.UserRepository.Get(u => u.Id == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.UserRepository.Remove(user);
        //    _db.save();
        //    TempData["success"] = "category Removed Sucessfully";
        //    return RedirectToAction("Index");
        //}


        #region API CALLS 

        [HttpGet]
        public IActionResult GetAll()
        {
            var visitorsList = _db.UserRepository.GetAll(includeproperties: "Department").ToList();
            return Json(new { data = visitorsList });
        }
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            var user = _db.UserRepository.Get(u => u.Id == id);
            if (user == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            // Retrieve userVM based on user.Id, similar to how you do it in Upsert
            var userVM = new UserVM()
            {
                User = user,  // Assign the retrieved user to userVM.User
                DepartmentList = _db.departmentRepository.GetAll().Select(u => new SelectListItem
                {
                    Text = u.DepartmentName,
                    Value = u.Id.ToString()
                })
            };

            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, userVM.User.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _db.UserRepository.Remove(user);
            _db.save();

     
            return Json(new { success= true, message="Deleted Sucessfully"});
        }

        #endregion
    }
}

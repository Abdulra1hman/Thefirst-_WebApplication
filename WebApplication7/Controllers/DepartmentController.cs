using Microsoft.AspNetCore.Mvc;
using WebApplication7.data;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbcontext _dbcontext;
        public DepartmentController (AppDbcontext appDbcontext)
        {
            _dbcontext = appDbcontext;
        }

        public IActionResult Index()
        {
            var response = _dbcontext.Departments.ToList();
            return View(response);
        }

        public IActionResult AddForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddForm(Department department) 
        {
            _dbcontext.Departments.Add(department);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index","Department");
        }

        public IActionResult Delete(int id) 
        { 
           var response = _dbcontext.Departments.Find(id);
            _dbcontext.Departments.Remove(response);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index","Department");
        }



        public IActionResult EditForm() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditForm(int id,Department department)
        {
            var response = _dbcontext.Departments.Find(id);
            response.title = department.title;
            response.description = department.description;
            response.headOfDepartment = department.headOfDepartment;
            _dbcontext.SaveChanges();
            return RedirectToAction("Index","Department");
        }

    }
}

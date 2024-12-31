using Microsoft.AspNetCore.Mvc;
using WebApplication7.data;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbcontext _appDbContext;
       public StudentController(AppDbcontext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var respon = _appDbContext.students.ToList();
            return View(respon);
        }

        public IActionResult AddForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddForm(Student student) 
        {
            _appDbContext.students.Add(student);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Student");
        }

        public IActionResult Delete(int id) 
        {
            var respon = _appDbContext.students.Find(id);
            _appDbContext.students.Remove(respon);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Student");
        }

         public IActionResult UpdateForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateForm(int id, Student student)
        {
            var respon = _appDbContext.students.Find(id);
            respon.Name = student.Name;
            respon.Email = student.Email;
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Student");
        }


        public IActionResult ViewTask(int id)
        {
           var respon= _appDbContext.Assigments.Where(x => x.studentId == id).ToList();
            return View(respon);
        }

        public IActionResult UpdateStatues()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateStatues(int id,Assigment assigment)
        {
            var respon = _appDbContext.Assigments.Find(id);
            respon.statues = assigment.statues;
            _appDbContext.SaveChanges();
            return RedirectToAction("ViewTask", "Student");
        }

    }
}

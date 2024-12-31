using Microsoft.AspNetCore.Mvc;
using WebApplication7.data;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class AssigmentController : Controller
    {
        private readonly AppDbcontext _dbcontext;
        public AssigmentController(AppDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index(int id)
        {
           var responses=_dbcontext.Assigments.Where(x => x.departmentId == id).ToList();
            return View(responses);
        }

        public IActionResult AddForm() 
        { 
             return View();
        }

        [HttpPost]
        public IActionResult AddForm(Assigment assigment) 
        {
            _dbcontext.Assigments.Add(assigment);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index","Assigment");
        }

        public IActionResult Delete(int id) 
        { 
            var responses = _dbcontext.Assigments.Find(id);
            _dbcontext.Assigments.Remove(responses);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index", "Assigment");
        }

         public IActionResult UpdateForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateForm(int id,Assigment assigment)
        {
            var responses = _dbcontext.Assigments.Find(id);
            responses.Id = assigment.Id;
            responses.title = assigment.title;
            responses.Description = assigment.Description;
            responses.StarDate = assigment.StarDate;
            responses.EndDate = assigment.EndDate;
            responses.statues = assigment.statues;
            responses.departmentId = assigment.departmentId;
            responses.studentId = assigment.studentId;
            _dbcontext.SaveChanges();
            return RedirectToAction("Index", "Assigment");
        }

    }
}

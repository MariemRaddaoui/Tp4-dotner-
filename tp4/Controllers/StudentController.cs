
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {


            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            StudentRepository studentRepository = new StudentRepository(universityContext);
            return View(studentRepository.GetCourses());
        }

        public IActionResult GetCourse(string id)
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            StudentRepository studentRepository = new StudentRepository(universityContext);
            IEnumerable<Student> result = (IEnumerable<Student>)studentRepository.Find(v => v.Course.ToLower() == id.ToLower());

            if (result.Count() != 0) ViewBag.Id = result.First().Course;
            return View(result);
        }
    }
}
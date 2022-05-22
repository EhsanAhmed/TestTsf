using Microsoft.AspNetCore.Mvc;
using Day1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentList context = new StudentList();
            List<Student> studentList2 = context.StudentsFunc();
            return View("AllStudents", studentList2);
        }

        public IActionResult studentDetails(int id)
        {
            StudentList context = new StudentList();
            List<Student> ProductList = context.StudentsFunc();
            Student student = ProductList.FirstOrDefault(p => p.ID == id);
            return View("GetDetails", student);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SampleSchool.Models;

namespace SampleSchool.Controllers
{
    public class CourseUnitTestController : Controller
    {      
           [NonAction]
        public List<Course> GetCourseList()
        {
            return new List<Course>
            {
                new Course
                {
                    CourseId = "D201",
                    CourseName = "Advanced Programming",
                    Description = "Object-oriented Programming in C#",
                    Year = 2018,
                    Semester = 1,
                },
                new Course
                {
                     CourseId = "D202",
                    CourseName = "Software Process",
                    Description = "Agile Development using ASP.NET Core MVC",
                    Year = 2018,
                    Semester = 2,
                },
            };
        }
         public IActionResult Index()
        {
            var course = from s in GetCourseList() select s;
            return View(course);
        }

        public IActionResult Course()
        {
            var course = from e in GetCourseList()
                           orderby e.CourseId
                           select e;
            return View(course);
        }
    }
}
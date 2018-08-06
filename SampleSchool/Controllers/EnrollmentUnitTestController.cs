using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SampleSchool.Models;

namespace SampleSchool.Controllers
{    public class EnrollmentUnitTestController : Controller
    {       [NonAction]
        public List<Enrolment> GetEnrolmentList()
        {   return new List<Enrolment>
            {   new Enrolment
                {
                    EnrolId = 4,
                    Sid = 18101,
                    CourseId = "D201",
                    EnrolmentYear = 2018,
                    EnrolmentSemester = 1,
                },
                 new Enrolment
                {
                    EnrolId = 5,
                    Sid = 18101,
                    CourseId = "D202",
                    EnrolmentYear = 2018,
                    EnrolmentSemester = 2,
                },
                  new Enrolment
                {
                    EnrolId = 6,
                    Sid = 18102,
                    CourseId = "D201",
                    EnrolmentYear = 2018,
                    EnrolmentSemester = 1,
                },
            };
        }
         public IActionResult Index()
        {   var enrolment = from s in GetEnrolmentList() select s;
            return View(enrolment);
        }
        public IActionResult Enrolment()
        {   var enrolment = from e in GetEnrolmentList()
                           orderby e.EnrolId
                           select e;
            return View(enrolment);
        }
    }
}
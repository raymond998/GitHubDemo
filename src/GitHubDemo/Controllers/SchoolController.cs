using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GitHubDemo.Models;

namespace GitHubDemo.Controllers
{
    public class SchoolController : Controller
    {
        private CollegeDataContext cd;
        public SchoolController(CollegeDataContext _cd)
        {
            cd = _cd;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(School s)
        {
            cd.School.Add(s);
            cd.SaveChanges();
            return View();

        }
    }
}
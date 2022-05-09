using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab.Data;
using WebLab.Model.Lab1;
using WebLab.Views.Home;

namespace WebLab.Controllers
{
    public class HomeController : Controller
    {
        public IEnumerable<Student> Students { get; private set; }
        public IEnumerable<Subject> Subjects { get; private set; }

        public HomeController(Lab1Context lab1Context)
        {
            Students = lab1Context.Students; 
            Subjects = lab1Context.Subjects;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}

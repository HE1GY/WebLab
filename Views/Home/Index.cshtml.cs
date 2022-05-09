using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLab.Controllers;
using WebLab.Data;
using WebLab.Model.Lab1;

namespace WebLab.Views.Home
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Student> Students { get => _homeController.Students; }
        public IEnumerable<Subject> Subjects { get => _homeController.Subjects; }

        private readonly ILogger<IndexModel> _logger;
        private readonly HomeController _homeController;

        public IndexModel(ILogger<IndexModel> logger, HomeController homeController)
        {
            _logger = logger;
            _homeController = homeController;
        }

        public void OnGet()
        {

        }
    }
}

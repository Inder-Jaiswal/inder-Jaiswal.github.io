using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.ProjectModel;
using Port.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static Port.Models.DescriptionModel;

namespace Port.Controllers
{
    public class HomeController : Controller
    {
        //{
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DescriptionModel projectDescription = new DescriptionModel();
            {
                projectDescription.Name = "inder-PortFolio"; 
                projectDescription.Id = "1st"; 
                projectDescription.Description = "the site is built using angular.js , bootstrap, di, html, css, js and other technologies to support this data "; 
                projectDescription.PArchitecture = "Angular on .net"; 
            };
        var listPD = new List<DescriptionModel>();
            listPD.Add(projectDescription);
        return View(listPD);
    }

    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
    }
}

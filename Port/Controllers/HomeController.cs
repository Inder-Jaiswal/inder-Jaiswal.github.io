using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.ProjectModel;
using Port.Models;
using Port.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static Port.Models.DescriptionModel;

namespace Port.Controllers
{
    public class HomeController : Controller
    {
        //{
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _homeService;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, IHomeService homeService, IMapper mapper)
        {
            _logger = logger;
            _homeService = homeService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var listPD = _mapper.Map<List<DescriptionModel>>(_homeService.GetHomes());
            return View(JsonResult(listPD),AllowNullAttribute));
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

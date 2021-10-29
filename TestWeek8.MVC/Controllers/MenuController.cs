using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Core.Interfaces;
using TestWeek8.MVC.Helpers;
using TestWeek8.MVC.Models;

namespace TestWeek8.MVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMainBusinessLayer mainBl;

        public MenuController(IMainBusinessLayer bl)
        {
            this.mainBl = bl;
        }

        public IActionResult Index()
        {
            var result = mainBl.FetchMenus();

            var resultMapping = result.ToListViewModel();
            return View(resultMapping);            
        }

        public IActionResult Detail(int id)
        {
            if (id <= 0)
                return View("Error");

            var menu = mainBl.GetMenuById(id);

            IList<PiattoViewModel> resultMapped = new List<PiattoViewModel>();

            foreach(var p in menu.Piatti)
            {
                var piatto = p.ToViewModel();

                resultMapped.Add(piatto);
            }

            return View("Detail", resultMapped);
        }
    }
}

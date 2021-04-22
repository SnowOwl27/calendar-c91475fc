using CalendarEventWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarEventWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var getDate = DateTime.Now;
            var firstDayOfTheMonth = new DateTime(getDate.Year, getDate.Month, 1);
            var lastDayOfTheMonth = firstDayOfTheMonth.AddMonths(1).AddDays(-1);
            var numberOfDays = Convert.ToInt16(lastDayOfTheMonth.ToString("dd"));


            //CalendarModel calModel = new CalendarModel();
            //calModel.
            return View();
        }
    }
}

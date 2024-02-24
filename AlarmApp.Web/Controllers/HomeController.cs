using AlarmApp.BLL.Abstract;
using AlarmApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AlarmApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly IAlarmService _alarmService;

        public HomeController(ILogger<HomeController> logger,IAlarmService alarmService)
        {
            _logger = logger;
            _alarmService = alarmService;
        }

        public async Task<IActionResult> Index()
        {
            var alarms = await _alarmService.GetAlarm();

            return View(alarms);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

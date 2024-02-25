using AlarmApp.BLL.Abstract;
using AlarmApp.Web.Dtos;
using AlarmApp.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AlarmApp.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly IAlarmService _alarmService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger,IAlarmService alarmService, IMapper mapper)
        {
            _logger = logger;
            _alarmService = alarmService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var alarms = await _alarmService.GetAlarm();
            
            var alarmss = alarms.Select(c => _mapper.Map<AlarmDto>(c)).ToList();

            return View(alarmss);
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using AlarmApp.BLL.Abstract;
using AlarmApp.DAL.Abstract;
using AlarmApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.BLL.Concrete
{
    public class AlarmService : IAlarmService
    {
        private readonly IAlarmRepository _alarmRepository;

        public AlarmService(IAlarmRepository alarmRepository)
        {
            _alarmRepository = alarmRepository;
        }
        public async Task<List<Alarm>> GetAlarm()
        {
            return await _alarmRepository.GetAlarmList();
        }
    }
}

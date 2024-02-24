using AlarmApp.BLL.Abstract;
using AlarmApp.DAL.Abstract;
using AlarmApp.Entity.Model;
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
        private readonly IAuthRepository _authRepository;

        public AlarmService(IAlarmRepository alarmRepository, IAuthRepository authRepository)
        {
            _alarmRepository = alarmRepository;
            _authRepository = authRepository;

        }
        public async Task<List<Alarm>> GetAlarm()
        {
          
            return await _alarmRepository.GetAlarmList();
        }
    }
}

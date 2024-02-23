using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmApp.Domain.Entities;

namespace AlarmApp.Domain.Repository
{
    public interface IAlarmService
    {
        Task<bool> CreateAlarm(Alarm alarm);
        Task<List<Alarm>> GetAlarmList();
        Task<Alarm> UpdateAlarm(Alarm alarm);
        Task<bool> DeleteAlarm(int key);
    }
}

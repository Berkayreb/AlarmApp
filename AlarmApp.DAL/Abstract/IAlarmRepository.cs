using AlarmApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlarmApp.DAL.Abstract
{
    public interface IAlarmRepository
    {
        Task<bool> CreateAlarm(Alarm alarm);

        Task<List<Alarm>> GetAlarmList();
        Task<bool> DeleteAlarm(Guid key);
    }
}

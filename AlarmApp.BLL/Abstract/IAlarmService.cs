using AlarmApp.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.BLL.Abstract
{
    public interface IAlarmService
    {
        Task<List<Alarm>> GetAlarm();
    }
}

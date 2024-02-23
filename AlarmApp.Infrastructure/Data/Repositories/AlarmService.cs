using AlarmApp.Domain.Entities;
using AlarmApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.Infrastructure.Data.Repositories
{
    public class AlarmService:IAlarmService
    {
        private readonly IDbService _dbService;


        public AlarmService(IDbService dbService)
        {
            _dbService = dbService;   
        }

        public async Task<bool> CreateAlarm(Alarm alarm)
        {
            var result = await _dbService.EditData(
                "INSERT INTO public.alarms (id,startdate,enddate,type,setvalue,resetValue) VALUES (@Id,@StartDate,@EndDate,@Type,@SetValue,@ResetValue) ",
                alarm);
            return true;
        }

        public async Task<bool> DeleteAlarm(Guid id)
        {
            var deleteAlarm = await _dbService.EditData("DELETE FROM public.alarms WHERE id = @Id", new { id });
            return true;
        }

        public async Task<List<Alarm>> GetAlarmList()
        {
            var alarmList = await _dbService.GetAll<Alarm>("SELECT * FROM public.alarms", new { });
            return alarmList;
        }

        public async Task<Alarm> GetAlarm(Guid id)
        {
            var alarmList = await _dbService.GetAsync<Alarm>("SELECT * FROM public.alarms where id=@id", new { id });
            return alarmList;
        }

    }
}

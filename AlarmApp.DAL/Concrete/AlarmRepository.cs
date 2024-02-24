
using AlarmApp.DAL.Abstract;
using AlarmApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp.DAL.Concrete
{
    public class AlarmRepository:IAlarmRepository
    {
        private readonly IDbService _dbService;


        public AlarmRepository(IDbService dbService)
        {
            _dbService = dbService;   
        }

        public async Task<bool> CreateAlarm(Alarm alarm)
        {
            var result = await _dbService.EditData(
                "INSERT INTO public.alarm (id,startdate,enddate,type,setvalue,resetValue) VALUES (@Id,@StartDate,@EndDate,@Type,@SetValue,@ResetValue) ",
                alarm);
            return true;
        }

        public async Task<bool> DeleteAlarm(Guid id)
        {
            var deleteAlarm = await _dbService.EditData("DELETE FROM public.alarm WHERE id = @Id", new { id });
            return true;
        }

        public async Task<List<Alarm>> GetAlarmList()
        {
            var alarmList = await _dbService.GetAll<Alarm>("SELECT * FROM public.alarm", new { });
            return alarmList;
        }

        public async Task<Alarm> GetAlarm(Guid id)
        {
            var alarmList = await _dbService.GetAsync<Alarm>("SELECT * FROM public.alarm where id=@id", new { id });
            return alarmList;
        }

    }
}

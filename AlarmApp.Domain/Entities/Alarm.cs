using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlarmApp.Domain.Shared;
using static AlarmApp.Domain.Shared.Enums;

namespace AlarmApp.Domain.Entities
{
    public class Alarm
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public AlarmType Type { get; set; }

        public double SetValue { get; set; }

        public double ResetValue { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlarmApp.Entity.Model.Enums;


namespace AlarmApp.Entity.Model
{
    public class Alarm
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Type { get; set; }

        public double SetValue { get; set; }

        public double ResetValue { get; set; }
    }
}

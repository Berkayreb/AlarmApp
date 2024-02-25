using static AlarmApp.Entity.Model.Enums;

namespace AlarmApp.Web.Dtos
{
    public class AlarmDto
    {
        public Guid Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int Type { get; set; }

        public double? SetValue { get; set; }

        public double? ResetValue { get; set; }

        public string Status
        {
            get
            {
                if (EndDate == null || ResetValue == null)
                {
                    return "Open";
                }
                else
                {
                    return "Closed";
                }
            }
        }

        public string TypeName
        {
            get
            {
                switch (Type)
                {
                    case 1:
                        return "Temperature";
                    case 2:
                        return "Vibration";
                    case 3:
                        return "Acoustic";
                    case 4:
                        return "Magnetic";
                    default:
                        return "Unknown";
                }
            }
        }





    }
}

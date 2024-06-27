using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Models
{
    public class WeeklyEvent
    {
        public int event_id { get; set; }
        public string event_name { get; set; }
        public int event_day { get; set; }
        public int event_start_time { get; set; }
        public int event_end_time { get; set; }
        public int event_duration { get; set; }
    }
}

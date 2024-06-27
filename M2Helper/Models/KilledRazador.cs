using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Models
{
    public class KilledRazador
    {
        public int Id { get; set; }
        public int Time_spent_by_second { get; set; }
        public DateTime When_killed { get; set; }
        public int Chest_Count { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Models
{
    public class Cooldowns
    {
        public int id { get; set; }
        public DateTime next_razador_time { get; set; }
        public DateTime next_nemere_time { get; set; }
        public DateTime next_hidra_time { get; set; }
        public DateTime next_beranSetau_time { get; set; }
        public DateTime next_biolog_time { get; set; }
        public DateTime costume_helmet_end_time { get; set; }
        public DateTime costume_armor_end_time { get; set; }
        public DateTime costume_weapon_end_time { get; set; }
        public DateTime six_seven_enchant_time { get; set; }
        public int userId { get; set; }

        public Users User { get; set; }
    }
}

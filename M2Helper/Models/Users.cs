using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [StringLength(255)]
        [EmailAddress]
        public string UserMailAddress { get; set; }

        [StringLength(255)]
        public string UserPassword { get; set; }

        [StringLength(255)]
        public string UserType { get; set; }

        [StringLength(255)]
        public string ActiveKey { get; set; }
        public ICollection<KilledRazador> KilledRazadors { get; set; }
        public ICollection<Cooldowns> Cooldowns { get; set; }
    }
}

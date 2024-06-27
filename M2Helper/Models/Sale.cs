using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int Won_amount { get; set; }
        public int Price { get; set; }
        public DateTime Sales_date { get; set; }
    }
}

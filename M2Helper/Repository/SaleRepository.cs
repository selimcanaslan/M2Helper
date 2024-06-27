using M2Helper.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace M2Helper.Repository
{
    public class SaleRepository
    {
        public async Task<DataTable> ReadSales()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("WonAmount", typeof(int));
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("SalesDate", typeof(DateTime));

            using (var context = new ApplicationDbContext())
            {
                var records = await context.Sales.OrderByDescending(r => r.Id).ToListAsync();

                foreach (var record in records)
                {
                    dataTable.Rows.Add(record.Id, record.Won_amount, record.Price, record.Sales_date);
                }
            }

            return dataTable;
        }
    }
}

using M2Helper.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Repository
{
    public class KeyRepository
    {
        public async Task<DataTable> getDetailOfGivenKey(string key)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("KeyString", typeof(string));
            dataTable.Columns.Add("EndOfUse", typeof(DateTime));

            using (var context = new ApplicationDbContext())
            {
                var record = await context.Keys
                                          .FirstOrDefaultAsync(k => k.key_string == key);
                if (record != null)
                {
                    dataTable.Rows.Add(record.id, record.key_string, record.end_of_use);
                    return dataTable;
                }
                else
                {
                    MessageBox.Show("There is no such key!");
                    return null;
                }
            }
        }
    }
}

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
    public class WeeklyEventRepository
    {
        public async Task<DataTable> ReadEvents()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("event_id", typeof(int));
            dataTable.Columns.Add("event_name", typeof(string));
            dataTable.Columns.Add("event_day", typeof(int));
            dataTable.Columns.Add("event_start_time", typeof(int));
            dataTable.Columns.Add("event_end_time", typeof(int));
            dataTable.Columns.Add("event_duration", typeof(int));

            using (var context = new ApplicationDbContext())
            {
                var records = await context.WeeklyEvents.ToListAsync();

                foreach (var record in records)
                {
                    dataTable.Rows.Add(record.event_id, record.event_name, record.event_day, record.event_start_time, record.event_end_time, record.event_duration);
                }
            }

            return dataTable;
        }
    }
}

using M2Helper.Data;
using M2Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace M2Helper.Repository
{
    public class KilledRazadorRepository
    {
        public async void AddKilledRazadorRecord(KilledRazador killedRazador)
        {

            using (var context = new ApplicationDbContext())
            {
                await context.KilledRazadors.AddAsync(killedRazador);
                await context.SaveChangesAsync();
            }

        }

        public async Task<DataTable> ReadKilledRazadorRecords()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("TimeSpentBySecond", typeof(int));
            dataTable.Columns.Add("WhenKilled", typeof(DateTime));
            dataTable.Columns.Add("ChestCount", typeof(int));
            dataTable.Columns.Add("isMoonlightEventSession", typeof(bool));

            using (var context = new ApplicationDbContext())
            {
                var records = await context.KilledRazadors.OrderByDescending(r => r.Id).ToListAsync();

                foreach (var record in records)
                {
                    dataTable.Rows.Add(record.Id, record.Time_spent_by_second, record.When_killed, record.Chest_Count, record.isMoonlightEventSession);
                }
            }

            return dataTable;
        }

        public void DeleteKilledRazadorRecord(int recordId)
        {
            using (var context = new ApplicationDbContext())
            {
                var recordToDelete = context.KilledRazadors.Find(recordId);

                if (recordToDelete != null)
                {
                    context.KilledRazadors.Remove(recordToDelete);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show($"Killed Razador record with Id {recordId} not found.");
                }
            }
        }
        public async Task<KilledRazador> FindKilledRazadorByIdAsync(int recordId)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.KilledRazadors.FindAsync(recordId);
            }
        }
    }
}

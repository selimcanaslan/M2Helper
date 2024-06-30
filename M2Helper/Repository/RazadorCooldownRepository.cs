using M2Helper.Data;
using M2Helper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace M2Helper.Repository
{
    public class RazadorCooldownRepository
    {
        public async Task<DataTable> GetNextRazadorDate()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("next_razador_time", typeof(DateTime));

            using (var context = new ApplicationDbContext())
            {
                var records = await context.RazadorCooldowns.ToListAsync();

                foreach (var record in records)
                {
                    dataTable.Rows.Add(record.next_razador_time);
                }
            }
            return dataTable;
        }

        public void UpdateNextRazadorTime(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var cooldown = context.RazadorCooldowns.Find(id);
                if (cooldown != null)
                {
                    cooldown.next_razador_time = DateTime.Now.AddMinutes(30);
                    context.SaveChanges();
                    Console.WriteLine($"new razador time = {cooldown.next_razador_time}");
                }
                else
                {
                    RazadorCooldown razadorCooldown = new RazadorCooldown();
                    razadorCooldown.next_razador_time = DateTime.Now.AddMinutes(30);
                    context.RazadorCooldowns.Add(razadorCooldown);
                    context.SaveChanges();

                    Console.WriteLine($"new razador time = {razadorCooldown.next_razador_time}");
                }
            }

        }
        public void RemoveRazadorCooldown(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                DateTime date1999 = new DateTime(1999, 1, 1);
                var cooldown = context.RazadorCooldowns.Find(id);
                if (cooldown != null)
                {
                    cooldown.next_razador_time = date1999;
                    context.SaveChanges();
                    Console.WriteLine($"new razador time = {cooldown.next_razador_time}");
                    MessageBox.Show("Razador Cooldown Removed!", "Info");
                }
                else
                {
                    RazadorCooldown razadorCooldown = new RazadorCooldown();
                    razadorCooldown.next_razador_time = date1999;
                    context.RazadorCooldowns.Add(razadorCooldown);
                    context.SaveChanges();
                    MessageBox.Show("Razador Cooldown Removed!", "Info");
                    Console.WriteLine($"new razador time = {razadorCooldown.next_razador_time}");
                }

            }
        }
    }
}

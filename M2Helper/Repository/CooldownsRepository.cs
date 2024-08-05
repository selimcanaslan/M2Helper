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
    public class CooldownsRepository
    {
        public async Task<DataTable> GetCooldownAsDataTableAsync(int userId)
        {
            using (var _context = new ApplicationDbContext())
            {
                var cooldownRecord = await _context.Cooldowns
                                                   .Where(rc => rc.userId == userId)
                                                   .FirstOrDefaultAsync();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("NextRazadorTime", typeof(DateTime));
                dataTable.Columns.Add("NextNemereTime", typeof(DateTime));
                dataTable.Columns.Add("NextHidraTime", typeof(DateTime));
                dataTable.Columns.Add("NextBeranSetauTime", typeof(DateTime));
                dataTable.Columns.Add("NextBiologTime", typeof(DateTime));
                dataTable.Columns.Add("NextCostumeHelmetTime", typeof(DateTime));
                dataTable.Columns.Add("NextCostumeArmorTime", typeof(DateTime));
                dataTable.Columns.Add("NextCostumeWeaponTime", typeof(DateTime));
                dataTable.Columns.Add("NextSixSevenEnchantTime", typeof(DateTime));
                dataTable.Columns.Add("UserId", typeof(int));

                if (cooldownRecord != null)
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = cooldownRecord.id;
                    row["NextRazadorTime"] = cooldownRecord.next_razador_time;
                    row["NextNemereTime"] = cooldownRecord.next_nemere_time;
                    row["NextHidraTime"] = cooldownRecord.next_hidra_time;
                    row["NextBeranSetauTime"] = cooldownRecord.next_beranSetau_time;
                    row["NextBiologTime"] = cooldownRecord.next_biolog_time;
                    row["NextCostumeHelmetTime"] = cooldownRecord.costume_helmet_end_time;
                    row["NextCostumeArmorTime"] = cooldownRecord.costume_armor_end_time;
                    row["NextCostumeWeaponTime"] = cooldownRecord.costume_weapon_end_time;
                    row["NextSixSevenEnchantTime"] = cooldownRecord.six_seven_enchant_time;
                    row["UserId"] = cooldownRecord.userId;
                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
        }
        public void AddOrUpdateRazadorCooldown(int userId)
        {
            using (var _context = new ApplicationDbContext())
            {
                var cooldownRecord = _context.Cooldowns
                            .FirstOrDefault(rc => rc.userId == userId);
                if (cooldownRecord != null)
                {
                    cooldownRecord.next_razador_time = DateTime.Now.AddMinutes(30);
                    Console.WriteLine("Record Found");
                }
                else
                {
                    Console.WriteLine("No Record Found");
                    cooldownRecord = new Cooldowns
                    {
                        userId = userId,
                        next_razador_time = DateTime.Now.AddMinutes(30)
                    };

                    _context.Cooldowns.Add(cooldownRecord);
                }
                int v = _context.SaveChanges();
            }
        }

        public void RemoveCooldown(int userId)
        {
            using (var _context = new ApplicationDbContext())
            {
                DateTime removedCooldownDate = new DateTime(1999, 1, 1);

                var cooldownRecord = _context.Cooldowns
                            .FirstOrDefault(rc => rc.userId == userId);

                if (cooldownRecord != null)
                {
                    cooldownRecord.next_razador_time = removedCooldownDate;
                }
                else
                {
                    cooldownRecord = new Cooldowns
                    {
                        userId = userId,
                        next_razador_time = removedCooldownDate
                    };

                    _context.Cooldowns.Add(cooldownRecord);
                }

                _context.SaveChanges();

            }
        }
        public void UserRegistirationCooldownsFirstCreation(int userId)
        {
            DateTime now = DateTime.Now;
            using (var _context = new ApplicationDbContext())
            {
                Cooldowns cooldownsRecord = new Cooldowns { userId = userId };
                cooldownsRecord.next_razador_time = now;
                cooldownsRecord.next_nemere_time = now;
                cooldownsRecord.next_hidra_time = now;
                cooldownsRecord.next_beranSetau_time = now;
                cooldownsRecord.next_biolog_time = now;
                cooldownsRecord.costume_helmet_end_time = now;
                cooldownsRecord.costume_armor_end_time = now;
                cooldownsRecord.costume_weapon_end_time = now;
                cooldownsRecord.six_seven_enchant_time = now;
                _context.Cooldowns.Add(cooldownsRecord);
                _context.SaveChanges();
            }

        }
    }
}

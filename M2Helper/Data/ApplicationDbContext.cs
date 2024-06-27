using Microsoft.EntityFrameworkCore;
using M2Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace M2Helper.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<KilledRazador> KilledRazadors { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<WeeklyEvent> WeeklyEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"workstation id=metin2helper.mssql.somee.com;packet size=4096;user id=sca33_SQLLogin_1;pwd=ejc7i6uu64;data source=metin2helper.mssql.somee.com;persist security info=False;initial catalog=metin2helper;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KilledRazador>().ToTable("Killed_Razador_List");
            modelBuilder.Entity<Sale>().ToTable("Sales");
            modelBuilder.Entity<WeeklyEvent>().ToTable("weekly_events");

            modelBuilder.Entity<WeeklyEvent>()
                .HasKey(e => e.event_id)
                .HasName("PK_weekly_events");
        }
    }
}

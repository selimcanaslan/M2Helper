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
        public DbSet<Users> Users { get; set; }
        public DbSet<KilledRazador> KilledRazadors { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<WeeklyEvent> WeeklyEvents { get; set; }
        public DbSet<Cooldowns> Cooldowns { get; set; }
        public DbSet<Key> Keys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"workstation id=metin2helper.mssql.somee.com;packet size=4096;user id=sca33_SQLLogin_1;pwd=ejc7i6uu64;data source=metin2helper.mssql.somee.com;persist security info=False;initial catalog=metin2helper;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KilledRazador>().ToTable("Killed_Razador_List");
            modelBuilder.Entity<Sale>().ToTable("Sales");
            modelBuilder.Entity<WeeklyEvent>().ToTable("weekly_events");
            modelBuilder.Entity<Cooldowns>().ToTable("Cooldowns");
            modelBuilder.Entity<Key>().ToTable("Keys");
            modelBuilder.Entity<Users>().ToTable("Users");

            modelBuilder.Entity<WeeklyEvent>()
                .HasKey(e => e.event_id)
                .HasName("PK_weekly_events");
            modelBuilder.Entity<Users>()
                .HasKey(e => e.UserId)
                .HasName("PK_weekly_events");
            modelBuilder.Entity<Cooldowns>()
                .HasKey(e => e.id)
                .HasName("PK_Cooldowns");
            modelBuilder.Entity<KilledRazador>()
            .HasOne(k => k.User)
            .WithMany(u => u.KilledRazadors)
            .HasForeignKey(k => k.UserId);
            modelBuilder.Entity<Cooldowns>()
            .HasOne(k => k.User)
            .WithMany(u => u.Cooldowns)
            .HasForeignKey(k => k.userId);
        }
    }
}

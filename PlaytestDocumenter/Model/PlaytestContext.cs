using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaytestDocumenter.Model
{
    class PlaytestContext : DbContext
    {

        public DbSet<Playtest> Playtests { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Template> Templates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Playtest>().ToTable(nameof(Playtest));
            modelBuilder.Entity<Playtest>().HasKey(p => p.Id);

            modelBuilder.Entity<Map>().ToTable(nameof(Map));
            modelBuilder.Entity<Map>().HasKey(m => m.Name);

            modelBuilder.Entity<Performance>().ToTable(nameof(Performance));
            modelBuilder.Entity<Performance>().HasKey(p => p.Id);
        }

    }
}

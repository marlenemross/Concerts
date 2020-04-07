using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Domain.Objects;

namespace Data
{
    class DataContext : IdentityDbContext
    {
        public DbSet<Musician> Musician { get; set; }
        public DbSet<Concert> Concert { get; set; }
        public DbSet<ConcertMusician> ConcertMusician { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Musician>()
                .HasKey(m => m.MusicianId);
            builder.Entity<Concert>()
                .HasKey(c => c.ConcertId);
            builder.Entity<ConcertMusician>()
                .HasKey(cm => new { cm.MusicianId, cm.ConcertId });
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}

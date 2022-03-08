using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable
// Database-First approach --- this file was generated from the database
namespace ColourAPI.Models
{
    public partial class ColourContext : DbContext
    {
        public DbSet<Colour> ColourItems { get; set; }

        public ColourContext()
        {
        }

        public ColourContext(DbContextOptions<ColourContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colour>(entity =>
            {
                entity.ToTable("Color");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.ColourName).HasColumnType("character varying");
            });

            modelBuilder.Entity<Colour>().
               HasData(
                       new Colour { Id = 1, ColourName = "Red" },
                       new Colour { Id = 2, ColourName = "Orange" },
                       new Colour { Id = 3, ColourName = "Yellow" },
                       new Colour { Id = 4, ColourName = "Green" },
                       new Colour { Id = 5, ColourName = "Blue" },
                       new Colour { Id = 6, ColourName = "Pink" }
               );

            Console.WriteLine("Already have data - Seeding Successful");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

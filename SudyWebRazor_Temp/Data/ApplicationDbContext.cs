﻿using Microsoft.EntityFrameworkCore;
using SudyWebRazor_Temp.Models;

namespace SudyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData
                (
                new Category { Id = 1, Name = "Horror", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-fi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Thriller", DisplayOrder = 3 }
                );

        }




    }
}

﻿using PlannerN.Entity;
using Microsoft.EntityFrameworkCore;


namespace PlannerN.Context
{
    class PlannerContext : DbContext
    {

            public DbSet<Task> Tasks { get; set; }
            private string Dsn { get; }
            public PlannerContext()
            {
                Dsn = "planner.db";
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite($"Filename={Dsn}");
            }
        }
       
    }





using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PlannerN.Context;
using System;

namespace PlannerN.Migrations
{
    [DbContext(typeof(PlannerContext))]
    partial class PlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {

            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("PlannerN.Entity.Task", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasColumnType("INTEGER");

                b.Property<DateTime>("CreateDate")
                    .HasColumnName("createdate")
                    .HasColumnType("TEXT");


                b.Property<DateTime>("ExpDate")
                    .HasColumnName("expdate")
                    .HasColumnType("TEXT");


                b.Property<Boolean>("Status")
                    .HasColumnName("status")
                    .HasColumnType("BOOLEAN");

                b.Property<string>("Description")
                    .HasColumnName("description");


                b.HasKey("Id");

                b.ToTable("tasks");
            });

        }
    }
}

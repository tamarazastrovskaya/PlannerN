using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PlannerN.Context;
using System;


namespace PlannerN.Migrations
{
    [DbContext(typeof(PlannerContext))]
    partial class PlannerContextModelS : ModelSnapshot
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

                b.Property<DateTime>("Createdate")
                    .HasColumnName("createdate")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("ExpDate")
                    .HasColumnName("expdate")
                    .HasColumnType("TEXT");

                b.Property<string>("Status")
                    .HasColumnName("status")
                    .HasColumnType("BOOl");

                b.Property<DateTime>("Description")
                   .HasColumnName("description")
                   .HasColumnType("TEXT");


                b.HasKey("Id");

                _ = b.ToTable(name: "tasks");
            });

        }
    }
}

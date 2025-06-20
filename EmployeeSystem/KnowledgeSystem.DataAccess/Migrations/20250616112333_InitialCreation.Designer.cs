﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using KnowledgeSystem.DataAccess;

#nullable disable

namespace KnowledgeSystem.DataAccess.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20250616112333_InitialCreation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KnowledgeSystem.DataAccess.Entities.Knowledge", b =>
                {
                    b.Property<long>("KnowledgeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("KnowledgeId"));

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.HasKey("KnowledgeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Knowledge", (string)null);
                });

            modelBuilder.Entity("KnowledgeSystem.DataAccess.Entities.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmployeeId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("KnowledgeSystem.DataAccess.Entities.Knowledge", b =>
                {
                    b.HasOne("KnowledgeSystem.DataAccess.Entities.Employee", "Employee")
                        .WithMany("Knowledge")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("KnowledgeSystem.DataAccess.Entities.Employee", b =>
                {
                    b.Navigation("Knowledge");
                });
#pragma warning restore 612, 618
        }
    }
}

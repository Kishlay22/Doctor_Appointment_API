﻿// <auto-generated />
using System;
using Appointment_Management.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Appointment_Management.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    [Migration("20240215090707_Updated Constraint")]
    partial class UpdatedConstraint
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Appointment_Management.Data.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorEmpID")
                        .HasColumnType("int");

                    b.Property<string>("Issue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("consumerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorEmpID");

                    b.HasIndex("consumerId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Appointment_Management.Data.Models.Consumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Consumer");
                });

            modelBuilder.Entity("Appointment_Management.Data.Models.Doctor", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Appointment_Management.Data.Models.Appointment", b =>
                {
                    b.HasOne("Appointment_Management.Data.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorEmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Appointment_Management.Data.Models.Consumer", "consumer")
                        .WithMany()
                        .HasForeignKey("consumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("consumer");
                });
#pragma warning restore 612, 618
        }
    }
}

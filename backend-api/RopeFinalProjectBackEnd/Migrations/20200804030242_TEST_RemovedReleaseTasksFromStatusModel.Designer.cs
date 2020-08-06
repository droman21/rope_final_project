﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RopeFinalProjectBackEnd.Contexts;

namespace RopeFinalProjectBackEnd.Migrations
{
    [DbContext(typeof(ReleaseTasksAPIContext))]
    [Migration("20200804030242_TEST_RemovedReleaseTasksFromStatusModel")]
    partial class TEST_RemovedReleaseTasksFromStatusModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<int>("ReleaseTaskID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReleaseTaskID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Dakota",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Bernard",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Dan",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Ron",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Robert",
                            Role = "Release Manager"
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Priority", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Priorities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Critical",
                            Value = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "High",
                            Value = 2
                        },
                        new
                        {
                            ID = 3,
                            Name = "Medium",
                            Value = 3
                        },
                        new
                        {
                            ID = 4,
                            Name = "Low",
                            Value = 4
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.ReleaseTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignedEmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CurrentDueTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentPriorityID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentStatusID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisisble")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AssignedEmployeeID");

                    b.HasIndex("CurrentPriorityID");

                    b.HasIndex("CurrentStatusID");

                    b.ToTable("ReleaseTasks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AssignedEmployeeID = 1,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 212, DateTimeKind.Local).AddTicks(9246),
                            CurrentDueTime = new DateTime(2020, 8, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 1,
                            CurrentStatusID = 1,
                            Description = "Validate Team Ready for Out of Service Page",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(5619),
                            Name = "Validate Readiness"
                        },
                        new
                        {
                            ID = 2,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6312),
                            CurrentDueTime = new DateTime(2020, 8, 19, 20, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 2,
                            Description = "Update Message To Reflect Routine Maintenance",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6346),
                            Name = "Update User Message"
                        },
                        new
                        {
                            ID = 3,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6376),
                            CurrentDueTime = new DateTime(2020, 8, 19, 20, 35, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 3,
                            Description = "Publish Content Updates/Changes, See Content Updates",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6380),
                            Name = "Push Content Changes"
                        },
                        new
                        {
                            ID = 4,
                            AssignedEmployeeID = 4,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6393),
                            CurrentDueTime = new DateTime(2020, 8, 19, 21, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 4,
                            Description = "Execute App Container Changes/Updates in Production, See App Container Tasks",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6397),
                            Name = "Execute App Changes"
                        },
                        new
                        {
                            ID = 5,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6410),
                            CurrentDueTime = new DateTime(2020, 8, 19, 22, 45, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 2,
                            Description = "Deploy New U/I Layer Package, See U / I Layer Code",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6410),
                            Name = "Deploy New UI"
                        },
                        new
                        {
                            ID = 6,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6423),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 3,
                            Description = "Deploy Shared U/I Layer Package  See U / I Layer Code",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6427),
                            Name = "Deploy Shared UI"
                        },
                        new
                        {
                            ID = 7,
                            AssignedEmployeeID = 1,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6436),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 1,
                            Description = "Deploy New Services Layer Package, See Services Layer Code",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6440),
                            Name = "Deploy New Services"
                        },
                        new
                        {
                            ID = 8,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6449),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 55, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 3,
                            Description = "Perform System Cache Refresh",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6453),
                            Name = "Perform Refresh"
                        },
                        new
                        {
                            ID = 9,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6462),
                            CurrentDueTime = new DateTime(2020, 8, 20, 0, 1, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 2,
                            Description = "Bring Down Out of Service Page",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6466),
                            Name = "Remove Service Page"
                        },
                        new
                        {
                            ID = 10,
                            AssignedEmployeeID = 4,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6474),
                            CurrentDueTime = new DateTime(2020, 8, 21, 1, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 3,
                            Description = "Update Message To Reflect Issues In The Event An Unplanned Outage Occurs",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6479),
                            Name = "Update User Message"
                        },
                        new
                        {
                            ID = 11,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6487),
                            CurrentDueTime = new DateTime(2020, 8, 20, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 1,
                            Description = "Notify Group Validation Can Begin",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6492),
                            Name = "Notify Validation Group"
                        },
                        new
                        {
                            ID = 12,
                            AssignedEmployeeID = 5,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6500),
                            CurrentDueTime = new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 3,
                            Description = "System Monitoring Through Monday",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6504),
                            Name = "Monitor System"
                        },
                        new
                        {
                            ID = 13,
                            AssignedEmployeeID = 5,
                            CreatedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6513),
                            CurrentDueTime = new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 1,
                            Description = "Enure no steps were missed",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6517),
                            Name = "Complete Final Checklist"
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Status", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "New",
                            Value = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "In Progress",
                            Value = 2
                        },
                        new
                        {
                            ID = 3,
                            Name = "Done",
                            Value = 3
                        },
                        new
                        {
                            ID = 4,
                            Name = "Cancelled",
                            Value = 4
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Comment", b =>
                {
                    b.HasOne("RopeFinalProjectBackEnd.Models.ReleaseTask", "ReleaseTask")
                        .WithMany("Comments")
                        .HasForeignKey("ReleaseTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.ReleaseTask", b =>
                {
                    b.HasOne("RopeFinalProjectBackEnd.Models.Employee", "Employee")
                        .WithMany("ReleaseTasks")
                        .HasForeignKey("AssignedEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeFinalProjectBackEnd.Models.Priority", "Priority")
                        .WithMany("ReleaseTasks")
                        .HasForeignKey("CurrentPriorityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeFinalProjectBackEnd.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("CurrentStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
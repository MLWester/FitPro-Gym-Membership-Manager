﻿// <auto-generated />
using System;
using FitProGymManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitPro_Gym_Membership_Manager.Migrations
{
    [DbContext(typeof(FitProDbContext))]
    [Migration("20241124170037_UpdateSeedData")]
    partial class UpdateSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("FitProGymManager.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("MembershipPlanID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MemberID");

                    b.HasIndex("MembershipPlanID");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberID = 1,
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            JoinDate = new DateTime(2019, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Doe",
                            MembershipPlanID = 1,
                            PhoneNumber = "123-456-7890"
                        },
                        new
                        {
                            MemberID = 2,
                            DateOfBirth = new DateTime(1992, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            JoinDate = new DateTime(2013, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            MembershipPlanID = 2,
                            PhoneNumber = "123-555-6789"
                        },
                        new
                        {
                            MemberID = 3,
                            DateOfBirth = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michael.brown@example.com",
                            FirstName = "Michael",
                            JoinDate = new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Brown",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            MemberID = 4,
                            DateOfBirth = new DateTime(1993, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarah.davis@example.com",
                            FirstName = "Sarah",
                            JoinDate = new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Davis",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-987-6543"
                        },
                        new
                        {
                            MemberID = 5,
                            DateOfBirth = new DateTime(1990, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "chris.martinez@example.com",
                            FirstName = "Chris",
                            JoinDate = new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Martinez",
                            MembershipPlanID = 3,
                            PhoneNumber = "555-555-1212"
                        },
                        new
                        {
                            MemberID = 6,
                            DateOfBirth = new DateTime(1988, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jessica.taylor@example.com",
                            FirstName = "Jessica",
                            JoinDate = new DateTime(2017, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Taylor",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-666-7788"
                        },
                        new
                        {
                            MemberID = 7,
                            DateOfBirth = new DateTime(1995, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "daniel.anderson@example.com",
                            FirstName = "Daniel",
                            JoinDate = new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Anderson",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-444-2323"
                        },
                        new
                        {
                            MemberID = 8,
                            DateOfBirth = new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emily.moore@example.com",
                            FirstName = "Emily",
                            JoinDate = new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Moore",
                            MembershipPlanID = 3,
                            PhoneNumber = "555-888-9999"
                        },
                        new
                        {
                            MemberID = 9,
                            DateOfBirth = new DateTime(1992, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "david.jackson@example.com",
                            FirstName = "David",
                            JoinDate = new DateTime(2016, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Jackson",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-321-6547"
                        },
                        new
                        {
                            MemberID = 10,
                            DateOfBirth = new DateTime(1991, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sophia.white@example.com",
                            FirstName = "Sophia",
                            JoinDate = new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "White",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-777-3333"
                        },
                        new
                        {
                            MemberID = 11,
                            DateOfBirth = new DateTime(1987, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "james.harris@example.com",
                            FirstName = "James",
                            JoinDate = new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Harris",
                            MembershipPlanID = 3,
                            PhoneNumber = "555-123-7890"
                        },
                        new
                        {
                            MemberID = 12,
                            DateOfBirth = new DateTime(1996, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "olivia.martin@example.com",
                            FirstName = "Olivia",
                            JoinDate = new DateTime(2018, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Martin",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-456-7890"
                        },
                        new
                        {
                            MemberID = 13,
                            DateOfBirth = new DateTime(1986, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "william.thompson@example.com",
                            FirstName = "William",
                            JoinDate = new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Thompson",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-222-4567"
                        },
                        new
                        {
                            MemberID = 14,
                            DateOfBirth = new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ava.garcia@example.com",
                            FirstName = "Ava",
                            JoinDate = new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Garcia",
                            MembershipPlanID = 3,
                            PhoneNumber = "555-789-1234"
                        },
                        new
                        {
                            MemberID = 15,
                            DateOfBirth = new DateTime(1989, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "joseph.martinez@example.com",
                            FirstName = "Joseph",
                            JoinDate = new DateTime(2016, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Martinez",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-654-3210"
                        },
                        new
                        {
                            MemberID = 16,
                            DateOfBirth = new DateTime(1993, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mia.rodriguez@example.com",
                            FirstName = "Mia",
                            JoinDate = new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Rodriguez",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-789-9876"
                        },
                        new
                        {
                            MemberID = 17,
                            DateOfBirth = new DateTime(1990, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "noah.wilson@example.com",
                            FirstName = "Noah",
                            JoinDate = new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Wilson",
                            MembershipPlanID = 3,
                            PhoneNumber = "555-333-4444"
                        },
                        new
                        {
                            MemberID = 18,
                            DateOfBirth = new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "liam.lopez@example.com",
                            FirstName = "Liam",
                            JoinDate = new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Lopez",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-555-6666"
                        },
                        new
                        {
                            MemberID = 19,
                            DateOfBirth = new DateTime(1998, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "isabella.clark@example.com",
                            FirstName = "Isabella",
                            JoinDate = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Clark",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-444-5555"
                        },
                        new
                        {
                            MemberID = 20,
                            DateOfBirth = new DateTime(1988, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ethan.hill@example.com",
                            FirstName = "Ethan",
                            JoinDate = new DateTime(2018, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Hill",
                            MembershipPlanID = 3,
                            PhoneNumber = "555-666-7777"
                        },
                        new
                        {
                            MemberID = 21,
                            DateOfBirth = new DateTime(1995, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emma.scott@example.com",
                            FirstName = "Emma",
                            JoinDate = new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Scott",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-888-1111"
                        },
                        new
                        {
                            MemberID = 22,
                            DateOfBirth = new DateTime(1994, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lucas.adams@example.com",
                            FirstName = "Lucas",
                            JoinDate = new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Adams",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-999-1111"
                        },
                        new
                        {
                            MemberID = 23,
                            DateOfBirth = new DateTime(1992, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "charlotte.baker@example.com",
                            FirstName = "Charlotte",
                            JoinDate = new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Baker",
                            MembershipPlanID = 3,
                            PhoneNumber = "555-111-2222"
                        },
                        new
                        {
                            MemberID = 24,
                            DateOfBirth = new DateTime(1991, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "benjamin.hernandez@example.com",
                            FirstName = "Benjamin",
                            JoinDate = new DateTime(2018, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Hernandez",
                            MembershipPlanID = 1,
                            PhoneNumber = "555-222-3333"
                        },
                        new
                        {
                            MemberID = 25,
                            DateOfBirth = new DateTime(1996, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "grace.king@example.com",
                            FirstName = "Grace",
                            JoinDate = new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "King",
                            MembershipPlanID = 2,
                            PhoneNumber = "555-444-6666"
                        });
                });

            modelBuilder.Entity("FitProGymManager.Models.MembershipPlan", b =>
                {
                    b.Property<int>("MembershipPlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DurationInMonths")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxMembers")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MonthlyFee")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlanName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("MembershipPlanID");

                    b.HasIndex("PlanName")
                        .IsUnique();

                    b.ToTable("MembershipPlans");

                    b.HasData(
                        new
                        {
                            MembershipPlanID = 1,
                            DurationInMonths = 1,
                            MaxMembers = 100,
                            MonthlyFee = 19.99m,
                            PlanName = "Basic"
                        },
                        new
                        {
                            MembershipPlanID = 2,
                            DurationInMonths = 6,
                            MaxMembers = 50,
                            MonthlyFee = 39.99m,
                            PlanName = "Premium"
                        },
                        new
                        {
                            MembershipPlanID = 3,
                            DurationInMonths = 12,
                            MaxMembers = 25,
                            MonthlyFee = 59.99m,
                            PlanName = "Elite"
                        });
                });

            modelBuilder.Entity("FitProGymManager.Models.Member", b =>
                {
                    b.HasOne("FitProGymManager.Models.MembershipPlan", "MembershipPlan")
                        .WithMany()
                        .HasForeignKey("MembershipPlanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipPlan");
                });
#pragma warning restore 612, 618
        }
    }
}
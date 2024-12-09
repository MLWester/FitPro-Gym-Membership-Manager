using FitProGymManager.Models;
using Microsoft.EntityFrameworkCore;

namespace FitProGymManager.Models
{
    public static class SeedData
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            // Seed MembershipPlan data
            modelBuilder.Entity<MembershipPlan>().HasData(
                new MembershipPlan
                {
                    MembershipPlanID = 1,
                    PlanName = "Basic",
                    MonthlyFee = 19.99m,
                    DurationInMonths = 1,
                    MaxMembers = 100
                },
                new MembershipPlan
                {
                    MembershipPlanID = 2,
                    PlanName = "Premium",
                    MonthlyFee = 39.99m,
                    DurationInMonths = 6,
                    MaxMembers = 50
                },
                new MembershipPlan
                {
                    MembershipPlanID = 3,
                    PlanName = "Elite",
                    MonthlyFee = 59.99m,
                    DurationInMonths = 12,
                    MaxMembers = 25
                }
            );

            // Seed Member data
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    JoinDate = new DateTime(2019, 7, 13),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "123-555-6789",
                    DateOfBirth = new DateTime(1992, 6, 15),
                    JoinDate = new DateTime(2013, 3, 10),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 3,
                    FirstName = "Michael",
                    LastName = "Brown",
                    Email = "michael.brown@example.com",
                    PhoneNumber = "555-123-4567",
                    DateOfBirth = new DateTime(1985, 5, 15),
                    JoinDate = new DateTime(2019, 4, 10),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 4,
                    FirstName = "Sarah",
                    LastName = "Davis",
                    Email = "sarah.davis@example.com",
                    PhoneNumber = "555-987-6543",
                    DateOfBirth = new DateTime(1993, 7, 20),
                    JoinDate = new DateTime(2018, 9, 15),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 5,
                    FirstName = "Chris",
                    LastName = "Martinez",
                    Email = "chris.martinez@example.com",
                    PhoneNumber = "555-555-1212",
                    DateOfBirth = new DateTime(1990, 11, 10),
                    JoinDate = new DateTime(2020, 3, 5),
                    MembershipPlanID = 3
                },
                new Member
                {
                    MemberID = 6,
                    FirstName = "Jessica",
                    LastName = "Taylor",
                    Email = "jessica.taylor@example.com",
                    PhoneNumber = "555-666-7788",
                    DateOfBirth = new DateTime(1988, 3, 5),
                    JoinDate = new DateTime(2017, 7, 22),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 7,
                    FirstName = "Daniel",
                    LastName = "Anderson",
                    Email = "daniel.anderson@example.com",
                    PhoneNumber = "555-444-2323",
                    DateOfBirth = new DateTime(1995, 6, 25),
                    JoinDate = new DateTime(2021, 1, 15),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 8,
                    FirstName = "Emily",
                    LastName = "Moore",
                    Email = "emily.moore@example.com",
                    PhoneNumber = "555-888-9999",
                    DateOfBirth = new DateTime(1994, 8, 14),
                    JoinDate = new DateTime(2022, 11, 12),
                    MembershipPlanID = 3
                },
                new Member
                {
                    MemberID = 9,
                    FirstName = "David",
                    LastName = "Jackson",
                    Email = "david.jackson@example.com",
                    PhoneNumber = "555-321-6547",
                    DateOfBirth = new DateTime(1992, 4, 18),
                    JoinDate = new DateTime(2016, 2, 28),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 10,
                    FirstName = "Sophia",
                    LastName = "White",
                    Email = "sophia.white@example.com",
                    PhoneNumber = "555-777-3333",
                    DateOfBirth = new DateTime(1991, 9, 12),
                    JoinDate = new DateTime(2020, 6, 10),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 11,
                    FirstName = "James",
                    LastName = "Harris",
                    Email = "james.harris@example.com",
                    PhoneNumber = "555-123-7890",
                    DateOfBirth = new DateTime(1987, 2, 1),
                    JoinDate = new DateTime(2019, 10, 25),
                    MembershipPlanID = 3
                },
                new Member
                {
                    MemberID = 12,
                    FirstName = "Olivia",
                    LastName = "Martin",
                    Email = "olivia.martin@example.com",
                    PhoneNumber = "555-456-7890",
                    DateOfBirth = new DateTime(1996, 10, 8),
                    JoinDate = new DateTime(2018, 8, 19),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 13,
                    FirstName = "William",
                    LastName = "Thompson",
                    Email = "william.thompson@example.com",
                    PhoneNumber = "555-222-4567",
                    DateOfBirth = new DateTime(1986, 7, 22),
                    JoinDate = new DateTime(2017, 12, 1),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 14,
                    FirstName = "Ava",
                    LastName = "Garcia",
                    Email = "ava.garcia@example.com",
                    PhoneNumber = "555-789-1234",
                    DateOfBirth = new DateTime(1997, 11, 30),
                    JoinDate = new DateTime(2021, 4, 15),
                    MembershipPlanID = 3
                },
                new Member
                {
                    MemberID = 15,
                    FirstName = "Joseph",
                    LastName = "Martinez",
                    Email = "joseph.martinez@example.com",
                    PhoneNumber = "555-654-3210",
                    DateOfBirth = new DateTime(1989, 5, 19),
                    JoinDate = new DateTime(2016, 9, 9),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 16,
                    FirstName = "Mia",
                    LastName = "Rodriguez",
                    Email = "mia.rodriguez@example.com",
                    PhoneNumber = "555-789-9876",
                    DateOfBirth = new DateTime(1993, 12, 11),
                    JoinDate = new DateTime(2019, 2, 7),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 17,
                    FirstName = "Noah",
                    LastName = "Wilson",
                    Email = "noah.wilson@example.com",
                    PhoneNumber = "555-333-4444",
                    DateOfBirth = new DateTime(1990, 6, 6),
                    JoinDate = new DateTime(2020, 5, 5),
                    MembershipPlanID = 3
                },
                new Member
                {
                    MemberID = 18,
                    FirstName = "Liam",
                    LastName = "Lopez",
                    Email = "liam.lopez@example.com",
                    PhoneNumber = "555-555-6666",
                    DateOfBirth = new DateTime(1985, 3, 3),
                    JoinDate = new DateTime(2015, 1, 10),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 19,
                    FirstName = "Isabella",
                    LastName = "Clark",
                    Email = "isabella.clark@example.com",
                    PhoneNumber = "555-444-5555",
                    DateOfBirth = new DateTime(1998, 1, 2),
                    JoinDate = new DateTime(2022, 3, 15),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 20,
                    FirstName = "Ethan",
                    LastName = "Hill",
                    Email = "ethan.hill@example.com",
                    PhoneNumber = "555-666-7777",
                    DateOfBirth = new DateTime(1988, 7, 9),
                    JoinDate = new DateTime(2018, 6, 30),
                    MembershipPlanID = 3
                },
                new Member
                {
                    MemberID = 21,
                    FirstName = "Emma",
                    LastName = "Scott",
                    Email = "emma.scott@example.com",
                    PhoneNumber = "555-888-1111",
                    DateOfBirth = new DateTime(1995, 8, 4),
                    JoinDate = new DateTime(2020, 9, 11),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 22,
                    FirstName = "Lucas",
                    LastName = "Adams",
                    Email = "lucas.adams@example.com",
                    PhoneNumber = "555-999-1111",
                    DateOfBirth = new DateTime(1994, 4, 15),
                    JoinDate = new DateTime(2017, 5, 20),
                    MembershipPlanID = 2
                },
                new Member
                {
                    MemberID = 23,
                    FirstName = "Charlotte",
                    LastName = "Baker",
                    Email = "charlotte.baker@example.com",
                    PhoneNumber = "555-111-2222",
                    DateOfBirth = new DateTime(1992, 2, 10),
                    JoinDate = new DateTime(2019, 8, 29),
                    MembershipPlanID = 3
                },
                new Member
                {
                    MemberID = 24,
                    FirstName = "Benjamin",
                    LastName = "Hernandez",
                    Email = "benjamin.hernandez@example.com",
                    PhoneNumber = "555-222-3333",
                    DateOfBirth = new DateTime(1991, 9, 19),
                    JoinDate = new DateTime(2018, 7, 8),
                    MembershipPlanID = 1
                },
                new Member
                {
                    MemberID = 25,
                    FirstName = "Grace",
                    LastName = "King",
                    Email = "grace.king@example.com",
                    PhoneNumber = "555-444-6666",
                    DateOfBirth = new DateTime(1996, 10, 20),
                    JoinDate = new DateTime(2021, 11, 13),
                    MembershipPlanID = 2
                }
            );
        }
    }
}


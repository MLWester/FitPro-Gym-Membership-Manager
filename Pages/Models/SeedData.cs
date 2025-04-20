using FitProGymManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FitProGymManager.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FitProDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<FitProDbContext>>()))
            {
                if (context.MembershipPlans.Any())
                {
                    return; // DB has been seeded
                }

                var plans = new MembershipPlan[]
                {
                    new MembershipPlan 
                    { 
                        PlanName = "Basic", 
                        MonthlyFee = 29.99m, 
                        DurationInMonths = 1,
                        MaxMembers = 100
                    },
                    new MembershipPlan 
                    { 
                        PlanName = "Premium", 
                        MonthlyFee = 49.99m, 
                        DurationInMonths = 1,
                        MaxMembers = 50
                    },
                    new MembershipPlan 
                    { 
                        PlanName = "VIP", 
                        MonthlyFee = 99.99m, 
                        DurationInMonths = 1,
                        MaxMembers = 25
                    }
                };

                context.MembershipPlans.AddRange(plans);
                context.SaveChanges();

                var members = new Member[]
                {
                    new Member
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "john@example.com",
                        PhoneNumber = "1234567890",
                        DateOfBirth = new DateTime(1990, 1, 1),
                        JoinDate = DateTime.Now,
                        MembershipPlanID = plans[0].MembershipPlanID
                    },
                    new Member
                    {
                        FirstName = "Jane",
                        LastName = "Smith",
                        Email = "jane@example.com",
                        PhoneNumber = "0987654321",
                        DateOfBirth = new DateTime(1992, 2, 2),
                        JoinDate = DateTime.Now,
                        MembershipPlanID = plans[1].MembershipPlanID
                    },
                    new Member
                    {
                        FirstName = "Bob",
                        LastName = "Johnson",
                        Email = "bob@example.com",
                        PhoneNumber = "5551234567",
                        DateOfBirth = new DateTime(1988, 3, 3),
                        JoinDate = DateTime.Now,
                        MembershipPlanID = plans[2].MembershipPlanID
                    }
                };

                context.Members.AddRange(members);
                context.SaveChanges();
            }
        }
    }
}


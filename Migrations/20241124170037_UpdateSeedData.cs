using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitPro_Gym_Membership_Manager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberID", "DateOfBirth", "Email", "FirstName", "JoinDate", "LastName", "MembershipPlanID", "PhoneNumber" },
                values: new object[,]
                {
                    { 13, new DateTime(1986, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "william.thompson@example.com", "William", new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thompson", 2, "555-222-4567" },
                    { 14, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.garcia@example.com", "Ava", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garcia", 3, "555-789-1234" },
                    { 15, new DateTime(1989, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "joseph.martinez@example.com", "Joseph", new DateTime(2016, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", 1, "555-654-3210" },
                    { 16, new DateTime(1993, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "mia.rodriguez@example.com", "Mia", new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodriguez", 2, "555-789-9876" },
                    { 17, new DateTime(1990, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.wilson@example.com", "Noah", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", 3, "555-333-4444" },
                    { 18, new DateTime(1985, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "liam.lopez@example.com", "Liam", new DateTime(2015, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lopez", 1, "555-555-6666" },
                    { 19, new DateTime(1998, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabella.clark@example.com", "Isabella", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark", 2, "555-444-5555" },
                    { 20, new DateTime(1988, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ethan.hill@example.com", "Ethan", new DateTime(2018, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hill", 3, "555-666-7777" },
                    { 21, new DateTime(1995, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.scott@example.com", "Emma", new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott", 1, "555-888-1111" },
                    { 22, new DateTime(1994, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucas.adams@example.com", "Lucas", new DateTime(2017, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adams", 2, "555-999-1111" },
                    { 23, new DateTime(1992, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlotte.baker@example.com", "Charlotte", new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baker", 3, "555-111-2222" },
                    { 24, new DateTime(1991, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "benjamin.hernandez@example.com", "Benjamin", new DateTime(2018, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hernandez", 1, "555-222-3333" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: 24);
        }
    }
}

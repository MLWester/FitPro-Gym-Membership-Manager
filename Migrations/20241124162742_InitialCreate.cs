using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitPro_Gym_Membership_Manager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MembershipPlans",
                columns: table => new
                {
                    MembershipPlanID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlanName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MonthlyFee = table.Column<decimal>(type: "TEXT", nullable: false),
                    DurationInMonths = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxMembers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipPlans", x => x.MembershipPlanID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MembershipPlanID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_Members_MembershipPlans_MembershipPlanID",
                        column: x => x.MembershipPlanID,
                        principalTable: "MembershipPlans",
                        principalColumn: "MembershipPlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MembershipPlans",
                columns: new[] { "MembershipPlanID", "DurationInMonths", "MaxMembers", "MonthlyFee", "PlanName" },
                values: new object[,]
                {
                    { 1, 1, 100, 19.99m, "Basic" },
                    { 2, 6, 50, 39.99m, "Premium" },
                    { 3, 12, 25, 59.99m, "Elite" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberID", "DateOfBirth", "Email", "FirstName", "JoinDate", "LastName", "MembershipPlanID", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", new DateTime(2019, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doe", 1, "123-456-7890" },
                    { 2, new DateTime(1992, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", new DateTime(2013, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smith", 2, "123-555-6789" },
                    { 3, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@example.com", "Michael", new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", 1, "555-123-4567" },
                    { 4, new DateTime(1993, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.davis@example.com", "Sarah", new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davis", 2, "555-987-6543" },
                    { 5, new DateTime(1990, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "chris.martinez@example.com", "Chris", new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martinez", 3, "555-555-1212" },
                    { 6, new DateTime(1988, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jessica.taylor@example.com", "Jessica", new DateTime(2017, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor", 1, "555-666-7788" },
                    { 7, new DateTime(1995, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.anderson@example.com", "Daniel", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderson", 2, "555-444-2323" },
                    { 8, new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.moore@example.com", "Emily", new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moore", 3, "555-888-9999" },
                    { 9, new DateTime(1992, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.jackson@example.com", "David", new DateTime(2016, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson", 1, "555-321-6547" },
                    { 10, new DateTime(1991, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia.white@example.com", "Sophia", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "White", 2, "555-777-3333" },
                    { 11, new DateTime(1987, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.harris@example.com", "James", new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris", 3, "555-123-7890" },
                    { 12, new DateTime(1996, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.martin@example.com", "Olivia", new DateTime(2018, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", 1, "555-456-7890" },
                    { 25, new DateTime(1996, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.king@example.com", "Grace", new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "King", 2, "555-444-6666" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipPlanID",
                table: "Members",
                column: "MembershipPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_MembershipPlans_PlanName",
                table: "MembershipPlans",
                column: "PlanName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "MembershipPlans");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectManagement_Api.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KanbanCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assignee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanbanCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainProjects",
                columns: table => new
                {
                    MainProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainProjects", x => x.MainProjectId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectResources",
                columns: table => new
                {
                    ProjectResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<double>(type: "float", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectResources", x => x.ProjectResourceId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ResourceId);
                });

            migrationBuilder.InsertData(
                table: "KanbanCards",
                columns: new[] { "Id", "Assignee", "ProjectId", "Status", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "Nancy Davloio", null, "Open", "Analyze the new requirements gathered from the customer.", "BLAZ-29001" },
                    { 2, "Andrew Fuller", null, "InProgress", "Improve application performance", "BLAZ-29002" },
                    { 3, "Janet Leverling", null, "Open", "Arrange a web meeting with the customer to get new requirements.", "BLAZ-29003" },
                    { 4, "Janet Leverling", null, "InProgress", "Fix the issues reported in the IE browser.", "BLAZ-29004" },
                    { 5, "Steven walker", null, "Review", "Fix the issues reported by the customer.", "BLAZ-29005" },
                    { 6, "Nancy Davloio", null, "Review", "Fix the issues reported in Safari browser.", "BLAZ-29006" },
                    { 7, "Margaret hamilt", null, "Close", "Test the application in the IE browser.", "BLAZ-29007" },
                    { 8, "Steven walker", null, "Validate", "Validate the issues reported by the customer.", "BLAZ-29008" },
                    { 9, "Margaret hamilt", null, "Open", "Show the retrieved data from the server in grid control.", "BLAZ-29009" },
                    { 10, "Janet Leverling", null, "InProgress", "Fix cannot open user’s default database SQL error.", "BLAZ-29010" },
                    { 11, "Janet Leverling", null, "Review", "Fix the issues reported in data binding.", "BLAZ-29011" },
                    { 12, "Andrew Fuller", null, "Close", "Analyze SQL server 2008 connection.", "BLAZ-29012" },
                    { 13, "Margaret hamilt", null, "Validate", "Validate databinding issues.", "BLAZ-29013" },
                    { 14, "Margaret hamilt", null, "Close", "Analyze grid control.", "BLAZ-29014" },
                    { 15, "Steven walker", null, "Close", "Stored procedure for initial data binding of the grid.", "BLAZ-29015" },
                    { 16, "Janet Leverling", null, "Close", "Analyze stored procedures.", "BLAZ-29016" },
                    { 17, "Nancy Davloio", null, "Validate", "Validate editing issues.", "BLAZ-29017" },
                    { 18, "Nancy Davloio", null, "Review", "Test editing functionality.", "BLAZ-29018" },
                    { 19, "Andrew Fuller", null, "Open", "Enhance editing functionality.", "BLAZ-29019" },
                    { 20, "Nancy Davloio", null, "InProgress", "Improve the performance of the editing functionality.", "BLAZ-29020" },
                    { 21, "Steven walker", null, "Open", "Arrange web meeting with the customer to show editing demo.", "BLAZ-29021" },
                    { 22, "Janet Leverling", null, "Review", "Fix the editing issues reported by the customer.", "BLAZ-29022" },
                    { 23, "Steven walker", null, "Testing", "Fix the issues reported by the customer.", "BLAZ-29023" },
                    { 24, "Nancy Davloio", null, "Testing", "Fix the issues reported in Safari browser.", "BLAZ-29024" },
                    { 25, "Janet Leverling", null, "Testing", "Fix the issues reported in data binding.", "BLAZ-29025" },
                    { 26, "Nancy Davloio", null, "Testing", "Test editing functionality.", "BLAZ-29026" },
                    { 27, "Janet Leverling", null, "Testing", "Test editing feature in the IE browser.", "BLAZ-29027" }
                });

            migrationBuilder.InsertData(
                table: "ProjectResources",
                columns: new[] { "ProjectResourceId", "Group", "ProjectId", "ResourceId", "Unit" },
                values: new object[,]
                {
                    { 1, null, 2, 1, 70.0 },
                    { 2, null, 2, 6, null },
                    { 3, null, 3, 2, null },
                    { 4, null, 3, 3, null },
                    { 5, null, 4, 8, null },
                    { 6, "Rose Fuller", 4, 9, null },
                    { 7, null, 6, 4, null },
                    { 8, null, 7, 4, null },
                    { 9, null, 7, 8, null },
                    { 10, null, 8, 12, null },
                    { 11, null, 8, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Duration", "EndDate", "ParentId", "Progress", "StartDate", "TaskName" },
                values: new object[,]
                {
                    { 1, "5days", new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product concept " },
                    { 2, "3", new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 30, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Define the product usage" },
                    { 3, null, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 40, null, "Define the target audience" },
                    { 4, "2", null, 1, 30, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prepare product sketch and notes" },
                    { 5, "0", new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concept approval" },
                    { 6, "4", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Market research" },
                    { 7, "4", null, 6, 40, null, "Demand analysis" },
                    { 8, "4", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 30, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer strength" },
                    { 9, "4", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Market opportunity analysis" },
                    { 10, "4", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 30, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Competitor analysis" },
                    { 11, "4", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 40, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product strength analysis" },
                    { 12, "0", new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 30, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Research completed" },
                    { 13, "20", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product design and development" },
                    { 14, "3", new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 30, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Functionality design" },
                    { 15, "3", new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 40, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality design" },
                    { 16, "2", new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 30, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Define reliability" },
                    { 17, "2", new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identifying raw materials" },
                    { 18, "2", new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 30, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Define cost plan" },
                    { 19, "2", new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 40, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estimate manufacturing cost" },
                    { 20, "2", new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 30, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estimate selling cost" },
                    { 21, "7", new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Development of final design" },
                    { 22, "2", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 30, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop dimensions and design" },
                    { 23, "2", new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 40, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop designs to meet industry" },
                    { 24, "3", new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 30, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Include all the details" },
                    { 25, "3", new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "CAD - Computer Aided Design" },
                    { 26, "3", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CAM - Computer Aided Manufacturing" },
                    { 27, "0", new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finalize the design" },
                    { 28, "4", new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prototype testing" },
                    { 29, "4", new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Include feedback" },
                    { 30, "5", new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manufacturing" },
                    { 31, "5", new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assembling material into finished goods" },
                    { 32, "6", new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final product development" },
                    { 33, "3", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 0, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Important improvement" },
                    { 34, "3", new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 30, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer testing and feedback" },
                    { 35, "4", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final product development" },
                    { 36, "4", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 30, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Important improvement" },
                    { 37, "4", new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 30, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Address any unforeseen issues" },
                    { 38, "8", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finalize the product " },
                    { 39, "4", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 30, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Branding the product" },
                    { 40, "4", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 0, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing and presales" }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "FirstName", "FullName", "LastName" },
                values: new object[,]
                {
                    { 1, "Martin", "Martin Tamer", "Tamer" },
                    { 2, "Rose", "Rose Fuller", "Fuller" },
                    { 3, "Margaret", "Margaret Buchanan", "Bunchanan" },
                    { 4, "Fuller", "Fuller King", "King" },
                    { 5, "Davolio", "Davolio Fuller", "Fuller" },
                    { 6, "Fuller", "Fuller Buchanan", "Bunchanan" },
                    { 7, "Jack", "Jack Davolio", "Davolio" },
                    { 8, "Tamer", "Tamer Vinet", "Vinet" },
                    { 9, "Vinnet", "Vinet Fuller", "Fuller" },
                    { 10, "Bergs", "Bergs Anton", "Anton" },
                    { 11, "Construction", "Construction Supervisor", "Supervisior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KanbanCards");

            migrationBuilder.DropTable(
                name: "MainProjects");

            migrationBuilder.DropTable(
                name: "ProjectResources");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}

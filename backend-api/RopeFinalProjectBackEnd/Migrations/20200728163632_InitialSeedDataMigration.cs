using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class InitialSeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseTasks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CurrentStatusID = table.Column<int>(nullable: false),
                    CurrentPriorityID = table.Column<int>(nullable: false),
                    CurrentDueTime = table.Column<DateTime>(nullable: false),
                    IsVisisble = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: false),
                    AssignedEmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseTasks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Name", "Role" },
                values: new object[,]
                {
                    { 1, "Dakota", "Developer" },
                    { 2, "Bernard", "Developer" },
                    { 3, "Dan", "Developer" },
                    { 4, "Ron", "Developer" },
                    { 5, "Robert", "Release Manager" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "ID", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "Medium", 3 },
                    { 4, "Low", 4 },
                    { 1, "Critical", 1 },
                    { 2, "High", 2 }
                });

            migrationBuilder.InsertData(
                table: "ReleaseTasks",
                columns: new[] { "ID", "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "IsVisisble", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 7, 28, 12, 36, 32, 235, DateTimeKind.Local).AddTicks(2077), new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", true, new DateTime(2020, 7, 28, 12, 36, 32, 237, DateTimeKind.Local).AddTicks(9956), "Release Task 1" },
                    { 2, 2, new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(725), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", true, new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(755), "Release Task 2" },
                    { 3, 3, new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(785), new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", true, new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(794), "Release Task 3" },
                    { 4, 4, new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(807), new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", true, new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(811), "Release Task 4" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "ID", "Name", "Value" },
                values: new object[,]
                {
                    { 3, "Done", 3 },
                    { 1, "New", 1 },
                    { 2, "In Progress", 2 },
                    { 4, "Cancelled", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "ReleaseTasks");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}

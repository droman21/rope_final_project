using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddedCommentsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(nullable: true),
                    IsVisible = table.Column<bool>(nullable: false),
                    ReleaseTaskID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_ReleaseTasks_ReleaseTaskID",
                        column: x => x.ReleaseTaskID,
                        principalTable: "ReleaseTasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 739, DateTimeKind.Local).AddTicks(4673), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3403), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3557), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3574), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3770), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3783), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3800), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3813), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3826), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3839), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3852), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3864), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.InsertData(
                table: "ReleaseTasks",
                columns: new[] { "ID", "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "IsVisisble", "LastModifiedDate", "Name" },
                values: new object[] { 13, 5, new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3877), new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "Enure no steps were missed", true, new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3877), "Complete Final Checklist" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReleaseTaskID",
                table: "Comments",
                column: "ReleaseTaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 996, DateTimeKind.Local).AddTicks(1964), new DateTime(2020, 7, 31, 13, 27, 15, 998, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(253), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(347), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(458), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(475), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(497), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(522), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(544), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(565), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(586), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(608), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(629), new DateTime(2020, 7, 31, 13, 27, 15, 999, DateTimeKind.Local).AddTicks(634) });
        }
    }
}

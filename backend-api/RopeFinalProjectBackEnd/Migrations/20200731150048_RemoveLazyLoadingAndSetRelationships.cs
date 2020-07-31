using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class RemoveLazyLoadingAndSetRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 610, DateTimeKind.Local).AddTicks(8594), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6375), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6422), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6439), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6448), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6461), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6474), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6482), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6495), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6503), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6516), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6529), new DateTime(2020, 7, 31, 11, 0, 47, 613, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseTasks_AssignedEmployeeID",
                table: "ReleaseTasks",
                column: "AssignedEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseTasks_CurrentPriorityID",
                table: "ReleaseTasks",
                column: "CurrentPriorityID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseTasks_CurrentStatusID",
                table: "ReleaseTasks",
                column: "CurrentStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseTasks_Employees_AssignedEmployeeID",
                table: "ReleaseTasks",
                column: "AssignedEmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseTasks_Priorities_CurrentPriorityID",
                table: "ReleaseTasks",
                column: "CurrentPriorityID",
                principalTable: "Priorities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseTasks_Statuses_CurrentStatusID",
                table: "ReleaseTasks",
                column: "CurrentStatusID",
                principalTable: "Statuses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseTasks_Employees_AssignedEmployeeID",
                table: "ReleaseTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseTasks_Priorities_CurrentPriorityID",
                table: "ReleaseTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseTasks_Statuses_CurrentStatusID",
                table: "ReleaseTasks");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseTasks_AssignedEmployeeID",
                table: "ReleaseTasks");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseTasks_CurrentPriorityID",
                table: "ReleaseTasks");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseTasks_CurrentStatusID",
                table: "ReleaseTasks");

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 904, DateTimeKind.Local).AddTicks(5059), new DateTime(2020, 7, 31, 8, 47, 46, 906, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(264), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(312), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(324), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(337), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(350), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(363), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(371), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(384), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(397), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(410), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(418), new DateTime(2020, 7, 31, 8, 47, 46, 907, DateTimeKind.Local).AddTicks(423) });
        }
    }
}

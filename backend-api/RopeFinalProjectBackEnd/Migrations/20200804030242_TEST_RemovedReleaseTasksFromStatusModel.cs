using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class TEST_RemovedReleaseTasksFromStatusModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 212, DateTimeKind.Local).AddTicks(9246), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6312), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6376), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6393), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6410), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6423), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6436), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6449), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6462), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6474), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6487), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6500), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6513), new DateTime(2020, 8, 3, 23, 2, 42, 215, DateTimeKind.Local).AddTicks(6517) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3877), new DateTime(2020, 7, 31, 13, 47, 24, 742, DateTimeKind.Local).AddTicks(3877) });
        }
    }
}

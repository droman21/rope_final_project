using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class FixedNamingErrorOnStatusTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

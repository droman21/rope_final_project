using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddedForeignKeysToReleaseTasksModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 768, DateTimeKind.Local).AddTicks(4631), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3736), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3813), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3834), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3855), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3872), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3889), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3911), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3932), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3949), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3966), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3984), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3988) });
        }
    }
}

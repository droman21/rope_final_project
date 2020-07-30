using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddedTimesToSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 768, DateTimeKind.Local).AddTicks(4631), new DateTime(2020, 8, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3736), new DateTime(2020, 8, 19, 20, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3813), new DateTime(2020, 8, 19, 20, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3834), new DateTime(2020, 8, 19, 21, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3855), new DateTime(2020, 8, 19, 22, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3872), new DateTime(2020, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3889), new DateTime(2020, 8, 19, 23, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3911), new DateTime(2020, 8, 19, 23, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3932), new DateTime(2020, 8, 20, 0, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3949), new DateTime(2020, 8, 21, 1, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3966), new DateTime(2020, 8, 20, 2, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3984), new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 58, 4, 772, DateTimeKind.Local).AddTicks(3988) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 65, DateTimeKind.Local).AddTicks(5347), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(947), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(994), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1007), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1016), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1029), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1041), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1050), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1063), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1076), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1084), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "CurrentDueTime", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1097), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1097) });
        }
    }
}

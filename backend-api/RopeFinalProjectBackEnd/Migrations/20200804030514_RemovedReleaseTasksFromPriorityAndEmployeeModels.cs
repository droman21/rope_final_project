using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class RemovedReleaseTasksFromPriorityAndEmployeeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 425, DateTimeKind.Local).AddTicks(6673), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5694), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5750), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5767), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5780), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5793), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5805), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5917), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5929), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5938), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5951), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5964), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5976), new DateTime(2020, 8, 3, 23, 5, 14, 428, DateTimeKind.Local).AddTicks(5976) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddCommentsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "Details", "IsVisible", "ReleaseTaskID" },
                values: new object[,]
                {
                    { 1, "Operations Running Smoothly.", true, 1 },
                    { 2, "Having some issues.", true, 1 },
                    { 3, "Runtime errors present", true, 1 },
                    { 4, "No issues.", true, 2 },
                    { 5, "Estimated completion in 30 minutes.", true, 2 },
                    { 6, "Running about 45 minutes behind schedule.", true, 3 },
                    { 7, "Looking good.", true, 3 },
                    { 8, "This might be a show stopper.", true, 4 },
                    { 9, "GO Decision made.", true, 5 },
                    { 10, "Need help.", true, 3 }
                });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 158, DateTimeKind.Local).AddTicks(9541), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1783), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1839), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1852), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1865), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1877), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1890), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1899), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1912), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1924), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1933), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1946), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1959), new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.InsertData(
                table: "ReleaseTasks",
                columns: new[] { "ID", "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "IsVisisble", "LastModifiedDate", "Name" },
                values: new object[] { 14, 5, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1967), new DateTime(2020, 8, 20, 8, 30, 0, 0, DateTimeKind.Unspecified), 3, 1, "Let users know system has been updated.", true, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1971), "Notify Users" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14);

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
    }
}

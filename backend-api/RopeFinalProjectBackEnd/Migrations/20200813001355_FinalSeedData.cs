using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class FinalSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 537, DateTimeKind.Local).AddTicks(338), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3803), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3859), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 2, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3876), new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified), 2, 1, "Ensure all modules have correct content changes", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3876), "Verify Content Changes" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 3, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3884), new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified), 2, 1, "Upload all Application Changes to Production", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3889), "Upload App Changes" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 4, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3897), new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified), 2, 1, "Check all Production repositories for current code changes", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3901), "Verify Content Changes" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 4, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3910), new DateTime(2020, 8, 19, 21, 15, 0, 0, DateTimeKind.Unspecified), 4, "Execute App Container Changes/Updates in Production, See App Container Tasks", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3914), "Execute App Changes" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3923), new DateTime(2020, 8, 19, 22, 45, 0, 0, DateTimeKind.Unspecified), 4, 2, "Deploy New U/I Layer Package, See U / I Layer Code", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3923), "Deploy New UI" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 3, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3936), new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified), 1, "Verify U/I has deployed to Production", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3936), "Verify New UI" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 3, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3944), new DateTime(2020, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), "Deploy Shared U/I Layer Package  See U / I Layer Code", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3948), "Deploy Shared UI" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3957), new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified), 2, "Verify Shared U/I has deployed to Production", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3957), "Verify Shared UI" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3970), new DateTime(2020, 8, 19, 23, 15, 0, 0, DateTimeKind.Unspecified), 4, 1, "Deploy New Services Layer Package, See Services Layer Code", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3970), "Deploy New Services" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3978), new DateTime(2020, 8, 19, 23, 15, 0, 0, DateTimeKind.Unspecified), "Verify Shared U/I has deployed to Production", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3983), "Verify New Services" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 2, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3991), new DateTime(2020, 8, 19, 23, 55, 0, 0, DateTimeKind.Unspecified), 2, 3, "Perform System Cache Refresh", new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3991), "Perform Refresh" });

            migrationBuilder.InsertData(
                table: "ReleaseTasks",
                columns: new[] { "ID", "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "IsVisisble", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 20, 5, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4060), new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "Enure no steps were missed", true, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4064), "Complete Final Checklist" },
                    { 19, 5, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4047), new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "System Monitoring Through Monday", true, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4051), "Monitor System" },
                    { 18, 3, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4038), new DateTime(2020, 8, 20, 2, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "Notify Group Validation Can Begin", true, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4038), "Notify Validation Group" },
                    { 17, 4, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4025), new DateTime(2020, 8, 21, 1, 15, 0, 0, DateTimeKind.Unspecified), 4, 3, "Update Message To Reflect Issues In The Event An Unplanned Outage Occurs", true, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4030), "Update User Message" },
                    { 16, 2, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4013), new DateTime(2020, 8, 20, 0, 1, 0, 0, DateTimeKind.Unspecified), 2, 2, "Bring Down Out of Service Page", true, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4017), "Remove Service Page" },
                    { 21, 5, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4072), new DateTime(2020, 8, 20, 8, 30, 0, 0, DateTimeKind.Unspecified), 3, 1, "Let users know system has been updated.", true, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4072), "Notify Users" },
                    { 15, 2, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4004), new DateTime(2020, 8, 19, 23, 55, 0, 0, DateTimeKind.Unspecified), 2, 3, "Verify System Cache Refresh", true, new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4004), "Verify Refresh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21);

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
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 4, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1852), new DateTime(2020, 8, 19, 21, 15, 0, 0, DateTimeKind.Unspecified), 4, 4, "Execute App Container Changes/Updates in Production, See App Container Tasks", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1856), "Execute App Changes" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 2, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1865), new DateTime(2020, 8, 19, 22, 45, 0, 0, DateTimeKind.Unspecified), 4, 2, "Deploy New U/I Layer Package, See U / I Layer Code", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1869), "Deploy New UI" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 3, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1877), new DateTime(2020, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, "Deploy Shared U/I Layer Package  See U / I Layer Code", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1882), "Deploy Shared UI" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1890), new DateTime(2020, 8, 19, 23, 15, 0, 0, DateTimeKind.Unspecified), 1, "Deploy New Services Layer Package, See Services Layer Code", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1890), "Deploy New Services" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1899), new DateTime(2020, 8, 19, 23, 55, 0, 0, DateTimeKind.Unspecified), 2, 3, "Perform System Cache Refresh", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1903), "Perform Refresh" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 2, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1912), new DateTime(2020, 8, 20, 0, 1, 0, 0, DateTimeKind.Unspecified), 2, "Bring Down Out of Service Page", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1916), "Remove Service Page" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 4, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1924), new DateTime(2020, 8, 21, 1, 15, 0, 0, DateTimeKind.Unspecified), "Update Message To Reflect Issues In The Event An Unplanned Outage Occurs", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1924), "Update User Message" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1933), new DateTime(2020, 8, 20, 2, 0, 0, 0, DateTimeKind.Unspecified), 3, "Notify Group Validation Can Begin", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1937), "Notify Validation Group" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 5, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1946), new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "System Monitoring Through Monday", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1950), "Monitor System" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 5, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1959), new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "Enure no steps were missed", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1959), "Complete Final Checklist" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "LastModifiedDate", "Name" },
                values: new object[] { 5, new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1967), new DateTime(2020, 8, 20, 8, 30, 0, 0, DateTimeKind.Unspecified), 3, 1, "Let users know system has been updated.", new DateTime(2020, 8, 4, 8, 41, 14, 161, DateTimeKind.Local).AddTicks(1971), "Notify Users" });
        }
    }
}

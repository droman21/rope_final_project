using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class NewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 65, DateTimeKind.Local).AddTicks(5347), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Validate Team Ready for Out of Service Page", new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(272), "Validate Readiness" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(947), "Update Message To Reflect Routine Maintenance", new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(969), "Update User Message" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(994), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Publish Content Updates/Changes, See Content Updates", new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(999), "Push Content Changes" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1007), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Execute App Container Changes/Updates in Production, See App Container Tasks", new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1007), "Execute App Changes" });

            migrationBuilder.InsertData(
                table: "ReleaseTasks",
                columns: new[] { "ID", "AssignedEmployeeID", "CreatedDate", "CurrentDueTime", "CurrentPriorityID", "CurrentStatusID", "Description", "IsVisisble", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 5, 2, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1016), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, "Deploy New U/I Layer Package, See U / I Layer Code", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1020), "Deploy New UI" },
                    { 6, 3, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1029), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, "Deploy Shared U/I Layer Package  See U / I Layer Code", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1033), "Deploy Shared UI" },
                    { 7, 1, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1041), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "Deploy New Services Layer Package, See Services Layer Code", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1041), "Deploy New Services" },
                    { 8, 2, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1050), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "Perform System Cache Refresh", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1054), "Perform Refresh" },
                    { 9, 2, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1063), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Bring Down Out of Service Page", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1067), "Remove Service Page" },
                    { 10, 4, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1076), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, "Update Message To Reflect Issues In The Event An Unplanned Outage Occurs", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1076), "Update User Message" },
                    { 11, 3, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1084), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, "Notify Group Validation Can Begin", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1088), "Notify Validation Group" },
                    { 12, 5, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1097), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "System Monitoring Through Monday", true, new DateTime(2020, 7, 30, 10, 21, 24, 68, DateTimeKind.Local).AddTicks(1097), "Monitor System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 28, 12, 36, 32, 235, DateTimeKind.Local).AddTicks(2077), new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", new DateTime(2020, 7, 28, 12, 36, 32, 237, DateTimeKind.Local).AddTicks(9956), "Release Task 1" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(725), "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(755), "Release Task 2" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(785), new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(794), "Release Task 3" });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CurrentDueTime", "Description", "LastModifiedDate", "Name" },
                values: new object[] { new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(807), new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(811), "Release Task 4" });
        }
    }
}

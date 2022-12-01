using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeetupApi.Infrastructure.Migr.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class FillRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30275fbc-db4f-4692-ba80-9dfe284d8ab6", "469ed6bc-8c47-4d83-9415-be178b36b8e9", "Participant", "PARTICIPANT" },
                    { "8faeed7f-9f1c-44f5-923b-7d74884904e6", "c4461ded-6afe-4eea-aa31-b875e22cd812", "Organizer", "ORGANIZER" }
                });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                column: "Date",
                value: new DateTime(2022, 12, 1, 2, 59, 5, 94, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4c"),
                column: "Time",
                value: new DateTime(2022, 12, 1, 2, 59, 5, 94, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("02abbca8-664d-4b20-b5de-024705497d4c"),
                column: "Time",
                value: new DateTime(2022, 12, 1, 2, 59, 5, 94, DateTimeKind.Local).AddTicks(8409));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30275fbc-db4f-4692-ba80-9dfe284d8ab6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8faeed7f-9f1c-44f5-923b-7d74884904e6");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                column: "Date",
                value: new DateTime(2022, 12, 1, 2, 50, 59, 609, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4c"),
                column: "Time",
                value: new DateTime(2022, 12, 1, 2, 50, 59, 609, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("02abbca8-664d-4b20-b5de-024705497d4c"),
                column: "Time",
                value: new DateTime(2022, 12, 1, 2, 50, 59, 609, DateTimeKind.Local).AddTicks(2196));
        }
    }
}

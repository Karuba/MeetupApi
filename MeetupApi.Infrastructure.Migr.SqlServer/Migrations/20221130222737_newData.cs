using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetupApi.Infrastructure.Migr.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class newData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                column: "Date",
                value: new DateTime(2022, 12, 1, 1, 27, 36, 957, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4c"),
                column: "Time",
                value: new DateTime(2022, 12, 1, 1, 27, 36, 957, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "Description", "EventId", "Time" },
                values: new object[] { new Guid("02abbca8-664d-4b20-b5de-024705497d4c"), "Conclusion", new Guid("01abbca8-664d-4b20-b5de-024705497d4a"), new DateTime(2022, 12, 1, 1, 27, 36, 957, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.InsertData(
                table: "Speaker",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("02abbca8-664d-4b20-b5de-024705497d4d"), "Some man" });

            migrationBuilder.InsertData(
                table: "EventSpeakers",
                columns: new[] { "EventId", "SpeakerId" },
                values: new object[] { new Guid("01abbca8-664d-4b20-b5de-024705497d4a"), new Guid("02abbca8-664d-4b20-b5de-024705497d4d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventSpeakers",
                keyColumns: new[] { "EventId", "SpeakerId" },
                keyValues: new object[] { new Guid("01abbca8-664d-4b20-b5de-024705497d4a"), new Guid("02abbca8-664d-4b20-b5de-024705497d4d") });

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("02abbca8-664d-4b20-b5de-024705497d4c"));

            migrationBuilder.DeleteData(
                table: "Speaker",
                keyColumn: "Id",
                keyValue: new Guid("02abbca8-664d-4b20-b5de-024705497d4d"));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                column: "Date",
                value: new DateTime(2022, 11, 30, 21, 58, 39, 173, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4c"),
                column: "Time",
                value: new DateTime(2022, 11, 30, 21, 58, 39, 173, DateTimeKind.Local).AddTicks(1653));
        }
    }
}

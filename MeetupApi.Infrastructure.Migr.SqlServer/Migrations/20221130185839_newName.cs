using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetupApi.Infrastructure.Migr.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class newName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizers_OrganizerId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Events_EventId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Speakers_SpeakerId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Events_EventId",
                table: "Plan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizers",
                table: "Organizers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Speakers",
                newName: "Speaker");

            migrationBuilder.RenameTable(
                name: "Organizers",
                newName: "Organizer");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameIndex(
                name: "IX_Events_OrganizerId",
                table: "Event",
                newName: "IX_Event_OrganizerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizer",
                table: "Organizer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerId",
                table: "Event",
                column: "OrganizerId",
                principalTable: "Organizer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Event_EventId",
                table: "EventSpeakers",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Speaker_SpeakerId",
                table: "EventSpeakers",
                column: "SpeakerId",
                principalTable: "Speaker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Event_EventId",
                table: "Plan",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Event_EventId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Speaker_SpeakerId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Event_EventId",
                table: "Plan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizer",
                table: "Organizer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.RenameTable(
                name: "Speaker",
                newName: "Speakers");

            migrationBuilder.RenameTable(
                name: "Organizer",
                newName: "Organizers");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_Event_OrganizerId",
                table: "Events",
                newName: "IX_Events_OrganizerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizers",
                table: "Organizers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4a"),
                column: "Date",
                value: new DateTime(2022, 11, 30, 21, 55, 41, 922, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("01abbca8-664d-4b20-b5de-024705497d4c"),
                column: "Time",
                value: new DateTime(2022, 11, 30, 21, 55, 41, 922, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizers_OrganizerId",
                table: "Events",
                column: "OrganizerId",
                principalTable: "Organizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Events_EventId",
                table: "EventSpeakers",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Speakers_SpeakerId",
                table: "EventSpeakers",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Events_EventId",
                table: "Plan",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

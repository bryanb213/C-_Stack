using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventss_Users_UserId",
                table: "Eventss");

            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Eventss_EventId",
                table: "RSVPs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Eventss",
                table: "Eventss");

            migrationBuilder.RenameTable(
                name: "Eventss",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_Eventss_UserId",
                table: "Events",
                newName: "IX_Events_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Events_EventId",
                table: "RSVPs",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_UserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Events_EventId",
                table: "RSVPs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Eventss");

            migrationBuilder.RenameIndex(
                name: "IX_Events_UserId",
                table: "Eventss",
                newName: "IX_Eventss_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eventss",
                table: "Eventss",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventss_Users_UserId",
                table: "Eventss",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Eventss_EventId",
                table: "RSVPs",
                column: "EventId",
                principalTable: "Eventss",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

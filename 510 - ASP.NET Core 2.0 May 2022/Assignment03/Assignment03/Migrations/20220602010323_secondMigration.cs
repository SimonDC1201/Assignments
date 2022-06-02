using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment03Restaurant.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "MenuItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_ReservationId",
                table: "MenuItems",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Reservation_ReservationId",
                table: "MenuItems",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Reservation_ReservationId",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_ReservationId",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "MenuItems");
        }
    }
}

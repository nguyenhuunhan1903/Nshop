using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshop.Migrations
{
    public partial class IdentityFirstConfigurev3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_AppUserId",
                table: "TRANSACTIONS");

            migrationBuilder.DropIndex(
                name: "IX_TRANSACTIONS_AppUserId",
                table: "TRANSACTIONS");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "TRANSACTIONS");

            migrationBuilder.CreateIndex(
                name: "IX_TRANSACTIONS_Userid",
                table: "TRANSACTIONS",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_Userid",
                table: "TRANSACTIONS",
                column: "Userid",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_Userid",
                table: "TRANSACTIONS");

            migrationBuilder.DropIndex(
                name: "IX_TRANSACTIONS_Userid",
                table: "TRANSACTIONS");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "TRANSACTIONS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TRANSACTIONS_AppUserId",
                table: "TRANSACTIONS",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_AppUserId",
                table: "TRANSACTIONS",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

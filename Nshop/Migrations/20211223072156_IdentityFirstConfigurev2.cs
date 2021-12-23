using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshop.Migrations
{
    public partial class IdentityFirstConfigurev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_AppUserid",
                table: "TRANSACTIONS");

            migrationBuilder.RenameColumn(
                name: "AppUserid",
                table: "TRANSACTIONS",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TRANSACTIONS_AppUserid",
                table: "TRANSACTIONS",
                newName: "IX_TRANSACTIONS_AppUserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "TRANSACTIONS",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Userid",
                table: "TRANSACTIONS",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_AppUserId",
                table: "TRANSACTIONS",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_AppUserId",
                table: "TRANSACTIONS");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "TRANSACTIONS");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "TRANSACTIONS",
                newName: "AppUserid");

            migrationBuilder.RenameIndex(
                name: "IX_TRANSACTIONS_AppUserId",
                table: "TRANSACTIONS",
                newName: "IX_TRANSACTIONS_AppUserid");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserid",
                table: "TRANSACTIONS",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TRANSACTIONS_AppUsers_AppUserid",
                table: "TRANSACTIONS",
                column: "AppUserid",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

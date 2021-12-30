using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshop.Migrations
{
    public partial class ChangeTypePaymentOnTrasaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PAYMENT",
                table: "TRANSACTIONS",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "varchar(32)",
                oldUnicode: false,
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6"),
                column: "ConcurrencyStamp",
                value: "93cf21e2-5dc9-44e1-a4d5-099d59ffc355");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61e4797f-5c89-4196-aa2d-d5086a4761e9", "AQAAAAEAACcQAAAAEHUijxtboIz59TrZXFZxozUzz5bfWMPZoaWm+Po1SL7wNZy/lMy0hzMOgKR/5Z/gQw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PAYMENT",
                table: "TRANSACTIONS",
                type: "varchar(32)",
                unicode: false,
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6"),
                column: "ConcurrencyStamp",
                value: "3893994e-ba22-4476-bbf4-efc31ff57993");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0039d654-69a6-4e09-a5c2-4fdbe90a23a5", "AQAAAAEAACcQAAAAEEVO/8uGgVGN/qOKTedtefE6xVb21cy4FHlq2VMcBkRrCLJxbWm0QS8OrZ9cNNCmQQ==" });
        }
    }
}

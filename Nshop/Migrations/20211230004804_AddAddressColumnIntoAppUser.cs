using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshop.Migrations
{
    public partial class AddAddressColumnIntoAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AppUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AppUsers");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6"),
                column: "ConcurrencyStamp",
                value: "6c8e78f8-f105-4235-8515-88f79693005e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b52078d3-4220-424e-adda-76d113da9157", "AQAAAAEAACcQAAAAEIstvne3ddQgAfQJ6/PXBycN1pHJVXvIb9f03D1SRlJDUWdni013DPnimThqmQSF8A==" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshop.Migrations
{
    public partial class AddDataAdminv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6"), "6c8e78f8-f105-4235-8515-88f79693005e", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"), new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"), 0, "b52078d3-4220-424e-adda-76d113da9157", new DateTime(2001, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenhuunhan1903@gmail.com", true, "Nhan", "Nguyen", false, null, "nguyenhuunhan1903@gmail.com", "admin", "AQAAAAEAACcQAAAAEIstvne3ddQgAfQJ6/PXBycN1pHJVXvIb9f03D1SRlJDUWdni013DPnimThqmQSF8A==", null, false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"), new Guid("4e1cae6d-4d76-4311-9b2a-ed8cd3eea0e6") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8c2beb7-0552-42ff-844d-fbc499398a37"));
        }
    }
}

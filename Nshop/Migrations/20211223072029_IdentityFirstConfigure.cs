using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nshop.Migrations
{
    public partial class IdentityFirstConfigure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CATALOGS",
                columns: table => new
                {
                    CATALOG_ID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CATALOG_NAME = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CATALOGS__DC3C6591D725476B", x => x.CATALOG_ID);
                });

            migrationBuilder.CreateTable(
                name: "TRANSACTIONS",
                columns: table => new
                {
                    TRANSACTION_ID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    AMOUNT = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    MESSAGE_T = table.Column<string>(maxLength: 255, nullable: true),
                    CREATE_DAY = table.Column<DateTime>(type: "datetime", nullable: true),
                    PAYMENT = table.Column<string>(unicode: false, maxLength: 32, nullable: true),
                    AppUserid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TRANSACT__16998B61D7E98AD9", x => x.TRANSACTION_ID);
                    table.ForeignKey(
                        name: "FK_TRANSACTIONS_AppUsers_AppUserid",
                        column: x => x.AppUserid,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    PRODUCT_ID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    CATALOG_ID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    PRODUCT_NAME = table.Column<string>(maxLength: 100, nullable: true),
                    PRICE = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    DESCRIPTIONS = table.Column<string>(type: "ntext", nullable: true),
                    DISCOUNT = table.Column<int>(nullable: true),
                    IMAGE_LINK = table.Column<string>(type: "ntext", nullable: true),
                    QUANTITY = table.Column<int>(nullable: true),
                    DETAIL = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCTS__52B41763D50E6E50", x => x.PRODUCT_ID);
                    table.ForeignKey(
                        name: "FK_CATALOGS",
                        column: x => x.CATALOG_ID,
                        principalTable: "CATALOGS",
                        principalColumn: "CATALOG_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    ORDER_ID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    TRANSACTION_ID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    PRODUCT_ID = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    QUANTITY = table.Column<int>(nullable: true),
                    ORDER_STATUS = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDERS__460A9464D0E0B109", x => x.ORDER_ID);
                    table.ForeignKey(
                        name: "FK_PRODUCT",
                        column: x => x.PRODUCT_ID,
                        principalTable: "PRODUCTS",
                        principalColumn: "PRODUCT_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDER",
                        column: x => x.TRANSACTION_ID,
                        principalTable: "TRANSACTIONS",
                        principalColumn: "TRANSACTION_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_PRODUCT_ID",
                table: "ORDERS",
                column: "PRODUCT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_TRANSACTION_ID",
                table: "ORDERS",
                column: "TRANSACTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_CATALOG_ID",
                table: "PRODUCTS",
                column: "CATALOG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TRANSACTIONS_AppUserid",
                table: "TRANSACTIONS",
                column: "AppUserid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "TRANSACTIONS");

            migrationBuilder.DropTable(
                name: "CATALOGS");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}

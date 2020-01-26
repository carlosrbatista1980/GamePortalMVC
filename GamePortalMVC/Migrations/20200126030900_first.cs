using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GamePortalMVC.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    account_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password2 = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    block = table.Column<int>(nullable: false),
                    IP_user = table.Column<string>(nullable: true),
                    Admin = table.Column<int>(nullable: false),
                    point = table.Column<int>(nullable: false),
                    datePassword = table.Column<DateTime>(nullable: false),
                    last_login_server_idx = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.account_id);
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account = table.Column<string>(nullable: true),
                    account_id = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    unban_date = table.Column<DateTime>(nullable: false),
                    ban_owner = table.Column<string>(nullable: true),
                    ban_disc = table.Column<string>(nullable: true),
                    typeBlock = table.Column<int>(nullable: false),
                    account_id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.id);
                    table.ForeignKey(
                        name: "FK_Block_Account_account_id1",
                        column: x => x.account_id1,
                        principalTable: "Account",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Block_account_id1",
                table: "Block",
                column: "account_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}

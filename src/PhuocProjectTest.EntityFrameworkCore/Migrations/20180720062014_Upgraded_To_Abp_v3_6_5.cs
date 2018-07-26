using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhuocProjectTest.Migrations
{
    public partial class Upgraded_To_Abp_v3_6_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "verification",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    CodeStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_verification", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "verification");
        }
    }
}

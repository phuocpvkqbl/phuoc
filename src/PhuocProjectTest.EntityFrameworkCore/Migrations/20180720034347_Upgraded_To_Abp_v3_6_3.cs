using Microsoft.EntityFrameworkCore.Migrations;

namespace PhuocProjectTest.Migrations
{
    public partial class Upgraded_To_Abp_v3_6_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AbpUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AbpUsers");
        }
    }
}

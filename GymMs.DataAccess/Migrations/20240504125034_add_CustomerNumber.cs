using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add_CustomerNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerNumber",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerNumber",
                table: "AspNetUsers");
        }
    }
}

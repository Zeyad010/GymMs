using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SubscriptionStatusUserTb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubscriptionStatus",
                table: "TbUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TbUsers",
                keyColumn: "ID",
                keyValue: 124,
                column: "SubscriptionStatus",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "TbUsers",
                keyColumn: "ID",
                keyValue: 224,
                column: "SubscriptionStatus",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "TbUsers",
                keyColumn: "ID",
                keyValue: 324,
                column: "SubscriptionStatus",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "TbUsers",
                keyColumn: "ID",
                keyValue: 424,
                column: "SubscriptionStatus",
                value: "Active");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionStatus",
                table: "TbUsers");
        }
    }
}

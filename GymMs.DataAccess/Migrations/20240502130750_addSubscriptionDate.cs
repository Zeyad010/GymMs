using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymMs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSubscriptionDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "SubscriptionDate",
                table: "AspNetUsers",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionDate",
                table: "AspNetUsers");
        }
    }
}

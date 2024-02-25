using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymMs.DataAccess.Migrations  
{
    /// <inheritdoc />
    public partial class UserEmployeeTb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbEmployees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gander = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbEmployees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TbUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gander = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionPlan = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUsers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "TbEmployees",
                columns: new[] { "ID", "Age", "Email", "Gander", "Job", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 111, 26, "momen@gmail.com", "Male", "Trainer", "Momen Maher", "Mo1234", "0100123776" },
                    { 113, 25, "kkkn@gmail.com", "Female", "Trainer", "Kamilya Nader", "k1234", "0100333776" },
                    { 1112, 24, "ainforma@gmail.com", "Male", "Trainer", "Ahmed Ali", "aan1234", "0100124476" }
                });

            migrationBuilder.InsertData(
                table: "TbUsers",
                columns: new[] { "ID", "Age", "Email", "Gander", "Name", "Password", "Phone", "SubscriptionPlan" },
                values: new object[,]
                {
                    { 124, 22, "yousefmo@gmail.com", "Male", "Yousef Mohamed", "Yo1234", "0100123456", "Platinum" },
                    { 224, 27, "alimomo@gmail.com", "Male", "Ali Mohamed", "ali1234", "0100169456", "Platinum" },
                    { 324, 23, "laylaqn@gmail.com", "Female", "Layla Ahmed", "lili1234", "0100128756", "Gold" },
                    { 424, 25, "nadaazein@gmail.com", "Female", "Nada Zein  ", "Na1234", "0100119456", "VIP" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbEmployees");

            migrationBuilder.DropTable(
                name: "TbUsers");
        }
    }
}

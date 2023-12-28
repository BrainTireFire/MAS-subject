using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ADdMOtivator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MotivatorIdMotivator",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Motivator",
                columns: table => new
                {
                    IdMotivator = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Pseudonym = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motivator", x => x.IdMotivator);
                });

            migrationBuilder.InsertData(
                table: "Motivator",
                columns: new[] { "IdMotivator", "Name", "Pseudonym" },
                values: new object[,]
                {
                    { 1, "John Doe", "MotivatorX" },
                    { 2, "Emily Smith", "InspireMe" },
                    { 3, "David Johnson", "MotivateToday" },
                    { 4, "Sarah Thompson", "PositiveVibes" },
                    { 5, "Michael Rodriguez", "DreamAchiever" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MotivatorIdMotivator",
                table: "AspNetUsers",
                column: "MotivatorIdMotivator");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Motivator_MotivatorIdMotivator",
                table: "AspNetUsers",
                column: "MotivatorIdMotivator",
                principalTable: "Motivator",
                principalColumn: "IdMotivator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Motivator_MotivatorIdMotivator",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Motivator");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MotivatorIdMotivator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MotivatorIdMotivator",
                table: "AspNetUsers");
        }
    }
}

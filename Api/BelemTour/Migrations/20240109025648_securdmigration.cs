using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BelemTour.Migrations
{
    /// <inheritdoc />
    public partial class securdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tempo",
                table: "destino",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "categoria",
                table: "destino",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "destino",
                columns: new[] { "id", "categoria", "nome", "tempo", "valor" },
                values: new object[,]
                {
                    { 1, "Tur", "Salinopolis", "5 Dias", 200.00m },
                    { 2, "Passeios Regulares", "Mosqueiro", "1 semana", 499.00m },
                    { 3, "Passeios Regulares", "Algodoal", "2 semana", 900.00m },
                    { 4, "Passeios Regulares", "Marudá", "15 Dias", 500.00m },
                    { 5, "Passeios Regulares", "Ajuruteua", "3 semana", 1500.00m },
                    { 6, "Tur", "Outeiro", " 10 dias", 400.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destino",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "destino",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "destino",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "destino",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "destino",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "destino",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "tempo",
                table: "destino",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "categoria",
                table: "destino",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

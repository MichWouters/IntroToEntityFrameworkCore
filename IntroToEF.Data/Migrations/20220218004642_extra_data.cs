using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroToEF.Data.Migrations
{
    public partial class extra_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Horses",
                columns: new[] { "Id", "Age", "IsWarHorse", "Name", "SamuraiId" },
                values: new object[,]
                {
                    { 1, 3, false, "Jolly Jumper", 1 },
                    { 2, 5, true, "Jolly Jumper", 1 },
                    { 3, 1, true, "Jolly Jumper", 2 },
                    { 4, 12, false, "Jolly Jumper", 5 },
                    { 5, 3, false, "Jolly Jumper", 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Horses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

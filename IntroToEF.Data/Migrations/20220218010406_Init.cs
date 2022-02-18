using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroToEF.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samurais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dynasty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samurais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BattleSamurai",
                columns: table => new
                {
                    BattlesId = table.Column<int>(type: "int", nullable: false),
                    SamuraisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleSamurai", x => new { x.BattlesId, x.SamuraisId });
                    table.ForeignKey(
                        name: "FK_BattleSamurai_Battles_BattlesId",
                        column: x => x.BattlesId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattleSamurai_Samurais_SamuraisId",
                        column: x => x.SamuraisId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    IsWarHorse = table.Column<bool>(type: "bit", nullable: false),
                    SamuraiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horses_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SamuraiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Samurais",
                columns: new[] { "Id", "Dynasty", "Name" },
                values: new object[,]
                {
                    { 1, "Asuka", "Abe Masakatsu" },
                    { 2, "Kamakura", "Baba Nobufusa" },
                    { 3, "Kamakura", "Chosokabe Nobuchika" },
                    { 4, "Edo", "Date Masamune" },
                    { 5, "Meiji", "Eto Shinpei" },
                    { 6, "Meiji", "Fuma Kotaro" },
                    { 7, "Edo", "Gamo Ujisato" },
                    { 8, "Asuka", "Harada Nobutane" },
                    { 9, "Meiji", "Ii Naomasa" },
                    { 10, "Edo", "Kido Takayoshi" },
                    { 11, "Edo", "Maeda Toshiie" },
                    { 12, "Kamakura", "Mori Okimoto" }
                });

            migrationBuilder.InsertData(
                table: "Horses",
                columns: new[] { "Id", "Age", "IsWarHorse", "Name", "SamuraiId" },
                values: new object[,]
                {
                    { 1, 3, false, "Jolly Jumper", 1 },
                    { 2, 5, true, "Black Beauty", 1 },
                    { 3, 1, true, "Vito", 2 },
                    { 4, 12, false, "Kartoum", 5 },
                    { 5, 3, false, "Fleetfoot", 12 }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "SamuraiId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "Summer grasses, All that remains of soldiers' dreams" },
                    { 2, 1, "New eras don't come about because of swords, they're created by the people who wield them" },
                    { 8, 1, "Bushido is realized in the presence of death. This means choosing death whenever there is a choice between life and death. There is no other reasoning" },
                    { 3, 2, "A man who can't uphold his beliefs is pathetic dead or alive" },
                    { 4, 2, "I dreamt of worldly success once" },
                    { 5, 5, "Rehearse your death every morning and night. Only when you constantly live as though already a corpse will you be able to find freedom in the martial Way, and fulfill your duties without fault throughout your life" },
                    { 6, 5, "The Way of the warrior (bushido) is to be found in dying." },
                    { 7, 7, "It is the genius of life that demands of those who partake in it that they are not only the guardians of what was and is, but what will be" },
                    { 9, 7, "It is the genius of life that demands of those who partake in it that they are not only are guardians of what was and is, but what will be" },
                    { 10, 10, "The katana has been the weapon of the samurai since time immemorial. Consider the inner meaning" },
                    { 11, 12, "No matter how much you hate or how much you suffer, you can't bring the dead back to life" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattleSamurai_SamuraisId",
                table: "BattleSamurai",
                column: "SamuraisId");

            migrationBuilder.CreateIndex(
                name: "IX_Horses_SamuraiId",
                table: "Horses",
                column: "SamuraiId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes",
                column: "SamuraiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleSamurai");

            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "Samurais");
        }
    }
}

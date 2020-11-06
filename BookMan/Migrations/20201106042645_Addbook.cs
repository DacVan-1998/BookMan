using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMan.Migrations
{
    public partial class Addbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Authors = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Authors", "Description", "Name", "Publisher", "Year" },
                values: new object[] { 1, "Trump D.", "Đây là của Trump", "ASP.NET Core for dummy", "Washington", 2020 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Authors", "Description", "Name", "Publisher", "Year" },
                values: new object[] { 2, "Putin V. D.", "Đây là của Putin", "Pro ASP.NET Core", "Moscow", 2020 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Authors", "Description", "Name", "Publisher", "Year" },
                values: new object[] { 3, "Obama B.", "Đây là của Obama", "ASP.NET Core Video Tutorial  ", "Washington", 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

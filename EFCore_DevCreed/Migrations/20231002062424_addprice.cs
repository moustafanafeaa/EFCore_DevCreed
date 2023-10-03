using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DevCreed.Migrations
{
    /// <inheritdoc />
    public partial class addprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Blogs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 40m);

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    booknumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("bookid", x => x.booknumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Blogs");
        }
    }
}

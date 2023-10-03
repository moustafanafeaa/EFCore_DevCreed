using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DevCreed.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Authors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                computedColumnSql: "[FName] + ' ' [LName]");
        }
    }
}

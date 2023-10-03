using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DevCreed.Migrations
{
    /// <inheritdoc />
    public partial class addfullname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                computedColumnSql: "[FName] + ' ' + [LName]",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldComputedColumnSql: "[FName] + ' ' + [LName]");
        }
    }
}

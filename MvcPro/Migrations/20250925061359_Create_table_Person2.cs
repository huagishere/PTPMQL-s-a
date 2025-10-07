using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcPro.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Person2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Point",
                table: "person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Point",
                table: "person");
        }
    }
}

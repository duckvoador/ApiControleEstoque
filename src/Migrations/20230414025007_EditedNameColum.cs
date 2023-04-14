using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWantApp.Migrations
{
    /// <inheritdoc />
    public partial class EditedNameColum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "Products",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "Categories",
                newName: "CreatedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Products",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Categories",
                newName: "CreateBy");
        }
    }
}

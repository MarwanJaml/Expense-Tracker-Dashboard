using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class RenameCategoryIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Rename the column (correcting the typo)
            migrationBuilder.RenameColumn(
                name: "CategortyID",  // Current incorrect name in DB
                table: "Categories",  // Your table name
                newName: "CategoryID"); // New correct name
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert the rename if needed
            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CategortyID");
        }
    }
}

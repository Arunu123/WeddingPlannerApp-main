using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetService0025.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainingBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BudgetId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllocatedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SpentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Budget0025Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetCategories_Budgets_Budget0025Id",
                        column: x => x.Budget0025Id,
                        principalTable: "Budgets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VendorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpenseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BudgetCategory0025Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_BudgetCategories_BudgetCategory0025Id",
                        column: x => x.BudgetCategory0025Id,
                        principalTable: "BudgetCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetCategories_Budget0025Id",
                table: "BudgetCategories",
                column: "Budget0025Id");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_BudgetCategory0025Id",
                table: "Expenses",
                column: "BudgetCategory0025Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "BudgetCategories");

            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}

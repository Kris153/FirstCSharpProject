using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstProject.Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    MinimumThreshold = table.Column<decimal>(type: "TEXT", nullable: false),
                    IncomeTaxPercentage = table.Column<decimal>(type: "TEXT", nullable: false),
                    InsurancePercantage = table.Column<decimal>(type: "TEXT", nullable: false),
                    MaximumInsuranceThreshold = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    MonthSalary = table.Column<decimal>(type: "TEXT", nullable: false),
                    YearInWhichHeWorkedId = table.Column<int>(type: "INTEGER", nullable: false),
                    yearId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Years_yearId",
                        column: x => x.yearId,
                        principalTable: "Years",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_yearId",
                table: "Employees",
                column: "yearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Years");
        }
    }
}

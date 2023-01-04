using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThaoNguyen451.Migrations
{
    /// <inheritdoc />
    public partial class UniversityNTN451 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityNTN451",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityNTN451", x => x.UniversityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityNTN451");
        }
    }
}

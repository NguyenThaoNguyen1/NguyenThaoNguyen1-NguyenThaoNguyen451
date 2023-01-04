using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenThaoNguyen451.Migrations
{
    /// <inheritdoc />
    public partial class NTN451 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTN451",
                columns: table => new
                {
                    NTNId = table.Column<string>(type: "TEXT", nullable: false),
                    NTNName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTN451", x => x.NTNId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTN451");
        }
    }
}

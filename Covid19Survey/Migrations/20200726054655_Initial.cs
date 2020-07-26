using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19Survey.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResponseCollection",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    WearMask = table.Column<bool>(nullable: false),
                    PublicTransportation = table.Column<bool>(nullable: false),
                    Work = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseCollection", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponseCollection");
        }
    }
}

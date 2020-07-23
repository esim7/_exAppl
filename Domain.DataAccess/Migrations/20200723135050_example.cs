using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.DataAccess.Migrations
{
    public partial class example : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EApplications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iin = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Discipline1 = table.Column<int>(nullable: false),
                    Discipline2 = table.Column<int>(nullable: false),
                    College = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EApplications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EApplications");
        }
    }
}

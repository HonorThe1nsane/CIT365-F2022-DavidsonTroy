using Microsoft.EntityFrameworkCore.Migrations;

namespace Personal_study.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scripture_entry",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scripture_reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scripture_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scripture_note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scripture_date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scripture_entry", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scripture_entry");
        }
    }
}

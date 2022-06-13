using Microsoft.EntityFrameworkCore.Migrations;

namespace question.Migrations
{
    public partial class cat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Category = table.Column<int>(nullable: false),
                    Question = table.Column<string>(nullable: true),
                    Question_Type = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Request = table.Column<bool>(nullable: false),
                    Access = table.Column<string>(nullable: true),
                    Question_Number = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Questions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Categories");

            migrationBuilder.DropTable(
                name: "tbl_Questions");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace imenik_app.Migrations
{
    public partial class telStevilkaToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelStevilka",
                table: "Imeniki",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TelStevilka",
                table: "Imeniki",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeCycle.Migrations
{
    public partial class cambioTipoVariableNumeroTel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "Usuario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

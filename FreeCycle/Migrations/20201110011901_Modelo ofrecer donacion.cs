using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeCycle.Migrations
{
    public partial class Modeloofrecerdonacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {      
            migrationBuilder.CreateTable(
                name: "ofrecerDonacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    adress = table.Column<string>(nullable: false),
                    estado = table.Column<string>(nullable: false),
                    objeto = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofrecerDonacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ofrecerDonacion_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ofrecerDonacion_UsuarioId",
                table: "ofrecerDonacion",
                column: "UsuarioId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.DropTable(
                name: "ofrecerDonacion");


        
        }
    }
}

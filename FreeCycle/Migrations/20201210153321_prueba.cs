using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeCycle.Migrations
{
    public partial class prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosGeneralesPersonas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoIdentificacion = table.Column<int>(nullable: false),
                    NumeroIdentificacion = table.Column<string>(nullable: false),
                    PrimerNombre = table.Column<string>(nullable: false),
                    SegundoNombre = table.Column<string>(nullable: true),
                    PrimerApellido = table.Column<string>(nullable: false),
                    SegundoApellido = table.Column<string>(nullable: true),
                    Genero = table.Column<int>(nullable: false),
                    Profesion = table.Column<string>(nullable: false),
                    AnhosExperiencia = table.Column<int>(nullable: true),
                    MesesExperiencia = table.Column<int>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Ciudad = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Barrio = table.Column<string>(nullable: false),
                    PersonaContactoNombre = table.Column<string>(nullable: true),
                    PersonaContactoTelefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosGeneralesPersonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "datosAcademicosPersonas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datosAcademicosPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_datosAcademicosPersonas_DatosGeneralesPersonas_Id",
                        column: x => x.Id,
                        principalTable: "DatosGeneralesPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatosEspecificosPersonas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    DepartamentoExpedicionIdentificacion = table.Column<string>(nullable: true),
                    CiudadExpedicionIdentificacion = table.Column<string>(nullable: true),
                    FechaExpedicionIdentificacion = table.Column<DateTime>(nullable: true),
                    Pais = table.Column<string>(nullable: false),
                    Departamento = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    TipoDeSangre = table.Column<int>(nullable: true),
                    FactorRHSangre = table.Column<int>(nullable: true),
                    EstadoCivil = table.Column<int>(nullable: false),
                    NumeroLibretaMilitar = table.Column<string>(nullable: true),
                    ClaseLibretaMilitar = table.Column<int>(nullable: false),
                    NumeroDistritoMilitar = table.Column<string>(nullable: true),
                    PaseDeConduccionTiene = table.Column<bool>(nullable: false),
                    PaseDeConduccionCategoriaA = table.Column<int>(nullable: true),
                    FechaVencecategoriaA = table.Column<DateTime>(nullable: true),
                    PaseDeConduccionCategoriaB = table.Column<int>(nullable: true),
                    FechaVencecategoriaB = table.Column<DateTime>(nullable: true),
                    PaseDeConduccionCategoriaC = table.Column<int>(nullable: true),
                    FechaVencecategoriaC = table.Column<DateTime>(nullable: true),
                    VehiculoTiene = table.Column<bool>(nullable: false),
                    TipoVehiculo = table.Column<int>(nullable: true),
                    TallaCamisa = table.Column<int>(nullable: true),
                    TallaPantalon = table.Column<int>(nullable: true),
                    TallaZapato = table.Column<int>(nullable: true),
                    SeguridadSocialEPS = table.Column<string>(nullable: false),
                    SeguridadSocialFondoDePensiones = table.Column<string>(nullable: true),
                    SeguridadSocialNumeroDeBeneficiaros = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosEspecificosPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatosEspecificosPersonas_DatosGeneralesPersonas_Id",
                        column: x => x.Id,
                        principalTable: "DatosGeneralesPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "datosLaboralesPersonas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DatosGeneralesPersonaId = table.Column<long>(nullable: false),
                    NombreEmpresa = table.Column<string>(nullable: false),
                    NombreTemporal = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    CargoDesempeñado = table.Column<string>(nullable: false),
                    NombreJefe = table.Column<string>(nullable: true),
                    CargoJefe = table.Column<string>(nullable: true),
                    TelefonoJefe = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaRetiro = table.Column<DateTime>(nullable: true),
                    MotivoRetiro = table.Column<string>(nullable: true),
                    Salario = table.Column<double>(nullable: true),
                    TrabajoActual = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_datosLaboralesPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_datosLaboralesPersonas_DatosGeneralesPersonas_DatosGenerales~",
                        column: x => x.DatosGeneralesPersonaId,
                        principalTable: "DatosGeneralesPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "estudioPersonas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DatosAcademicosPersonaID = table.Column<long>(nullable: false),
                    NivelEstudio = table.Column<string>(nullable: false),
                    InstitucionAcademica = table.Column<string>(nullable: false),
                    ProgramaAcademico = table.Column<string>(nullable: false),
                    Ciudad = table.Column<string>(nullable: true),
                    AñoTerminacion = table.Column<DateTime>(nullable: true),
                    PeriodosAprobados = table.Column<int>(nullable: true),
                    Finalizo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estudioPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estudioPersonas_datosAcademicosPersonas_DatosAcademicosPerso~",
                        column: x => x.DatosAcademicosPersonaID,
                        principalTable: "datosAcademicosPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "idiomaPersonas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DatosAcademicosPersonaID = table.Column<long>(nullable: false),
                    Idioma = table.Column<string>(nullable: true),
                    DominioIdioma = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_idiomaPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_idiomaPersonas_datosAcademicosPersonas_DatosAcademicosPerson~",
                        column: x => x.DatosAcademicosPersonaID,
                        principalTable: "datosAcademicosPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_datosLaboralesPersonas_DatosGeneralesPersonaId",
                table: "datosLaboralesPersonas",
                column: "DatosGeneralesPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_estudioPersonas_DatosAcademicosPersonaID",
                table: "estudioPersonas",
                column: "DatosAcademicosPersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_idiomaPersonas_DatosAcademicosPersonaID",
                table: "idiomaPersonas",
                column: "DatosAcademicosPersonaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosEspecificosPersonas");

            migrationBuilder.DropTable(
                name: "datosLaboralesPersonas");

            migrationBuilder.DropTable(
                name: "estudioPersonas");

            migrationBuilder.DropTable(
                name: "idiomaPersonas");

            migrationBuilder.DropTable(
                name: "datosAcademicosPersonas");

            migrationBuilder.DropTable(
                name: "DatosGeneralesPersonas");
        }
    }
}

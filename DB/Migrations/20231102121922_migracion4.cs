using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DB.Migrations
{
    public partial class migracion4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accesos",
                columns: table => new
                {
                    id_acceso = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    codigo_acceso = table.Column<string>(type: "text", nullable: false),
                    descipcion_acceso = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesos", x => x.id_acceso);
                });

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    id_autor = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_autor = table.Column<string>(type: "text", nullable: false),
                    apellidos_autor = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.id_autor);
                });

            migrationBuilder.CreateTable(
                name: "Colecciones",
                columns: table => new
                {
                    id_coleccion = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_coleccion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colecciones", x => x.id_coleccion);
                });

            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    id_editorial = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_editorial = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.id_editorial);
                });

            migrationBuilder.CreateTable(
                name: "Estados_Prestamos",
                columns: table => new
                {
                    id_estado_prestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    codigo_estado_prestamo = table.Column<string>(type: "text", nullable: false),
                    descripcion_estado_prestamo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Prestamos", x => x.id_estado_prestamo);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    id_genero = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre_genero = table.Column<string>(type: "text", nullable: false),
                    descripcion_genero = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.id_genero);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    dni_usuario = table.Column<string>(type: "text", nullable: false),
                    nombre_usuario = table.Column<string>(type: "text", nullable: false),
                    apellidos_usuario = table.Column<string>(type: "text", nullable: false),
                    tlf_usuario = table.Column<string>(type: "text", nullable: false),
                    email_usuario = table.Column<string>(type: "text", nullable: false),
                    clave_usuario = table.Column<string>(type: "text", nullable: false),
                    id_acceso = table.Column<long>(type: "bigint", nullable: false),
                    estaBloqueado_usuario = table.Column<bool>(type: "boolean", nullable: false),
                    fch_fin_bloqueo_usuario = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fch_alta_usuario = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fch_baja_usuario = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Accesos_id_acceso",
                        column: x => x.id_acceso,
                        principalTable: "Accesos",
                        principalColumn: "id_acceso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    id_libro = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    isbn_libro = table.Column<string>(type: "text", nullable: false),
                    titulo_libro = table.Column<string>(type: "text", nullable: false),
                    edicion_libro = table.Column<string>(type: "text", nullable: false),
                    cantidad = table.Column<int>(type: "integer", nullable: false),
                    id_editorial = table.Column<long>(type: "bigint", nullable: false),
                    id_genero = table.Column<long>(type: "bigint", nullable: false),
                    id_coleccion = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.id_libro);
                    table.ForeignKey(
                        name: "FK_Libros_Colecciones_id_coleccion",
                        column: x => x.id_coleccion,
                        principalTable: "Colecciones",
                        principalColumn: "id_coleccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Libros_Editoriales_id_editorial",
                        column: x => x.id_editorial,
                        principalTable: "Editoriales",
                        principalColumn: "id_editorial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Libros_Generos_id_genero",
                        column: x => x.id_genero,
                        principalTable: "Generos",
                        principalColumn: "id_genero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    id_prestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    id_usuario = table.Column<long>(type: "bigint", nullable: false),
                    fch_inicio_prestamo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fch_fin_prestamo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fch_entrega_prestamo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    id_estado_prestamo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.id_prestamo);
                    table.ForeignKey(
                        name: "FK_Prestamos_Estados_Prestamos_id_estado_prestamo",
                        column: x => x.id_estado_prestamo,
                        principalTable: "Estados_Prestamos",
                        principalColumn: "id_estado_prestamo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Usuarios_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLibro",
                columns: table => new
                {
                    libro_con_autoresid_autor = table.Column<long>(type: "bigint", nullable: false),
                    libros_con_autorid_libro = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLibro", x => new { x.libro_con_autoresid_autor, x.libros_con_autorid_libro });
                    table.ForeignKey(
                        name: "FK_AutorLibro_Autores_libro_con_autoresid_autor",
                        column: x => x.libro_con_autoresid_autor,
                        principalTable: "Autores",
                        principalColumn: "id_autor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Libros_libros_con_autorid_libro",
                        column: x => x.libros_con_autorid_libro,
                        principalTable: "Libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibroPrestamo",
                columns: table => new
                {
                    libro_con_prestamosid_prestamo = table.Column<long>(type: "bigint", nullable: false),
                    libros_de_prestamoid_libro = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroPrestamo", x => new { x.libro_con_prestamosid_prestamo, x.libros_de_prestamoid_libro });
                    table.ForeignKey(
                        name: "FK_LibroPrestamo_Libros_libros_de_prestamoid_libro",
                        column: x => x.libros_de_prestamoid_libro,
                        principalTable: "Libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibroPrestamo_Prestamos_libro_con_prestamosid_prestamo",
                        column: x => x.libro_con_prestamosid_prestamo,
                        principalTable: "Prestamos",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_libros_con_autorid_libro",
                table: "AutorLibro",
                column: "libros_con_autorid_libro");

            migrationBuilder.CreateIndex(
                name: "IX_LibroPrestamo_libros_de_prestamoid_libro",
                table: "LibroPrestamo",
                column: "libros_de_prestamoid_libro");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_id_coleccion",
                table: "Libros",
                column: "id_coleccion");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_id_editorial",
                table: "Libros",
                column: "id_editorial");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_id_genero",
                table: "Libros",
                column: "id_genero");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_id_estado_prestamo",
                table: "Prestamos",
                column: "id_estado_prestamo");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_id_usuario",
                table: "Prestamos",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_id_acceso",
                table: "Usuarios",
                column: "id_acceso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLibro");

            migrationBuilder.DropTable(
                name: "LibroPrestamo");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Colecciones");

            migrationBuilder.DropTable(
                name: "Editoriales");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Estados_Prestamos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Accesos");
        }
    }
}

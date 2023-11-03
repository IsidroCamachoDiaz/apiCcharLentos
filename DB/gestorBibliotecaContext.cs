using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class GestorBibliotecaContext:DbContext
    {
        public GestorBibliotecaContext() { }
        public GestorBibliotecaContext(DbContextOptions<GestorBibliotecaContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=gestorBibliotecaPersonal;User Id=postgres;Password=;SearchPath=gbp_operacional");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Acceso> Accesos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Coleccion> Colecciones { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Estado_Prestamo> Estados_Prestamos { get; set; }

    }
}

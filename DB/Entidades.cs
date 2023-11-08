using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{

    public class Autor
    {
        [Key]
        public long id_autor { get; set; }

        public string nombre_autor { get; set; }

        public string apellidos_autor { get; set; }

        public List<Libro> libros_con_autor { get; set; }

        public Autor(string nombre_autor, string apellidos_autor, List<Libro> libros_con_autor)
        {
            this.nombre_autor = nombre_autor;
            this.apellidos_autor = apellidos_autor;
            this.libros_con_autor = libros_con_autor;
        }
        public Autor()
        {

        }
    }

    public class Libro
    {
        [Key]
        public long id_libro { get; set; }

        public string isbn_libro { get; set; }

        public string titulo_libro { get; set; }

        public string edicion_libro { get; set; }

        public int cantidad {  get; set; }

        public long id_editorial { get; set; }
        [ForeignKey("id_editorial")]
        public Editorial editorial { get; set; }

        public long id_genero { get; set; }
        [ForeignKey("id_genero")]
        public Genero genero { get; set; }

        public long id_coleccion { get; set; }
        [ForeignKey("id_coleccion")]
        public Coleccion coleccion { get; set; }

        public List<Autor> libro_con_autores { get; set; }
        public List<Prestamo> libro_con_prestamos { get; set; }

        public Libro(string isbn_libro, string titulo_libro, string edicion_libro, int cantidad,Editorial editorial,Genero genero, Coleccion coleccion, List<Autor> libro_con_autores, List<Prestamo> libro_con_prestamos)
        {
            this.isbn_libro = isbn_libro;
            this.titulo_libro = titulo_libro;
            this.edicion_libro = edicion_libro;
            this.cantidad = cantidad;
            this.editorial = editorial;
            this.genero = genero;
            this.coleccion = coleccion;
            this.libro_con_autores = libro_con_autores;
            this.libro_con_prestamos = libro_con_prestamos;
        }
        public Libro()
        {

        }
    }

    public class Editorial
    {
        [Key]
        public long id_editorial { get; set; }
        public string nombre_editorial { get; set; }

        public List<Libro> editorial_con_libros { get; set; }

        public Editorial(string nombre_editorial, List<Libro> editorial_con_libros)
        {
            this.nombre_editorial = nombre_editorial;
            this.editorial_con_libros = editorial_con_libros;
        }
        public Editorial()
        {

        }
    }
    public class Genero
    {
        [Key]
        public long id_genero { get; set; }

        public string nombre_genero { get; set; }

        public string descripcion_genero { get; set; }

        public List<Libro> genero_con_libros { get; set; }

        public Genero(string nombre_genero, string descripcion_genero, List<Libro> genero_con_libros)
        {
            this.nombre_genero = nombre_genero;
            this.descripcion_genero = descripcion_genero;
            this.genero_con_libros = genero_con_libros;
        }
        public Genero()
        {

        }
    }

    public class Coleccion
    {
        [Key]
        public long id_coleccion { get; set; }
        public string nombre_coleccion { get; set; }

        public List<Libro> coleccion_con_libros { get; set; }

        public Coleccion(string nombre_coleccion, List<Libro> coleccion_con_libros)
        {
            this.nombre_coleccion = nombre_coleccion;
            this.coleccion_con_libros = coleccion_con_libros;
        }
        public Coleccion()
        {

        }
    }
    public class Acceso
    {
        [Key]
        public long id_acceso { get; set; }
        public string codigo_acceso { get; set; }
        public string descripcion_acceso { get; set; }

        public List<Usuario>? usuarios_con_acesso { get; set; }

        public Acceso(string codigo_acceso, string descipcion_acceso)
        {
            this.codigo_acceso = codigo_acceso;
            this.descripcion_acceso = descipcion_acceso;
        }
        public Acceso()
        {

        }
    }

    public class Usuario
    {
        [Key]
        public long id_usuario { get; set; }
        public string dni_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string tlf_usuario { get; set; }
        public string email_usuario { get; set; }
        public string clave_usuario { get; set; }

        public long id_acceso { get; set; }
        [ForeignKey("id_acceso")]
        public Acceso acceso { get; set; }
        public bool estaBloqueado_usuario { get; set; }
        public DateTime fch_fin_bloqueo_usuario { get; set; }
        public DateTime fch_alta_usuario { get; set; }
        public DateTime fch_baja_usuario { get; set; }

        public List<Prestamo>? prestamos_de_usuario{ get; set; }

        public Usuario(string dni_usuario, string nombre_usuario, string apellidos_usuario, string tlf_usuario, string email_usuario, string clave_usuario,long id_acceso, bool estaBloqueado_usuario, DateTime fch_fin_bloqueo_usuario, DateTime fch_alta_usuario, DateTime fch_baja_usuario)
        {
            this.dni_usuario = dni_usuario;
            this.nombre_usuario = nombre_usuario;
            this.apellidos_usuario = apellidos_usuario;
            this.tlf_usuario = tlf_usuario;
            this.email_usuario = email_usuario;
            this.clave_usuario = clave_usuario;
            this.id_acceso = id_acceso;
            this.estaBloqueado_usuario = estaBloqueado_usuario;
            this.fch_fin_bloqueo_usuario = fch_fin_bloqueo_usuario;
            this.fch_alta_usuario = fch_alta_usuario;
            this.fch_baja_usuario = fch_baja_usuario;
        }
        public Usuario()
        {

        }
    }
    public class Prestamo
    {
        [Key]
        public long id_prestamo { get; set; }

        public long id_usuario { get; set; }
        [ForeignKey("id_usuario")]
        public Usuario usuario { get; set; }

        public DateTime fch_inicio_prestamo { get; set; }
        public DateTime fch_fin_prestamo { get; set; }
        public DateTime fch_entrega_prestamo { get; set; }
        public long id_estado_prestamo { get; set; }

        [ForeignKey("id_estado_prestamo")]
        public Estado_Prestamo estadoConPrestamo { get; set; }

        public List<Libro> libros_de_prestamo { get; set; }

        public Prestamo(Usuario usuario, DateTime fch_inicio_prestamo, DateTime fch_fin_prestamo, DateTime fch_entrega_prestamo, long id_estado_prestamo, Estado_Prestamo estadoConPrestamo, List<Libro> libros_de_prestamo)
        {
            this.usuario = usuario;
            this.fch_inicio_prestamo = fch_inicio_prestamo;
            this.fch_fin_prestamo = fch_fin_prestamo;
            this.fch_entrega_prestamo = fch_entrega_prestamo;
            this.id_estado_prestamo = id_estado_prestamo;
            this.estadoConPrestamo = estadoConPrestamo;
            this.libros_de_prestamo = libros_de_prestamo;
        }
        public Prestamo()
        {

        }
    }
    public class Estado_Prestamo
    {
        [Key]
        public long id_estado_prestamo { get; set; }
        public string codigo_estado_prestamo { get; set; }
        public string descripcion_estado_prestamo { get; set; }

        public List<Prestamo> prestamos_con_estado { get; set; }

        public Estado_Prestamo(string codigo_estado_prestamo, string descripcion_estado_prestamo, List<Prestamo> prestamos_con_estado)
        {
            this.codigo_estado_prestamo = codigo_estado_prestamo;
            this.descripcion_estado_prestamo = descripcion_estado_prestamo;
            this.prestamos_con_estado = prestamos_con_estado;
        }
        public Estado_Prestamo()
        {

        }
    }

    /*public class Rel_Prestamo_Libro
    {
        [Key]
        public long id_rel_prestamo_libro { get; set; }

        public long id_prestamo { get; set; }
        [ForeignKey("id_prestamo")]
        Prestamo prestamo { get; set; }

        public long id_libro { get; set; }
        [ForeignKey("id_libro")]
        Libro libro { get; set; }
    }*/
}

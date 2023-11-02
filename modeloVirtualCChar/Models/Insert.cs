using DB;
using System;

public class Insert
{
    public gestorBibliotecaContext gb;

    public Insert(gestorBibliotecaContext gestorBibliotecaContext)
    {
        this.gb=gestorBibliotecaContext;
    }

    public void insertarAutor(Autor a)
    {
        this.gb.Autores.Add(a);
        this.gb.SaveChanges();
    }
    public void insertarLibro(Libro libro)
    {
        this.gb.Libros.Add(libro);
        this.gb.SaveChanges();
    }
    public void insertarEditorial(Editorial editorial)
    {
        this.gb.Editoriales.Add(editorial);
        this.gb.SaveChanges();
    }
    public void insertarGenero(Genero genero)
    {
        this.gb.Generos.Add(genero);
        this.gb.SaveChanges();
    }
    public void insertarColeccion(Coleccion coleccion)
    {
        this.gb.Colecciones.Add(coleccion);
        this.gb.SaveChanges();
    }
    public void insertarAcceso(Acceso acceso)
    {
        this.gb.Accesos.Add(acceso);
        this.gb.SaveChanges();
    }
    public void insertarUsuario(Usuario usuario)
    {
        this.gb.Usuarios.Add(usuario);
        this.gb.SaveChanges();
    }
    public void insertarPrestamo(Prestamo prestamo)
    {
        this.gb.Prestamos.Add(prestamo);
        this.gb.SaveChanges();
    }
    public void insertarEstadoPrestamo(Estado_Prestamo estadoPrestamo)
    {
        this.gb.Estados_Prestamos.Add(estadoPrestamo);
        this.gb.SaveChanges();
    }
}

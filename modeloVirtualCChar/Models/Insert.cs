using DB;
using System;

public class Insert
{
    public gestorBibliotecaContext gb;

    public Insert(gestorBibliotecaContext gestorBibliotecaContext)
    {
        this.gb=gestorBibliotecaContext;
    }

    public void insertarAutor(Autor autor)
    {
        this.gb.Autores.Add(autor);
    }
    public void insertarLibro(Libro libro)
    {
        this.gb.Libros.Add(libro);
    }
    public void insertarEditorial(Editorial editorial)
    {
        this.gb.Editoriales.Add(editorial);
    }
    public void insertarGenero(Genero genero)
    {
        this.gb.Generos.Add(genero);
    }
    public void insertarColeccion(Coleccion coleccion)
    {
        this.gb.Colecciones.Add(coleccion);
    }
    public void insertarAcceso(Acceso acceso)
    {
        this.gb.Accesos.Add(acceso);
    }
    public void insertarUsuario(Usuario usuario)
    {
        this.gb.Usuarios.Add(usuario);
    }
    public void insertarPrestamo(Prestamo prestamo)
    {
        this.gb.Prestamos.Add(prestamo);
    }
    public void insertarEstadoPrestamo(Estado_Prestamo estadoPrestamo)
    {
        this.gb.Estados_Prestamos.Add(estadoPrestamo);
    }
}

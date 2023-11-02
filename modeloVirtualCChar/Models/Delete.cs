using DB;
using System;

public class Delete
{
    public gestorBibliotecaContext gb;

    public Delete(gestorBibliotecaContext gestorBibliotecaContext)
    {
        this.gb = gestorBibliotecaContext;
    }
    public void borrarAutor(Autor autor)
    {
        this.gb.Autores.Remove(autor);
    }
    public void borrarLibro(Libro libro)
    {
        this.gb.Libros.Remove(libro);
    }
    public void borrarEditorial(Editorial editorial)
    {
        this.gb.Editoriales.Remove(editorial);
    }
    public void borrarGenero(Genero genero)
    {
        this.gb.Generos.Remove(genero);
    }
    public void borrarColeccion(Coleccion coleccion)
    {
        this.gb.Colecciones.Remove(coleccion);
    }
    public void borrarAcceso(Acceso acceso)
    {
        this.gb.Accesos.Remove(acceso);
    }
    public void borrarUsuario(Usuario usuario)
    {
        this.gb.Usuarios.Remove(usuario);
    }
    public void borrarPrestamo(Prestamo prestamo)
    {
        this.gb.Prestamos.Remove(prestamo);
    }
    public void borrarEstadoPrestamo(Estado_Prestamo estadoPrestamo)
    {
        this.gb.Estados_Prestamos.Remove(estadoPrestamo);
    }
}

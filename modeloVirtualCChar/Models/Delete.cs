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
        this.gb.delete(autor);
    }
    public void borrarRelacionAutoresLibros(Rel_Autores_Libros relacion)
    {
        this.gb.delete(relacion);
    }
    public void borrarLibro(Libro libro)
    {
        this.gb.delete(libro);
    }
    public void borrarEditorial(Editorial editorial)
    {
        this.gb.delete(editorial);
    }
    public void borrarGenero(Genero genero)
    {
        this.gb.delete(genero);
    }
    public void borrarColeccion(Coleccion coleccion)
    {
        this.gb.delete(coleccion);
    }
    public void borrarAcceso(Acceso acceso)
    {
        this.gb.delete(acceso);
    }
    public void borrarUsuario(Usuario usuario)
    {
        this.gb.delete(usuario);
    }
    public void borrarPrestamo(Prestamo prestamo)
    {
        this.gb.delete(prestamo);
    }
    public void borrarEstadoPrestamo(Estado_Prestamo estadoPrestamo)
    {
        this.gb.delete(estadoPrestamo);
    }
    public void borrarRelacionPrestamoLibro(Rel_Prestamo_Libro relacion)
    {
        this.gb.delete(relacion);
    }

}

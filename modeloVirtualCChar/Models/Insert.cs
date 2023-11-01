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
        this.gb.insert(a);
    }
    public void insertarRelacionAutoresLibros(Rel_Autores_Libros relacion)
    {
        this.gb.insert(relacion);
    }
    public void insertarLibro(Libro libro)
    {
        this.gb.insert(libro);
    }
    public void insertarEditorial(Editorial editorial)
    {
        this.gb.insert(editorial);
    }
    public void insertarGenero(Genero genero)
    {
        this.gb.insert(genero);
    }
    public void insertarColeccion(Coleccion coleccion)
    {
        this.gb.insert(coleccion);
    }
    public void insertarAcceso(Acceso acceso)
    {
        this.gb.insert(acceso);
    }
    public void insertarUsuario(Usuario usuario)
    {
        this.gb.insert(usuario);
    }
    public void insertarPrestamo(Prestamo prestamo)
    {
        this.gb.insert(prestamo);
    }
    public void insertarEstadoPrestamo(Estado_Prestamo estadoPrestamo)
    {
        this.gb.insert(estadoPrestamo);
    }
    public void insertarRelacionPrestamoLibro(Rel_Prestamo_Libro relacion)
    {
        this.gb.insert(relacion);
    }



}

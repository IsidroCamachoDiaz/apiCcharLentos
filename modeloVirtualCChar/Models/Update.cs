using DB;
using System;

public class Update { 

    public gestorBibliotecaContext gb;
    public Update(gestorBibliotecaContext gestorBibliotecaContext)
    {
        this.gb = gestorBibliotecaContext;
    }

    public void actualizarAutor(Autor a)
    {
        this.gb.Autores.Update(a);
    }
    public void actualizarLibro(Libro libro)
    {
        this.gb.Libros.Update(libro);
    }
    public void actualizarEditorial(Editorial editorial)
    {
        this.gb.Editoriales.Update(editorial);
    }
    public void actualizarGenero(Genero genero)
    {
        this.gb.Generos.Update(genero);
    }
    public void actualizarColeccion(Coleccion coleccion)
    {
        this.gb.Colecciones.Update(coleccion);
    }
    public void actualizarAcceso(Acceso acceso)
    {
        this.gb.Accesos.Update(acceso);
    }
    public void actualizarUsuario(Usuario usuario)
    {
        this.gb.Usuarios.Update(usuario);
    }
    public void actualizarPrestamo(Prestamo prestamo)
    {
        this.gb.Prestamos.Update(prestamo);
    }
    public void actualizarEstadoPrestamo(Estado_Prestamo estadoPrestamo)
    {
        this.gb.Estados_Prestamos.Update(estadoPrestamo);
    }


}

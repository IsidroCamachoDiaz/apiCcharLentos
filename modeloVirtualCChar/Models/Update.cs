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
        this.gb.SaveChanges();
    }
    public void actualizarLibro(Libro libro)
    {
        this.gb.Libros.Update(libro);
        this.gb.SaveChanges();
    }
    public void actualizarEditorial(Editorial editorial)
    {
        this.gb.Editoriales.Update(editorial);
        this.gb.SaveChanges();
    }
    public void actualizarGenero(Genero genero)
    {
        this.gb.Generos.Update(genero);
        this.gb.SaveChanges();
    }
    public void actualizarColeccion(Coleccion coleccion)
    {
        this.gb.Colecciones.Update(coleccion);
        this.gb.SaveChanges();
    }
    public void actualizarAcceso(Acceso acceso)
    {
        this.gb.Accesos.Update(acceso);
        this.gb.SaveChanges();
    }
    public void actualizarUsuario(Usuario usuario)
    {
        this.gb.Usuarios.Update(usuario);
        this.gb.SaveChanges();
    }
    public void actualizarPrestamo(Prestamo prestamo)
    {
        this.gb.Prestamos.Update(prestamo);
        this.gb.SaveChanges();
    }
    public void actualizarEstadoPrestamo(Estado_Prestamo estadoPrestamo)
    {
        this.gb.Estados_Prestamos.Update(estadoPrestamo);
        this.gb.SaveChanges();
    }


}

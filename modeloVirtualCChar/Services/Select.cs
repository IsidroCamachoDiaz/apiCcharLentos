using DB;
using Microsoft.EntityFrameworkCore;
using System;

public class Select
{
    public DB.GestorBibliotecaContext gb;

    public Select(GestorBibliotecaContext gestorBibliotecaContext)
    {
        this.gb = gestorBibliotecaContext;
    }

    public List <Autor> seleccionarAutor()
    {
        return this.gb.Autores.ToList();
    }
    public List <Libro> seleccionarLibro()
    {
        return this.gb.Libros.ToList();
    }
    public List <Editorial> seleccionarEditorial()
    {
        return this.gb.Editoriales.ToList();
    }
    public List<Genero> seleccionarGenero()
    {
        return this.gb.Generos.ToList();
    }
    public List<Coleccion> seleccionarColeccion()
    {
        return this.gb.Colecciones.ToList();
    }
    public List<Libro> seleccionarAcceso()
    {
        return this.gb.Libros.ToList();
    }
    public List<Usuario> seleccionarUsuario()
    {
        return this.gb.Usuarios.ToList();
    }
    public List<Prestamo> seleccionarPrestamo()
    {
        return this.gb.Prestamos.ToList();

    }
    public List<Estado_Prestamo> seleccionarEstadoPrestamo()
    {
        return this.gb.Estados_Prestamos.ToList();
       
    }
    public Autor seleccionarAutor(long id)
    {
        return this.gb.Autores.Find(id);
    }
    public Libro SeleccionarLibro(long id)
    {
            return gb.Libros.Find(id);
    }
    public Editorial SeleccionarEditorial(long id)
    {
            return gb.Editoriales.Find(id);
    }
    public Genero SeleccionarGenero(long id)
    {
            return gb.Generos.Find(id);
    }
    public Usuario SeleccionarUsuario(long id)
    {
            return gb.Usuarios.Find(id);
    }
    public Prestamo SeleccionarPrestamo(long id)
    {
            return gb.Prestamos.Find(id);
    }
    public Estado_Prestamo SeleccionarEstadoPrestamo(long id)
    {

            return gb.Estados_Prestamos.Find(id);
    }
    public Coleccion SeleccionarColeccion(long id)
    {
            return gb.Colecciones.Find(id);
    }
    public Acceso SeleccionarAcceso(long id)
    {

            return gb.Accesos.Find(id);
    }
}

using DB;
using Microsoft.EntityFrameworkCore;
using System;

public class Select
{
    public DB.gestorBibliotecaContext gb;

    public Select(gestorBibliotecaContext gestorBibliotecaContext)
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

    public Autor SeleccionarAutor(string o)
    {
            return this.gb.Autores.FirstOrDefault(a => a.id_autor.ToString == o);

    }



}

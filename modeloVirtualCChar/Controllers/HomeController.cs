using DB;
using Microsoft.AspNetCore.Mvc;
using modeloVirtualCChar.Models;
using System.Diagnostics;

namespace modeloVirtualCChar.Controllers
{
    public class HomeController : Controller
    {
        private readonly GestorBibliotecaContext contexto;

        public HomeController(GestorBibliotecaContext contexto)
        {
            this.contexto = contexto;
            /*Autor a = new Autor("Adolf", "Hitler", new List<Libro>());

            Insert i = new Insert(contexto);
            Genero g = new Genero("Contitucional","Hostoria",new List<Libro> ());
            Editorial ed = new Editorial("Editorial Nazi",new List<Libro>());
            Coleccion co = new Coleccion("Quien es Hitler?",new List<Libro>());
            Libro l = new Libro("urifgefguibj","Asi fur Hitler","2",10,ed,g,co,new List<Autor>(),new List<Prestamo>());
            a.libros_con_autor.Add(l);
            g.genero_con_libros.Add(l);
            ed.editorial_con_libros.Add (l);
            co.coleccion_con_libros.Add(l);
            i.insertarAutor(a);
            i.insertarGenero(g);
            i.insertarEditorial(ed);
            i.insertarColeccion(co);
            i.insertarLibro(l);
            contexto.SaveChanges();*/
            /*Select s = new Select(contexto);
            List <Autor> autores=s.seleccionarAutor(); 
            for(int i = 0; i < autores.Count; i++)
            {
                Console.WriteLine(autores[i].id_autor+" " + autores[i].nombre_autor+" " + autores[i].apellidos_autor);
            }*/

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
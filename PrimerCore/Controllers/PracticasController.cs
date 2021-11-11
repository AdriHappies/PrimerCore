using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class PracticasController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult EjemploColecciones()
        {
            List<Comic> listacomics = new List<Comic>();
            Comic comic = new Comic();
            comic.Nombre = "Naruto";
            comic.Descripcion = "Ninjas";
            comic.Imagen = "https://www.formulatv.com/images/series/posters/100/135/dest_1.jpg";
            listacomics.Add(comic);
            Comic comic2 = new Comic();
            comic2.Nombre = "Batman";
            comic2.Descripcion = "Hombre murcielago";
            comic2.Imagen = "https://www.normaeditorial.com/upload/media/albumes/0001/07/thumb_6662_albumes_big.jpeg";
            listacomics.Add(comic2);
            return View(listacomics);
        }
    }
}

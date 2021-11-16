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
        //esto es un get
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

        public IActionResult SumarNumerosGet()
        {
            ViewBag.Num1 = 2;
            ViewBag.Num2 = 7;
            ViewBag.Suma = ViewBag.Num1 + ViewBag.Num2;
            return View();
        }
        public IActionResult SumarNumerosPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SumarNumerosPost(int num1, int num2)
        {
            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;
            ViewBag.Suma = num1 + num2;
            return View();
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TablaMultiplicar(int num)
        {
            List<FilaTabla> listafilas = new List<FilaTabla>();
            for (int i = 1;i <= 10; i++)
            {
                FilaTabla fila = new FilaTabla();
                fila.Columna1 = num + " * " + i;
                fila.Columna2 = num * i;
                listafilas.Add(fila);
            }

            return View(listafilas);
        }
    }
}

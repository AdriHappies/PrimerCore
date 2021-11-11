using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class InformacionController : Controller
    {
        //usamos la lista index como un menu
        public IActionResult Index()
        {
            //aqui enviamos la info, antes del return
            return View();
        }

        public IActionResult InformacionControllerView()
        {
            ViewBag.Nombre = "Alumno";
            ViewData["Descripcion"] = "Estoy aprendiendo Net Core";
            ViewBag.Year = 2021;
            return View();
        }
        public IActionResult InformacionControllerViewModel()
        {
            List<Persona> listapersonas = new List<Persona>();
            for (int i = 1; i <= 10; i++)
            {
                Persona per = new Persona();
                per.Nombre = "Persona " + i;
                per.Edad = 20 + i;
                per.Email = "persona" + i + "@correo.com";
                listapersonas.Add(per);
            }
            //enviamos el modelo a la vista
            return View(listapersonas);
        }

        public IActionResult InformacionGetViewController(String nombre, int edad)
        {
            ViewBag.Nombre = nombre;
            ViewBag.Edad = edad;
            return View();
        }
        [HttpGet]
        public IActionResult InformacionPostViewController()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InformacionPostViewController(Persona persona)
        {
            
            return View(persona);
        }
    }
}

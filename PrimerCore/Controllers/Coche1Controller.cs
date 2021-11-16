using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class Coche1Controller : Controller
    {
        private Coche car;

        public Coche1Controller()
        {
            this.car = new Coche();
            this.car.Marca = "VolksWagen";
            this.car.Modelo = "Escarabajo";
            this.car.Imagen = "VWEscarabajo.jpg";
            this.car.Velocidad = 0;
            this.car.VelocidadMaxima = 150;
        }
        public IActionResult Index()
        {
            return View(this.car);
        }
        [HttpPost]
        public IActionResult Index(string accion)
        {
            if(accion == "acelerar")
            {
                this.car.Acelerar();
            }
            else
            {
                this.car.Frenar();
            }
            return View(this.car);
        }
    }
}

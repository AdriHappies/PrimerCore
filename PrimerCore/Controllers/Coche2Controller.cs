using Microsoft.AspNetCore.Mvc;
using PrimerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class Coche2Controller : Controller
    {
        private Coche car;
        public Coche2Controller()
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
    }
}

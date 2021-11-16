using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerCore.Controllers
{
    public class MatematicasController : Controller
    {
        private List<int> GetNumerosRandom()
        {
            List<int> numeros = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 7; i++)
            {
                int num = random.Next(1, 100);
                numeros.Add(num);
            }
            return numeros;
        }

        private List<int> GetNumerosCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            numeros.Add(numero);
            while (numero != 1)
            {
                if(numero%2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            return numeros;
        }

        public IActionResult ConjeturaCollatz()
        {
            List<int> aleatorios = this.GetNumerosRandom();
            ViewBag.Random = aleatorios;
            return View();
        }
        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> collatz = this.GetNumerosCollatz(numero);
            List<int> aleatorios = this.GetNumerosRandom();
            ViewBag.Random = aleatorios;
            return View(collatz);
        }
    }
}

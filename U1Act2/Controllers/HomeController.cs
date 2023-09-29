using Microsoft.AspNetCore.Mvc;

namespace U1Act2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string Moneda, decimal Cantidad)
        {
            if (Moneda == "Dolar")
            {
                decimal Resultado = Cantidad / 17;
                return View(Resultado);
            }
            else
            {
                decimal Resultado = 17 * Cantidad;
                return View(Resultado);
            }
           
        }
    }
}

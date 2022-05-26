using _1semana.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1semana.Controllers
{
    public class MonedaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Calcular(Moneda objCalculadora)
        {
            

            if ("Peso".Equals(objCalculadora.Accion))
            {
                if ("Dolar".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.Respuesta = (float)(objCalculadora.Operador1 * 0.018);
                }
                if ("Euro".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.Respuesta = (float)(objCalculadora.Operador1 * 0.017);
                }
                if ("Peso".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.fake = "Esta operacion no es valida";
                }

            }

            if ("Dolar".Equals(objCalculadora.Accion))
            {
                if ("Peso".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.Respuesta = (float)(objCalculadora.Operador1 * 54.94);
                }

                if ("Euro".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.Respuesta = (float)(objCalculadora.Operador1 * 0.93);
                }

                if ("Dolar".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.fake = "Esta operacion no es valida";
                }

            }

            if ("Euro".Equals(objCalculadora.Accion))
            {
                if ("Dolar".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.Respuesta = (float)(objCalculadora.Operador1 * 1.07);
                }

                if ("Peso".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.Respuesta = (float)(objCalculadora.Operador1 * 58.78);
                }
                if ("Euro".Equals(objCalculadora.Accion2))
                {
                    objCalculadora.fake = "Esta operacion no es valida";
                }

            }

                if ("-".Equals(objCalculadora.Accion))
            {
                /* objCalculadora.Respuesta = objCalculadora.Operador1 - objCalculadora.Operador2; */
            }
            if ("/".Equals(objCalculadora.Accion))
            {
                /* objCalculadora.Respuesta = objCalculadora.Operador1 / objCalculadora.Operador2; */
            }
            if ("*".Equals(objCalculadora.Accion))
            {
                /* objCalculadora.Respuesta = objCalculadora.Operador1 * objCalculadora.Operador2; */
            }

            return View("index", objCalculadora);

        }

    }
}

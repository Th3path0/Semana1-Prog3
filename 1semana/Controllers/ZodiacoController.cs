using _1semana.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1semana.Controllers
{
    public class ZodiacoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Calcular(Zodiaco objCalculadora)
        {
            if ("Enero".Equals(objCalculadora.Operador2))
            {
                if (objCalculadora.Accion >= 19)
                {
                    objCalculadora.Respuesta = "Capricornio";
                }
                else
                {
                    objCalculadora.Respuesta = "Sagitario";
                }
                
            }

            if ("Febrero".Equals(objCalculadora.Operador2))
            {
                if (objCalculadora.Accion <= 15)
                {
                    objCalculadora.Respuesta = "Capricornio";
                }
                else
                {
                    objCalculadora.Respuesta = "Acuario";
                }
                if (objCalculadora.Accion >= 29)
                {
                    objCalculadora.Respuesta = "Creo que se ha equivocado";
                }

            }

            if ("Marzo".Equals(objCalculadora.Operador2))
            {
                if (objCalculadora.Accion <= 11)
                {
                    objCalculadora.Respuesta = "Acuario";
                }
                else
                {
                    objCalculadora.Respuesta = "Piscis";
                }
            }

                if ("Abril".Equals(objCalculadora.Operador2))
                {
                    if (objCalculadora.Accion <= 18)
                    {
                        objCalculadora.Respuesta = "Piscis";
                    }
                    else
                    {
                        objCalculadora.Respuesta = "Aries";
                    }
                if (objCalculadora.Accion >30)
                {
                    objCalculadora.Respuesta = "Creo que se ha equivocado";
                }

            }

                if ("Mayo".Equals(objCalculadora.Operador2))
                {
                    if (objCalculadora.Accion <= 13)
                    {
                        objCalculadora.Respuesta = "Aries";
                    }
                    else
                    {
                        objCalculadora.Respuesta = "Tauro";
                    }

                }

            if ("Junio".Equals(objCalculadora.Operador2))
            {
                if (objCalculadora.Accion <= 19)
                {
                    objCalculadora.Respuesta = "Tauro";
                }
                else
                {
                    objCalculadora.Respuesta = "Geminis";
                }
                if (objCalculadora.Accion > 30)
                {
                    objCalculadora.Respuesta = "Creo que se ha equivocado";
                }
            }

                    if ("Julio".Equals(objCalculadora.Operador2))
                    {
                        if (objCalculadora.Accion <= 20)
                        {
                            objCalculadora.Respuesta = "Geminis";
                        }
                        else
                        {
                            objCalculadora.Respuesta = "Cancer";
                        }

                    }

                    if ("Agosto".Equals(objCalculadora.Operador2))
                    {
                        if (objCalculadora.Accion <= 9)
                        {
                            objCalculadora.Respuesta = "Cancer";
                        }
                        else
                        {
                            objCalculadora.Respuesta = "Leo";
                        }

                    }

                    if ("Septiembre".Equals(objCalculadora.Operador2))
                    {
                        if (objCalculadora.Accion <= 15)
                        {
                            objCalculadora.Respuesta = "Leo";
                        }
                        else
                        {
                            objCalculadora.Respuesta = "Virgo";
                        }
                if (objCalculadora.Accion > 30)
                {
                    objCalculadora.Respuesta = "Creo que se ha equivocado";
                }

            }

                    if ("Octubre".Equals(objCalculadora.Operador2))
                    {
                        if (objCalculadora.Accion <= 30)
                        {
                            objCalculadora.Respuesta = "Virgo";
                        }
                        else
                        {
                            objCalculadora.Respuesta = "Libra";
                        }

                    }

                    if ("Noviembre".Equals(objCalculadora.Operador2))
                    {
                        if (objCalculadora.Accion <= 22)
                        {
                            objCalculadora.Respuesta = "Libra";
                        }
                        else
                        {
                            objCalculadora.Respuesta = "Escorpio";
                        }
                if (objCalculadora.Accion > 30)
                {
                    objCalculadora.Respuesta = "Creo que se ha equivocado";
                }

            }

                    if ("Diciembre".Equals(objCalculadora.Operador2))
                    {
                        if (objCalculadora.Accion <= 17)
                        {
                            objCalculadora.Respuesta = "Escorpio";
                        }
                        else
                        {
                            objCalculadora.Respuesta = "Sagitario";
                        }

                    }


                

            

            return View("index", objCalculadora);

        }

    }
}

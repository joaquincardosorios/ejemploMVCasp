using Microsoft.AspNetCore.Mvc;

namespace prueba1.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sumar(double? txtnum1, double? txtnum2)
        {
            if (HttpContext.Request.Method == "POST")
            {
				if (!txtnum1.HasValue || !txtnum2.HasValue)
				{
					ViewBag.Error = "La expresion no es valida, intente con 2 numeros";

					return View();
				}

				double suma = txtnum1.Value + txtnum2.Value;
				ViewBag.num1 = txtnum1.Value;
				ViewBag.num2 = txtnum2.Value;
				ViewBag.Suma = suma;
			}

            return View();
        }

        public IActionResult Restar(double? txtnum1, double? txtnum2)
        {
			if (HttpContext.Request.Method == "POST")
			{
				if (!txtnum1.HasValue || !txtnum2.HasValue)
				{
					ViewBag.Error = "La expresion no es valida, intente con 2 numeros";

					return View();
				}

				double resta = txtnum1.Value - txtnum2.Value;
				ViewBag.num1 = txtnum1.Value;
				ViewBag.num2 = txtnum2.Value;
				ViewBag.Resta = resta;
			}

			return View();
		}

        public IActionResult Multiplicar(double? txtnum1, double? txtnum2)
        {
			if (HttpContext.Request.Method == "POST")
			{
				if (!txtnum1.HasValue || !txtnum2.HasValue)
				{
					ViewBag.Error = "La expresion no es valida, intente con 2 numeros";

					return View();
				}

				double multiplicacion = txtnum1.Value * txtnum2.Value;
				ViewBag.num1 = txtnum1.Value;
				ViewBag.num2 = txtnum2.Value;
				ViewBag.Multiplicacion = multiplicacion;
			}

			return View();
		}

        public IActionResult Dividir(double? txtnum1, double? txtnum2)
        {
			if (HttpContext.Request.Method == "POST")
			{
				if (!txtnum1.HasValue || !txtnum2.HasValue)
				{
					ViewBag.Error = "La expresion no es valida, intente con 2 numeros";

					return View();
				}
				if (txtnum2.Value == 0)
				{
					ViewBag.Error = "No se puede dividir por cero";
					ViewBag.num1 = txtnum1.Value;
					ViewBag.num2 = txtnum2.Value;

					return View();
				}

				double division = txtnum1.Value / txtnum2.Value;
				ViewBag.num1 = txtnum1.Value;
				ViewBag.num2 = txtnum2.Value;
				ViewBag.Division = division;
			}

			return View();

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using prueba1.Models;

namespace prueba1.Controllers
{

	public class EmpleadoController1 : Controller
	{
		private static List<Empleado> _data = new List<Empleado>()
		{
			new Empleado{ Nombre = "Joaquin",
				Apellido = "Rios", Cargo = "Desarrollador"
			},
			new Empleado {Nombre = "Benito",
				Apellido = "Camelo", Cargo = "Senior"
			},
			new Empleado {Nombre = "Octavio",
				Apellido = "Gutierrez", Cargo = "Delegado"
			}
		};
		public IActionResult Index()
		{
			return View();
		}
	}
}

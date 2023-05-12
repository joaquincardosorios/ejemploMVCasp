using System.ComponentModel.DataAnnotations;

namespace prueba1.Models
{
	public class Empleado
	{
		//para generar el id aleatorio debemos agregarlo en el constructor 
		public Empleado()
		{
			Random rnd = new Random();
			this.Id = rnd.Next(1, 1000 + 1);
		}
		public int Id { get; set; }

		[Required(ErrorMessage = "El nombre es obligatorio")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El apellido es obligatorio")]
		public string Apellido { get; set; }

		[Required(ErrorMessage = "El cargo es obligatorio")]
		[MaxLength(20)]
		public string Cargo { get; set; }
	}
}

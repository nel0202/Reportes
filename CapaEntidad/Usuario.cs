using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class USUARIO
    {
		public int IdUsuario { get; set; }
		public string Nombre { get; set; }
		public string Correo { get; set; }
		public string Telefono { get; set; }
		public string UsuarioIngreso { get; set; }
		public DateTime FechaIngreso { get; set; }
		public string UsuarioModifico { get; set; }
		public DateTime FechaModifico { get; set; }
	}
}

using Proyecto_Limbo.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Limbo.Base_Datos
{
    public class Usuario
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string nombreUsu { get; set; }
        public string? descripcion {  get; set; }
        public string contrasenia { get; set; }
        public string tipo { get; set; }
        public int? grupo { get; set; }
        public int puntosReputacion { get; set; }
        public byte ban { get; set; }

    }
}

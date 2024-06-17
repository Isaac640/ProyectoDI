using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Limbo.Base_Datos
{
    public class Reportes_Publicaciones
    {
        public int idReportePublicacion {  get; set; }
        public int idPublicacion { get; set; }
        public int idUsuario { get; set; }
        public string tipo {  get; set; }
        public string razon {  get; set; }
    }
}

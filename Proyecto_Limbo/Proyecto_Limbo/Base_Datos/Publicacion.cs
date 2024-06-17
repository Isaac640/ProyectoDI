using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Limbo.Base_Datos
{
    public class Publicacion
    {
        public int id {  get; set; }
        public int idUsu { get; set; }
        public string texto { get; set; }
        public string adjuntoBase64 { get; set; }
        public int meGustas { get; set; }
    }
}

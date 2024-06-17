using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Limbo.Base_Datos
{
    public class Torneo
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int idGrupo { get; set; }
        public int participantes { get; set; }
        public string? premios { get; set; }
        public int? puntosRep { get; set; }
        public string? adjuntoImagen { get; set; }
        public string? adjuntoCondiciones { get; set; }
    }
}

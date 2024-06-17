using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Limbo.Base_Datos
{
    public class Historial_Ganadores
    {
        public int idParticipante {  get; set; }
        public int idTorneo { get; set; }
        public int? puntosRepGanados {  get; set; }
        public string premioGanado {  get; set; }
    }
}

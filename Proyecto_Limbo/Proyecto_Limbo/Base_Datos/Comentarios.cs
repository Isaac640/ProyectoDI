using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Limbo.Base_Datos
{
    public class Comentarios
    {
        public int idComentarios {  get; set; }
        public int idPublicacion {  get; set; }
        public string texto {  get; set; }
        public string? adjuntoUrl {  get; set; }
        public int idUsuario {  get; set; }
        public int? idRespuestaCom {  get; set; }
		public int meGustas {  get; set; }
    }
}

using Proyecto_Limbo.Base_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Limbo
{
    /// <summary>
    /// Clase para la obtención de datos desde una API.
    /// </summary>
    public class Administracion
    {
        private static WebConsumer consumer;

        /// <summary>
        /// Constructor estático que inicializa el consumidor web con la URL base de la API.
        /// </summary>
        static Administracion()
        {
            consumer = new WebConsumer("http://localhost:8080/limbo");
        }

        // Métodos para la obtención de datos desde la API

        /// <summary>
        /// Obtiene todas las incidencias desde la API.
        /// </summary>
        /// <returns>Una lista de incidencias.</returns>
        //public async static Task<List<Incidencias>> ObtenerIncidencias()
        //{
        //    return await consumer.GetAsyncIncidencias<List<Incidencias>>("/incidencias");
        //}

        /// <summary>
        /// Obtiene toda la lista de personal desde la API.
        /// </summary>
        /// <returns>Una lista de personal.</returns>
        /// 

        // -- Usuarios --

        public async static Task<List<Usuario>> ObtenerUsuarios()
        {
           return await consumer.GetAsyncUsuarios<List<Usuario>>("/usuarios");
        }

        public static Task<Usuario> ObtenerUsuarioByNombre(string usuario)
        {
            return consumer.GetAsyncUsuarioByNombreUsuario<Usuario>("/usuarios/", usuario);
        }

        public async static Task<Usuario> ObtenerUsuarioByID(long id)
        {
            return await consumer.GetAsyncUsuarioByID<Usuario>("/usuarios/", id);
        }

        // -- Grupos --

        public static Task<Grupo> ObtenerGrupoByNombre(string grupo)
        {
            return consumer.GetAsyncGrupoByNombreGrupo<Grupo>("/grupos/", grupo);
        }

        public static Task<Grupo> ObtenerGrupoByID(long id)
        {
            return consumer.GetAsyncGrupoByID<Grupo>("/grupos/grupo/", id);
        }

        // -- Publicaciones --

        public async static Task<List<Publicacion>> ObtenerPublicaciones()
        {
            return await consumer.GetAsyncPublicaciones<List<Publicacion>>("/publicaciones");
        }


        public async static Task<Publicacion> ObtenerPublicacionByID(long id)
        {
            return await consumer.GetAsyncPublicacionByID<Publicacion>("/publicaciones", id);
        }

        public async static Task<bool> BorrarPublicacion(int id)
        {
            bool resultado = await consumer.DeleteAsyncPublicacion("/publicaciones/", id);
            return resultado;
        }

        public async static Task<bool> BanearUsuarioPublicacion(Usuario usu)
        {
            bool resultado = await consumer.PutBanUserAsync("/publicaciones/ban", usu.id, usu);
            return resultado;
        }

        // -- Torneos --

        public async static Task<List<Torneo>> ObtenerTorneos()
        {
            return await consumer.GetAsyncTorneos<List<Torneo>>("/torneos/");
        }


        public async static Task<Torneo> ObtenerTorneoByID(long id)
        {
            return await consumer.GetAsyncTorneoByID<Torneo>("/torneos/torneo", id);
        }

        public async static Task<bool> BorrarTorneo(int id)
        {
            bool resultado = await consumer.DeleteAsyncTorneo("/torneos/", id);
            return resultado;
        }

        public async static Task<bool> PublicarTorneo(Torneo tor)
        {
            return await consumer.PostAsyncPublicarTorneo(tor);
        }

        // -- Historial Torneos --

        public async static Task<List<Historial_Ganadores>> ObtenerGanadores()
        {
            return await consumer.GetAsyncGanadores<List<Historial_Ganadores>>("/historialGanadores/ganadores");
        }


        public async static Task<Historial_Ganadores> ObtenerGanadorByID(long id)
        {
            return await consumer.GetAsyncGanadorByID<Historial_Ganadores>("/historialGanadores/ganador", id);
        }

        public async static Task<bool> BorrarHistorialTorneo(int id)
        {
            bool resultado = await consumer.DeleteAsyncTorneo("/historialGanadores/ganadores/", id);
            return resultado;
        }

        // -- Reportes Publicacion --

        public async static Task<List<Reportes_Publicaciones>> ObtenerReportesPublicaciones()
        {
            return await consumer.GetAsyncReportesPublicacion<List<Reportes_Publicaciones>>("/reportes_publicacion");
        }


        public async static Task<Reportes_Publicaciones> ObtenerReportePubByID(long id)
        {
            return await consumer.GetAsyncReportePublicacionByID<Reportes_Publicaciones>("/reportes_publicacion/reporte_publicacion", id);
        }

        public async static Task<bool> BorrarReportePublicacion(int id)
        {
            bool resultado = await consumer.DeleteAsyncReportePublicacion("/reportes_publicacion/", id);
            return resultado;
        }

        // -- Reportes Comentarios --

        public async static Task<List<Reportes_Comentarios>> ObtenerReportesComentarios()
        {
            return await consumer.GetAsyncReportesComentario<List<Reportes_Publicaciones>>("/reportes_comentario");
        }


        public async static Task<Reportes_Comentarios> ObtenerReporteComByID(long id)
        {
            return await consumer.GetAsyncReporteComentarioByID<Reportes_Publicaciones>("/reportes_comentario/reporte_comentario", id);
        }

        public async static Task<bool> BorrarReporteComentario(int id)
        {
            bool resultado = await consumer.DeleteAsyncReporteComentario("/reportes_comentario/", id);
            return resultado;
        }

        // -- Comentarios --

        public async static Task<List<Comentarios>> ObtenerComentarios()
        {
            return await consumer.GetAsyncComentarios<List<Comentarios>>("/comentarios");
        }


        public async static Task<Comentarios> ObtenerComentarioByID(long id)
        {
            return await consumer.GetAsyncComentarioByID<Comentarios>("/comentarios/", id);
        }

        public async static Task<bool> BorrarComentario(int id)
        {
            bool resultado = await consumer.DeleteAsyncComentario("/comentarios/", id);
            return resultado;
        }

        /// <summary>
        /// Obtiene los comentarios asociados a una incidencia por su ID.
        /// </summary>
        /// <param name="id">El ID de la incidencia.</param>
        /// <returns>Una lista de comentarios.</returns>
        //public async static Task<List<Comentarios>> ObtenerComentariosByIncidenciasId(long id)
        //{
        //    //return await consumer.GetAsyncComentariosList<List<Comentarios>>("/comentarios/incidencia", id);
        //}

        /// <summary>
        /// Publica un comentario en la API.
        /// </summary>
        /// <param name="com">El comentario a publicar.</param>
        /// <returns>True si se publica correctamente, false en caso contrario.</returns>
        //public async static Task<bool> PublicarComentario(Comentarios com)
        //{
        //    return await consumer.PostAsyncComentario(com);
        //}

        /// <summary>
        /// Publica un comentario en la API.
        /// </summary>
        /// <param name="com">El comentario a publicar.</param>
        /// <returns>True si se publica correctamente, false en caso contrario.</returns>
        //public async static Task<bool> EnviarIncidencia(Incidencias_Sin inc)
        //{
        //return await consumer.PostAsyncIncidencia(inc);
        //}

        /// <summary>
        /// Actualiza los datos de un personal en la API.
        /// </summary>
        /// <param name="per">Los datos del personal a actualizar.</param>
        /// <returns>True si se actualiza correctamente, false en caso contrario.</returns>
        // public async static Task<bool> ActualizarPersonal(Personal per)
        //{
        //    return await consumer.PutPersonalAsync("/personal", per.id, per);
        //}

        /// <summary>
        /// Elimina una incidencia de la API por su ID.
        /// </summary>
        /// <param name="id">El ID de la incidencia a eliminar.</param>
        /// <returns>True si se elimina correctamente, false en caso contrario.</returns>
        //public async static Task<bool> BorrarIncidencia(int id)
        //{
        //    bool resultado = await consumer.DeleteAsyncIncidencia("/incidencias", id);
        //    return resultado;
        //}
    }
}

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Forms;
using Proyecto_Limbo.Enumerados;
using Proyecto_Limbo.Base_Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;

namespace Proyecto_Limbo
{
    /// <summary>
    /// Clase para consumir una API web.
    /// </summary>
    public class WebConsumer
    {
        private string host;

        private HttpClient client;
        private JsonSerializerOptions serializerOptions;

        /// <summary>
        /// Constructor de la clase WebConsumer.
        /// </summary>
        /// <param name="host">La URL base del host de la API.</param>
        public WebConsumer(string host)
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters = { new JsonStringEnumConverter() }
            };

            this.host = host;
        }
        // Métodos para realizar peticiones GET a la API

        public async Task<Usuario> GetAsyncUsuarioByNombreUsuario<T>(string endpoint, string username)
        {
            string url = $"{endpoint}usuario/{username}"; // Ajusta endpoint_perfil al verdadero endpoint para obtener perfiles
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Usuario usuario = System.Text.Json.JsonSerializer.Deserialize<Usuario>(content, serializerOptions);
                return usuario;
            }
            else
            {
                MessageBox.Show($"Error al obtener el perfil para el usuario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public async Task<Usuario> GetAsyncUsuarioByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}usuario/id/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Usuario personal = System.Text.Json.JsonSerializer.Deserialize<Usuario>(content, serializerOptions);
                return personal;
            }
            else
            {
                MessageBox.Show($"Error al obtener el personal del usuario por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<List<Usuario>> GetAsyncUsuarios<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Usuario> usuarios = System.Text.Json.JsonSerializer.Deserialize<List<Usuario>>(content, serializerOptions);
                return usuarios;
            }
            else
            {
                MessageBox.Show($"Error al obtener los usuarios. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // -- Grupos --

        public async Task<Grupo> GetAsyncGrupoByNombreGrupo<T>(string endpoint, string nombre)
        {
            string url = $"{endpoint}grupo/nombre/{nombre}"; // Ajusta endpoint_perfil al verdadero endpoint para obtener perfiles
            HttpResponseMessage response = await client.GetAsync(host + url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Grupo grupo = System.Text.Json.JsonSerializer.Deserialize<Grupo>(content, serializerOptions);
                return grupo;
            }
            else
            {
                MessageBox.Show($"Error al obtener el perfil para el usuario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Grupo> GetAsyncGrupoByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}id/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Grupo grupo = System.Text.Json.JsonSerializer.Deserialize<Grupo>(content, serializerOptions);
                return grupo;
            }
            else
            {
                MessageBox.Show($"Error al obtener la publicacion por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // -- Publicaciones --

        public async Task<List<Publicacion>> GetAsyncPublicaciones<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Publicacion> publicaciones = System.Text.Json.JsonSerializer.Deserialize<List<Publicacion>>(content, serializerOptions);
                return publicaciones;
            }
            else
            {
                MessageBox.Show($"Error al obtener los usuarios. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Publicacion> GetAsyncPublicacionByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/publicacion/id/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Publicacion publicacion = System.Text.Json.JsonSerializer.Deserialize<Publicacion>(content, serializerOptions);
                return publicacion;
            }
            else
            {
                MessageBox.Show($"Error al obtener la publicacion por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> DeleteAsyncPublicacion(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}borrar/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar la publicacion. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la publicacion: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> PutBanUserAsync(string endpoint, long id, Usuario usuarioBan)
        {
            try
            {
                string jsonIncidencia = JsonConvert.SerializeObject(usuarioBan);
                string apiUrl = host + $"{endpoint}/{id}";

                string url = apiUrl.Replace("{id}", id.ToString());

                var request = new HttpRequestMessage(HttpMethod.Put, url);
                request.Content = new StringContent(jsonIncidencia, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al banear usuario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // -- Torneos --

        public async Task<List<Torneo>> GetAsyncTorneos<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Torneo> torneos = System.Text.Json.JsonSerializer.Deserialize<List<Torneo>>(content, serializerOptions);
                return torneos;
            }
            else
            {
                MessageBox.Show($"Error al obtener los torneos. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Torneo> GetAsyncTorneoByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/id/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Torneo torneo = System.Text.Json.JsonSerializer.Deserialize<Torneo>(content, serializerOptions);
                return torneo;
            }
            else
            {
                MessageBox.Show($"Error al obtener el personal del usuario por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> DeleteAsyncTorneo(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}borrar/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el torneo. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el torneo: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> PostAsyncPublicarTorneo(Torneo torneo)
        {
            try
            {
                // Serializar el objeto a JSON
                string json = JsonConvert.SerializeObject(torneo);

                // Crear un HttpClient

                // URL de tu API
                string url = "/torneos/crear";

                // Convertir el objeto JSON en un StringContent
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(host + url, content);

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al crear un torneo. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine($"Error al crear un torneo. Código de estado: {ex.Message}");
                return false;
            }
        }

        // -- Historial Ganadores --

        public async Task<List<Historial_Ganadores>> GetAsyncGanadores<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Historial_Ganadores> torneos = System.Text.Json.JsonSerializer.Deserialize<List<Historial_Ganadores>>(content, serializerOptions);
                return torneos;
            }
            else
            {
                MessageBox.Show($"Error al obtener los ganadores. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Historial_Ganadores> GetAsyncGanadorByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/idTorneo/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Historial_Ganadores torneo = System.Text.Json.JsonSerializer.Deserialize<Historial_Ganadores>(content, serializerOptions);
                return torneo;
            }
            else
            {
                MessageBox.Show($"Error al obtener el ganador por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> DeleteAsyncHistorialGanador(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}borrar/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el ganador. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el ganador: {ex.Message}");
                return false;
            }
        }

        // -- Reporte Publicacion --

        public async Task<List<Reportes_Publicaciones>> GetAsyncReportesPublicacion<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Reportes_Publicaciones> reportesPub = System.Text.Json.JsonSerializer.Deserialize<List<Reportes_Publicaciones>>(content, serializerOptions);
                return reportesPub;
            }
            else
            {
                MessageBox.Show($"Error al obtener los reportes de publicacion. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Reportes_Publicaciones> GetAsyncReportePublicacionByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/id/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Reportes_Publicaciones reporte = System.Text.Json.JsonSerializer.Deserialize<Reportes_Publicaciones>(content, serializerOptions);
                return reporte;
            }
            else
            {
                MessageBox.Show($"Error al obtener el reporte de publicacion por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> DeleteAsyncReportePublicacion(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}borrar/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el reporte. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el reporte: {ex.Message}");
                return false;
            }
        }

        // -- Reporte Comentario --

        public async Task<List<Reportes_Comentarios>> GetAsyncReportesComentario<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Reportes_Comentarios> reportesCom = System.Text.Json.JsonSerializer.Deserialize<List<Reportes_Comentarios>>(content, serializerOptions);
                return reportesCom;
            }
            else
            {
                MessageBox.Show($"Error al obtener los reportes de publicacion. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Reportes_Comentarios> GetAsyncReporteComentarioByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}/id/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Reportes_Comentarios reporteCom = System.Text.Json.JsonSerializer.Deserialize<Reportes_Comentarios>(content, serializerOptions);
                return reporteCom;
            }
            else
            {
                MessageBox.Show($"Error al obtener el reporte de publicacion por su ID. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<bool> DeleteAsyncReporteComentario(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}borrar/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el reporte. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el reporte: {ex.Message}");
                return false;
            }
        }

        // -- Comentarios --

        public async Task<List<Comentarios>> GetAsyncComentarios<T>(string endpoint)
        {
            string url = $"{endpoint}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                List<Comentarios> usuarios = System.Text.Json.JsonSerializer.Deserialize<List<Comentarios>>(content, serializerOptions);
                return usuarios;
            }
            else
            {
                MessageBox.Show($"Error al obtener los usuarios. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<Comentarios> GetAsyncComentarioByID<T>(string endpoint, long id)
        {
            string url = $"{endpoint}comentario/id/{id}";
            HttpResponseMessage response = await client.GetAsync(host + url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Comentarios personal = System.Text.Json.JsonSerializer.Deserialize<Comentarios>(content, serializerOptions);
                return personal;
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteAsyncComentario(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}borrar/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el comentario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el comentario: {ex.Message}");
                return false;
            }
        }


        // Métodos para realizar peticiones PUT a la API
        /*
        public async Task<bool> PutPersonalAsync(string endpoint, long id, Personal PersonalActualizado)
        {
            try
            {
                string jsonIncidencia = JsonConvert.SerializeObject(PersonalActualizado);
                string apiUrl = host + $"{endpoint}/{id}";

                string url = apiUrl.Replace("{id}", id.ToString());

                var request = new HttpRequestMessage(HttpMethod.Put, url);
                request.Content = new StringContent(jsonIncidencia, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al dar de baja. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        // Métodos para realizar peticiones POST a la API

        public async Task<bool> PostAsyncComentario(Comentarios comentario)
        {
            try
            {
                // Serializar el objeto a JSON
                string json = JsonConvert.SerializeObject(comentario);

                // Crear un HttpClient

                // URL de tu API
                string url = "/comentarios/guardarComentario";

                // Convertir el objeto JSON en un StringContent
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(host + url, content);

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al publicar un comentario. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine($"Error al publicar un comentario. Código de estado: {ex.Message}");
                return false;
            }
        }

        // Métodos para realizar peticiones DELETE a la API

        public async Task<bool> DeleteAsyncIncidencia(string endpoint, long id)
        {
            try
            {
                string url = $"{endpoint}/{id}";
                HttpResponseMessage response = await client.DeleteAsync(host + url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Error al eliminar la incidencia. Código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la incidencia: {ex.Message}");
                return false;
            }
        }*/


    }
}

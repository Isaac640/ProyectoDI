using Proyecto_Limbo.Base_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Proyecto_Limbo
{
    public partial class FrmPrincipal : Form
    {
        Timer timer;
        Usuario user;
        public FrmPrincipal(Usuario usu)
        {
            InitializeComponent();
            // Tiempo y dia
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            lblDay.Text = DateTime.UtcNow.ToLongDateString();

            user = usu;
            lblNombreApe.Text = this.user.nombre + " " + this.user.apellidos;
            lblUser.Text = this.user.nombreUsu;
            cargarUsuarios();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar la celda de la barra de estado con la fecha y hora actual
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private async void cargarUsuarios()
        {
            var lst = await Administracion.ObtenerUsuarios();

            if (lst != null)
            {
                modelarTabla(lst);
            }
        }

        /// <summary>
        /// Modela la tabla de incidencias con los datos proporcionados.
        /// </summary>
        /// <param name="lst">La lista de incidencias a mostrar.</param>
        private async void modelarTabla(List<Usuario> lst)
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.AutoGenerateColumns = false;

            // Crear columnas manualmente para el DataGridView

            DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "id";
            columnaID.HeaderText = "ID";

            DataGridViewTextBoxColumn columnaNombreUsuario = new DataGridViewTextBoxColumn();
            columnaNombreUsuario.DataPropertyName = "nombreUsu";
            columnaNombreUsuario.HeaderText = "Usuario";

            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.DataPropertyName = "nombre";
            columnaNombre.HeaderText = "Nombre";

            DataGridViewTextBoxColumn columnaApellidos = new DataGridViewTextBoxColumn();
            columnaApellidos.DataPropertyName = "apellidos";
            columnaApellidos.HeaderText = "Apellidos";

            DataGridViewTextBoxColumn columnaTipo = new DataGridViewTextBoxColumn();
            columnaTipo.DataPropertyName = "tipo";
            columnaTipo.HeaderText = "Tipo";

            DataGridViewTextBoxColumn columnaGrupo = new DataGridViewTextBoxColumn();
            columnaGrupo.DataPropertyName = "grupo"; // Corregido aquí
            columnaGrupo.HeaderText = "Grupo";

            DataGridViewTextBoxColumn columnaPuntos = new DataGridViewTextBoxColumn();
            columnaPuntos.HeaderText = "puntosReputacion";
            columnaPuntos.HeaderText = "Reputacion";
            // Agregar las columnas al DataGridView

            if (dgvUsuarios.Columns.Count < 7)
            {
                dgvUsuarios.Columns.Add(columnaID);
                dgvUsuarios.Columns.Add(columnaNombreUsuario);
                dgvUsuarios.Columns.Add(columnaNombre);
                dgvUsuarios.Columns.Add(columnaApellidos);
                dgvUsuarios.Columns.Add(columnaTipo);
                dgvUsuarios.Columns.Add(columnaGrupo);
                dgvUsuarios.Columns.Add(columnaPuntos);
            }
            // Asignar los datos a cada fila
            foreach (var responsable in lst)
            {
                if (responsable.id != null) // Verificar si responsable_id no es null
                {
                    // Obtener los detalles del personal por su ID
                    var personal = await Administracion.ObtenerUsuarioByID(responsable.id);
                    if (personal.ban != 1)
                    {
                        if (personal.grupo != null)
                        {
                            dgvUsuarios.Rows.Add(responsable.id, responsable.nombreUsu, responsable.nombre, responsable.apellidos, responsable.tipo, responsable.grupo, responsable.puntosReputacion);
                        }
                        else
                        {
                            // Manejar el caso donde no se puede encontrar el personal
                            dgvUsuarios.Rows.Add(responsable.id, responsable.nombreUsu, responsable.nombre, responsable.apellidos, responsable.tipo, "Sin Grupo", responsable.puntosReputacion);
                        }
                    }
                }
                else
                {
                    // Manejar el caso donde responsable_id es null
                    dgvUsuarios.Rows.Add("No se ha encontrado al personal");
                }
            }
            lblUserNumber.Text = "Usuarios: " + dgvUsuarios.RowCount.ToString();
        }

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            FrmListaTorneos torn = new FrmListaTorneos();
            torn.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes rep = new FrmReportes();
            rep.Show();
        }

        private void btnPublicaciones_Click(object sender, EventArgs e)
        {
            FrmPublicaciones pub = new FrmPublicaciones();
            pub.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
    }
}

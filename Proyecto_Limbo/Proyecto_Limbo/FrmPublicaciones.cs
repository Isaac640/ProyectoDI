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

namespace Proyecto_Limbo
{
    public partial class FrmPublicaciones : Form
    {
        public FrmPublicaciones()
        {
            InitializeComponent();
            cargarPublicaciones();
        }
        private async void cargarPublicaciones()
        {
            var lst = await Administracion.ObtenerPublicaciones();

            if (lst != null)
            {
                modelarTabla(lst);
            }
        }

        /// <summary>
        /// Modela la tabla de incidencias con los datos proporcionados.
        /// </summary>
        /// <param name="lst">La lista de incidencias a mostrar.</param>
        private async void modelarTabla(List<Publicacion> lst)
        {
            dgvPublicaciones.Rows.Clear();
            dgvPublicaciones.AutoGenerateColumns = false;

            // Crear columnas manualmente para el DataGridView

            DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "id";
            columnaID.HeaderText = "ID publicacion";

            DataGridViewTextBoxColumn columnaID_Usuario = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "idUsuario";
            columnaID.HeaderText = "Usuario";

            DataGridViewTextBoxColumn columnaTexto = new DataGridViewTextBoxColumn();
            columnaTexto.DataPropertyName = "texto";
            columnaTexto.HeaderText = "Texto";

            DataGridViewTextBoxColumn columnaAdjunto = new DataGridViewTextBoxColumn();
            columnaAdjunto.DataPropertyName = "adjuntoBase64";
            columnaAdjunto.HeaderText = "Adjunto";

            DataGridViewTextBoxColumn columnaMeGustas = new DataGridViewTextBoxColumn();
            columnaMeGustas.DataPropertyName = "meGustas";
            columnaMeGustas.HeaderText = "Me Gustas";

            // Agregar las columnas al DataGridView

            if (dgvPublicaciones.Columns.Count < 7)
            {
                dgvPublicaciones.Columns.Add(columnaID);
                dgvPublicaciones.Columns.Add(columnaID_Usuario);
                dgvPublicaciones.Columns.Add(columnaTexto);
                dgvPublicaciones.Columns.Add(columnaAdjunto);
                dgvPublicaciones.Columns.Add(columnaMeGustas);
            }
            // Asignar los datos a cada fila
            foreach (var responsable in lst)
            {
                if (responsable.id != null) // Verificar si responsable_id no es null
                {
                    Usuario user = await Administracion.ObtenerUsuarioByID(responsable.idUsu);
                    // Obtener los detalles del personal por su ID
                    var personal = await Administracion.ObtenerPublicacionByID(responsable.id);

                    if (personal.adjuntoBase64 != null)
                    {
                        dgvPublicaciones.Rows.Add(responsable.id, user.nombreUsu, responsable.texto, responsable.adjuntoBase64, responsable.meGustas);
                    }
                    else
                    {
                        // Manejar el caso donde no se puede encontrar el personal
                        dgvPublicaciones.Rows.Add(responsable.id, user.nombreUsu, responsable.texto, "Sin Adjunto", responsable.meGustas);
                    }
                }
                else
                {
                    // Manejar el caso donde responsable_id es null
                    dgvPublicaciones.Rows.Add("No se ha encontrado la publicacion");
                }
            }
            lblPostsNumber.Text = "Publicaciones: " + dgvPublicaciones.RowCount.ToString();
        }

        private async void tsmiBorrar_Click(object sender, EventArgs e)
        {
            if (dgvPublicaciones.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere eliminar esta publicacion?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvPublicaciones.CurrentRow.Cells[0].Value);
                    await Administracion.BorrarPublicacion(id);
                    await Task.Delay(500);
                    cargarPublicaciones();
                }
            }
        }

        private async void tsmiBan_Click(object sender, EventArgs e)
        {
            if (dgvPublicaciones.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere banear al usuario de esta publicación?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvPublicaciones.CurrentRow.Cells[1].Value);
                    Usuario user = await Administracion.ObtenerUsuarioByID(id);
                    await Administracion.BanearUsuarioPublicacion(user);
                    await Task.Delay(500);
                    cargarPublicaciones();
                }
            }
        }

        private async void btnDetalles_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPublicaciones.CurrentRow.Cells[0].Value);
            Publicacion p = await Administracion.ObtenerPublicacionByID(id);
            Usuario u = await Administracion.ObtenerUsuarioByID(p.idUsu);
            FrmPublicacion detallesPub = new FrmPublicacion(p, u);
            detallesPub.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarPublicaciones();
        }
    }
}

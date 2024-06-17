using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Limbo.Base_Datos;

namespace Proyecto_Limbo
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
            cargarReportes();
        }
        private async void cargarReportes()
        {
            var lstP = await Administracion.ObtenerReportesPublicaciones();
            var lstC = await Administracion.ObtenerReportesComentarios();

            if (lstP != null && lstC != null)
            {
                modelarTablaReportesPublicaciones(lstP);
                modelarTablaReportesComentarios(lstC);
            }
        }

        /// <summary>
        /// Modela la tabla de incidencias con los datos proporcionados.
        /// </summary>
        /// <param name="lst">La lista de incidencias a mostrar.</param>
        private async void modelarTablaReportesPublicaciones(List<Reportes_Publicaciones> lst)
        {
            dgvRpPublicaciones.Rows.Clear();
            dgvRpPublicaciones.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "idReportePublicacion";
            columnaID.HeaderText = "ID Reporte";

            DataGridViewTextBoxColumn columnaCom = new DataGridViewTextBoxColumn();
            columnaCom.DataPropertyName = "idPublicacion";
            columnaCom.HeaderText = "Publicacion";

            DataGridViewTextBoxColumn columnaUsu = new DataGridViewTextBoxColumn();
            columnaUsu.DataPropertyName = "idUsuario";
            columnaUsu.HeaderText = "Usuario";

            DataGridViewTextBoxColumn columnaTexto = new DataGridViewTextBoxColumn();
            columnaTexto.DataPropertyName = "texto";
            columnaTexto.HeaderText = "Texto";

            DataGridViewTextBoxColumn columnaTipo = new DataGridViewTextBoxColumn();
            columnaTipo.DataPropertyName = "tipo";
            columnaTipo.HeaderText = "Tipo";

            DataGridViewTextBoxColumn columnaRazon = new DataGridViewTextBoxColumn();
            columnaRazon.DataPropertyName = "razon";
            columnaRazon.HeaderText = "Razón";


            if (dgvRpPublicaciones.Columns.Count < 7)
            {
                dgvRpPublicaciones.Columns.Add(columnaID);
                dgvRpPublicaciones.Columns.Add(columnaCom);
                dgvRpPublicaciones.Columns.Add(columnaUsu);
                dgvRpPublicaciones.Columns.Add(columnaTexto);
                dgvRpPublicaciones.Columns.Add(columnaTipo);
                dgvRpPublicaciones.Columns.Add(columnaRazon);
            }
            foreach (var responsable in lst)
            {
                if (responsable.idReportePublicacion != null)
                {

                    var reporte = await Administracion.ObtenerReporteComByID(responsable.idReportePublicacion);
                    var publicacion = await Administracion.ObtenerPublicacionByID(responsable.idPublicacion);
                    var usuario = await Administracion.ObtenerUsuarioByID(responsable.idUsuario);

                    dgvRpPublicaciones.Rows.Add(responsable.idReportePublicacion, responsable.idPublicacion, usuario.nombreUsu, publicacion.texto, responsable.tipo, responsable.razon);
                }

                else
                {
                    dgvRpPublicaciones.Rows.Add("No se ha encontrado el reporte");
                }
            }
            lblRpPub.Text = "Reportes de publicaciones " + dgvRpPublicaciones.RowCount.ToString();
        }

        private async void modelarTablaReportesComentarios(List<Reportes_Comentarios> lst)
        {
            dgvRpComentarios.Rows.Clear();
            dgvRpComentarios.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "idReportesComentario";
            columnaID.HeaderText = "ID Reporte";

            DataGridViewTextBoxColumn columnaCom = new DataGridViewTextBoxColumn();
            columnaCom.DataPropertyName = "idComentario";
            columnaCom.HeaderText = "Comentario";

            DataGridViewTextBoxColumn columnaUsu = new DataGridViewTextBoxColumn();
            columnaUsu.DataPropertyName = "idUsuario";
            columnaUsu.HeaderText = "Usuario";

            DataGridViewTextBoxColumn columnaTexto = new DataGridViewTextBoxColumn();
            columnaTexto.DataPropertyName = "texto";
            columnaTexto.HeaderText = "Texto";

            DataGridViewTextBoxColumn columnaTipo = new DataGridViewTextBoxColumn();
            columnaTipo.DataPropertyName = "tipo";
            columnaTipo.HeaderText = "Tipo";

            DataGridViewTextBoxColumn columnaRazon = new DataGridViewTextBoxColumn();
            columnaRazon.DataPropertyName = "razon";
            columnaRazon.HeaderText = "Razón";


            if (dgvRpComentarios.Columns.Count < 7)
            {
                dgvRpComentarios.Columns.Add(columnaID);
                dgvRpComentarios.Columns.Add(columnaCom);
                dgvRpComentarios.Columns.Add(columnaUsu);
                dgvRpComentarios.Columns.Add(columnaTexto);
                dgvRpComentarios.Columns.Add(columnaTipo);
                dgvRpComentarios.Columns.Add(columnaRazon);
            }
            foreach (var responsable in lst)
            {
                if (responsable.idReportesComentario != null)
                {

                    var reporte = await Administracion.ObtenerReporteComByID(responsable.idReportesComentario);
                    var comentario = await Administracion.ObtenerComentarioByID(responsable.idComentario);
                    var usuario = await Administracion.ObtenerUsuarioByID(responsable.idUsuario);

                    dgvRpComentarios.Rows.Add(responsable.idReportesComentario, responsable.idComentario, usuario.nombreUsu, comentario.texto, responsable.tipo, responsable.razon);
                }

                else
                {
                    dgvRpComentarios.Rows.Add("No se ha encontrado el reporte");
                }

            }
            lblRpCom.Text = "Reportes de comentarios " + dgvRpComentarios.RowCount.ToString();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }


        private async void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idRc = Convert.ToInt32(dgvRpComentarios.CurrentRow.Cells[0].Value);

            Reportes_Comentarios rc = await Administracion.ObtenerReporteComByID(idRc);
            FrmReporte detallesCom = new FrmReporte(rc);
            detallesCom.ShowDialog();
        }

        private async void detallesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int idRp = Convert.ToInt32(dgvRpPublicaciones.CurrentRow.Cells[0].Value);

            Reportes_Publicaciones rp = await Administracion.ObtenerReportePubByID(idRp);
            FrmReporte detallesCom = new FrmReporte(rp);
            detallesCom.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void borrarComentarioTsm_Click(object sender, EventArgs e)
        {
            if (dgvRpComentarios.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere eliminar esta publicacion?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvRpComentarios.CurrentRow.Cells[1].Value);
                    await Administracion.BorrarComentario(id);
                    await Task.Delay(500);
                    cargarReportes();
                }
            }
        }

        private async void banearUsuarioTsm2_Click(object sender, EventArgs e)
        {
            if (dgvRpComentarios.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere banear al usuario de esta publicación?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    var nom = dgvRpComentarios.CurrentRow.Cells[2].Value;
                    Usuario user = await Administracion.ObtenerUsuarioByNombre(nom.ToString());
                    await Administracion.BanearUsuarioPublicacion(user);
                    await Task.Delay(500);
                    cargarReportes();
                }
            }
        }

        private async void banearUsuariotsm_Click(object sender, EventArgs e)
        {
            if (dgvRpComentarios.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere banear al usuario de esta publicación?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    var nom = dgvRpComentarios.CurrentRow.Cells[2].Value;
                    Usuario user = await Administracion.ObtenerUsuarioByNombre(nom.ToString());
                    await Administracion.BanearUsuarioPublicacion(user);
                    await Task.Delay(500);
                    cargarReportes();
                }
            }
        }

        private async void falsoReporteTsm_Click(object sender, EventArgs e)
        {
            if (dgvRpPublicaciones.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere marcar este reporte como falso?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvRpPublicaciones.CurrentRow.Cells[0].Value);
                    await Administracion.BorrarReportePublicacion(id);
                    await Task.Delay(500);
                    cargarReportes();
                }
            }
        }

        private async void falsoReporteTsm2_Click(object sender, EventArgs e)
        {
            if (dgvRpComentarios.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere marcar este reporte como falso?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvRpComentarios.CurrentRow.Cells[0].Value);
                    await Administracion.BorrarReporteComentario(id);
                    await Task.Delay(500);
                    cargarReportes();
                }
            }
        }

        private async void borrarPublicacionTsm_Click(object sender, EventArgs e)
        {
            if (dgvRpPublicaciones.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere eliminar esta publicacion?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvRpPublicaciones.CurrentRow.Cells[1].Value);
                    await Administracion.BorrarPublicacion(id);
                    await Task.Delay(500);
                    cargarReportes();
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarReportes();
        }
    }
}

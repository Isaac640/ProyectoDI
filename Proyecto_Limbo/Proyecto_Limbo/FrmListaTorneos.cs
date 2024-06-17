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
    public partial class FrmListaTorneos : Form
    {
        public FrmListaTorneos()
        {
            InitializeComponent();
            cargarTorneos();
        }
        private async void cargarTorneos()
        {
            var lst = await Administracion.ObtenerTorneos();
            var lstH = await Administracion.ObtenerGanadores();

            if (lst != null && lstH != null)
            {
                modelarTablaTorneos(lst);
                modelarTablaHistorialTorneos(lstH);
            }
        }

        /// <summary>
        /// Modela la tabla de incidencias con los datos proporcionados.
        /// </summary>
        /// <param name="lst">La lista de incidencias a mostrar.</param>
        private async void modelarTablaTorneos(List<Torneo> lst)
        {
            dgvTorneos.Rows.Clear();
            dgvTorneos.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn columnaID = new DataGridViewTextBoxColumn();
            columnaID.DataPropertyName = "id_torneo";
            columnaID.HeaderText = "ID Torneo";

            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.DataPropertyName = "nombre";
            columnaNombre.HeaderText = "Nombre";

            DataGridViewTextBoxColumn columnaDesc = new DataGridViewTextBoxColumn();
            columnaDesc.DataPropertyName = "descripcion";
            columnaDesc.HeaderText = "Desc.";

            DataGridViewTextBoxColumn columnaGrupo = new DataGridViewTextBoxColumn();
            columnaGrupo.DataPropertyName = "id_grupo";
            columnaGrupo.HeaderText = "Grupo";

            DataGridViewTextBoxColumn columnaParticipantes = new DataGridViewTextBoxColumn();
            columnaParticipantes.DataPropertyName = "participantes";
            columnaParticipantes.HeaderText = "Participantes";

            DataGridViewTextBoxColumn columnaPuntos = new DataGridViewTextBoxColumn();
            columnaPuntos.DataPropertyName = "puntos_rep";
            columnaPuntos.HeaderText = "Puntos Reputación";


            if (dgvTorneos.Columns.Count < 7)
            {
                dgvTorneos.Columns.Add(columnaID);
                dgvTorneos.Columns.Add(columnaNombre);
                dgvTorneos.Columns.Add(columnaDesc);
                dgvTorneos.Columns.Add(columnaGrupo);
                dgvTorneos.Columns.Add(columnaParticipantes);
                dgvTorneos.Columns.Add(columnaPuntos);
            }
            foreach (var responsable in lst)
            {
                if (responsable.id != null)
                {

                    var torneo = await Administracion.ObtenerTorneoByID(responsable.id);
                    var grupo = await Administracion.ObtenerGrupoByID(responsable.idGrupo);

                    if (torneo.puntosRep != 0)
                    {
                        dgvTorneos.Rows.Add(responsable.id, responsable.nombre, responsable.descripcion, grupo.nombreGrupo, responsable.participantes, responsable.puntosRep);
                    }
                    else
                    {
                        dgvTorneos.Rows.Add(responsable.id, responsable.nombre, responsable.descripcion, grupo.nombreGrupo, responsable.participantes, "Sin puntos");
                    }
                }
                else
                {
                    dgvTorneos.Rows.Add("No se ha encontrado el torneo");
                }
            }
            lblTorneos.Text = "Torneos Actuales: " + dgvTorneos.RowCount.ToString();
        }
        private async void modelarTablaHistorialTorneos(List<Historial_Ganadores> lst)
        {
            dgvHistorial.Rows.Clear();
            dgvHistorial.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn columnaIDParticipante = new DataGridViewTextBoxColumn();
            columnaIDParticipante.DataPropertyName = "idParticipante";
            columnaIDParticipante.HeaderText = "Ganador";

            DataGridViewTextBoxColumn columnaIDTorneo = new DataGridViewTextBoxColumn();
            columnaIDTorneo.DataPropertyName = "idTorneo";
            columnaIDTorneo.HeaderText = "Torneo";

            DataGridViewTextBoxColumn columnaPuntos = new DataGridViewTextBoxColumn();
            columnaPuntos.DataPropertyName = "puntosRepGanados";
            columnaPuntos.HeaderText = "Puntos Ganados";

            DataGridViewTextBoxColumn columnaPremio = new DataGridViewTextBoxColumn();
            columnaPremio.DataPropertyName = "premioGanado";
            columnaPremio.HeaderText = "Premio";


            if (dgvHistorial.Columns.Count < 4)
            {
                dgvHistorial.Columns.Add(columnaIDParticipante);
                dgvHistorial.Columns.Add(columnaIDTorneo);
                dgvHistorial.Columns.Add(columnaPuntos);
                dgvHistorial.Columns.Add(columnaPremio);
            }
            foreach (var responsable in lst)
            {
                if (responsable.idParticipante != null)
                {

                    var ganador = await Administracion.ObtenerGanadorByID(responsable.idTorneo);
                    Usuario user = await Administracion.ObtenerUsuarioByID(responsable.idParticipante);
                    Torneo torn = await Administracion.ObtenerTorneoByID(responsable.idTorneo);

                    if (responsable.puntosRepGanados != 0)
                    {
                        dgvHistorial.Rows.Add(user.nombreUsu, torn.nombre, responsable.puntosRepGanados, responsable.premioGanado);
                    }
                    else
                    {
                        dgvHistorial.Rows.Add(user.nombreUsu, torn.nombre, "Ningun punto ganado", responsable.premioGanado);
                    }
                }
                else
                {
                    dgvHistorial.Rows.Add("No se ha encontrado el ganador");
                }
            }
            lblTorneos.Text = "Torneos Actuales: " + dgvTorneos.RowCount.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            FrmTorneo nuevoTorneo = new FrmTorneo();
            if (nuevoTorneo.ShowDialog() == DialogResult.OK)
            {
                cargarTorneos();
            }
        }

        private async void btnElim_Click(object sender, EventArgs e)
        {
            if (dgvTorneos.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere eliminar este torneo?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvTorneos.CurrentRow.Cells[0].Value);
                    await Administracion.BorrarTorneo(id);
                    await Task.Delay(500);
                    cargarTorneos();
                }
            }
            if (dgvHistorial.SelectedCells.Count > 0)
            {
                DialogResult dr = MessageBox.Show("¿Seguro que quiere eliminar este ganador?", "Aviso", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvTorneos.CurrentRow.Cells[0].Value);
                    await Administracion.BorrarHistorialTorneo(id);
                    await Task.Delay(500);
                    cargarTorneos();
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarTorneos();
        }
    }
}

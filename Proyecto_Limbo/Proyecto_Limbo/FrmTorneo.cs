using Proyecto_Limbo.Base_Datos;
using Proyecto_Limbo.Enumerados;
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
    public partial class FrmTorneo : Form
    {
        public FrmTorneo()
        {
            this.DialogResult = DialogResult.Cancel;
            {
                InitializeComponent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            //Crear un objeto de tipo Incidencias_Sin con los datos de la incidencia
            Torneo torn = new Torneo();
            torn.nombre = txtNombre.Text;
            torn.descripcion = txtDesc.Text;
            Grupo g = await Administracion.ObtenerGrupoByNombre(txtGrupo.Text);
            if (g != null)
            {
                torn.idGrupo = g.idGrupo;
                torn.premios = txtPremio.Text;
                torn.puntosRep = Convert.ToInt32(txtPuntos.Text);

                //Enviar el objeto a la base de datos
                await Administracion.PublicarTorneo(torn);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult dr = MessageBox.Show("El grupo no existe", "Aviso", MessageBoxButtons.YesNo);
            }
           
        }

    }
}

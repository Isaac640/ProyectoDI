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
    public partial class FrmReporte : Form
    {
        Publicacion publicacion;
        Comentarios comentario;
        Usuario user;
        private FrmReporte()
        {
            InitializeComponent();

            //Inicializamos las variables
            publicacion = new Publicacion();
            user = new Usuario();
        }

        public FrmReporte(Reportes_Publicaciones rp) : this()
        {
            cargarDetallesPublicacion(rp);

        }

        public FrmReporte(Reportes_Comentarios rc) : this()
        {
            lblDenuncia.Text = "Comentario";
            cargarDetallesComentario(rc);
        }

        private async void cargarDetallesComentario(Reportes_Comentarios rc)
        {
            this.comentario = await Administracion.ObtenerComentarioByID(rc.idComentario);
            this.user = await Administracion.ObtenerUsuarioByID(rc.idUsuario);
            if (comentario == null)
            {
                MessageBox.Show("No se ha encontrado el comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                if (user == null)
                {
                    MessageBox.Show("No se ha encontrado el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else{ 
                    txtUsuario.Text = user.nombreUsu;
                    txtTexto.Text = comentario.texto;
                    txtTipo.Text = rc.tipo;
                    txtRazon.Text = rc.razon;
                }
            }
            
            
        }
        private async void cargarDetallesPublicacion(Reportes_Publicaciones rc)
        {
            this.publicacion = await Administracion.ObtenerPublicacionByID(rc.idPublicacion);
            this.user = await Administracion.ObtenerUsuarioByID(rc.idUsuario);
            if (publicacion == null)
            {
                MessageBox.Show("No se ha encontrado la publicacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user == null)
                {
                    MessageBox.Show("No se ha encontrado el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtUsuario.Text = user.nombreUsu;
                    txtTexto.Text = publicacion.texto;
                    txtTipo.Text = rc.tipo;
                    txtRazon.Text = rc.razon;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

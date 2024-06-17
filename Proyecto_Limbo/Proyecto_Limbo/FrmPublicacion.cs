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
    public partial class FrmPublicacion : Form
    {
        Publicacion publicacion;
        Usuario user;
        private FrmPublicacion()
        {
            InitializeComponent();
			
			//Inicializamos las variables
			publicacion =new Publicacion();
			user = new Usuario();
        }

        public FrmPublicacion(Publicacion p, Usuario u) : this()
        {
			this.publicacion = p;
			this.user = u;
			
			cargarDetalles();
            
        }

        private async void cargarDetalles()
        {
            lblUser.Text = "Usuario: " + user.nombreUsu;
            txtDesc.Text = publicacion.texto;
            lblLikes.Text = "Me gustas: " + publicacion.meGustas.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere eliminar esta publicacion?", "Aviso", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                await Administracion.BorrarPublicacion(publicacion.id);
                await Task.Delay(500);
                this.Close();
            }
        }

        private async void btnBanear_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Seguro que quiere banear al usuario de esta publicación?", "Aviso", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Usuario user = await Administracion.ObtenerUsuarioByID(publicacion.id);
                await Administracion.BanearUsuarioPublicacion(user);
                await Task.Delay(500);
                this.Close();
            }

        }


    }
}

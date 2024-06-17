using Proyecto_Limbo.Base_Datos;

namespace Proyecto_Limbo
{
    public partial class FrmLogin : Form
    {
        string userName;

        /// <summary>
        /// Constructor de la clase FrmLogin.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            userName = Environment.UserName;
            lblUser.Text = "Conectandose al usuario " + userName;
            InicioSesion(userName);
        }

        /// <summary>
        /// Método llamado cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>

        /// <summary>
        /// Inicia sesión en el sistema.
        /// </summary>
        /// <param name="userName">El nombre de usuario del sistema.</param>
        private async Task InicioSesion(string userName)
        {
            Usuario usuario = await Administracion.ObtenerUsuarioByNombre(userName);
            Usuario u = usuario;
            if (usuario != null)
            {
                // ACCESO DE ADMIN
                if (usuario.tipo.Equals("administrador"))
                {
                    FrmPrincipal fPrincipal = new FrmPrincipal(usuario);
                    fPrincipal.Show();
                    this.Close();
                }
                // NO ES ADMIN
                else
                {
                    MessageBox.Show("Este usuario no es un administrador. Por favor" +
                        " conectese con un usuario administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Este usuario no existe. Por favor" +
                    " conectese con un usuario administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }

        }
    }
}

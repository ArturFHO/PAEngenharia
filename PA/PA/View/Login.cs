using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PA.DAO;
using PA.Model;

namespace PA.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_entrar_Click(object sender, EventArgs e)
        {
            var user = txb_login_user.Text;
            var senha = txb_login_senha.Text;

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            Usuario usuario = new Usuario();

            if (usuarioDAO.ValidarUsuario(usuario, user, senha) != null)
            {
                Global.id_usuario = usuario.id_usuario;
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário não existe!");
            }

        }

        private void btn_login_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

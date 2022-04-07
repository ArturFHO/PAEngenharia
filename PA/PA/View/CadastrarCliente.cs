using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PA.Model;
using PA.DAO;

namespace PA.View
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrarcliente_cadastrar_Click(object sender, EventArgs e)
        {
            var nome = txb_nome_cliente.Text;
            var cpf = txb_cpf_cliente.Text;
            var tel = txb_telefone_cliente.Text;
            var cel = txb_celular_cliente.Text;
            var email = txb_email_cliente.Text;
            var end = txb_end_cliente.Text;

            Cliente cliente = new Cliente(nome, cpf, tel, cel, email, end);
            cliente.usuario = Global.usuario;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.Insert(cliente);
        }
    }
}

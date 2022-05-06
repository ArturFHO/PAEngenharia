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
    public partial class ClienteView : Form
    {
        public ClienteView()
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
            try
            {
                clienteDAO.Insert(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");

            } catch 
            {
                MessageBox.Show("Erro ao cadastro o cliente!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(nmr_cliente_id.Value);
            var nome = txb_nome_cliente.Text;
            var cpf = txb_cpf_cliente.Text;
            var tel = txb_telefone_cliente.Text;
            var cel = txb_celular_cliente.Text;
            var email = txb_email_cliente.Text;
            var end = txb_end_cliente.Text;

            Cliente cliente = new Cliente(id, nome, cpf, tel, cel, email, end);
            cliente.usuario = Global.usuario;
            
            ClienteDAO clienteDAO = new ClienteDAO();
            
            try
            {
                clienteDAO.Update(cliente);
                MessageBox.Show("Cliente atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o cliente!: " + ex.ToString());
            }
        }

        private void btn_cliente_excluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(nmr_cliente_id.Value);
            var nome = txb_nome_cliente.Text;
            var cpf = txb_cpf_cliente.Text;
            var tel = txb_telefone_cliente.Text;
            var cel = txb_celular_cliente.Text;
            var email = txb_email_cliente.Text;
            var end = txb_end_cliente.Text;

            Cliente cliente = new Cliente(id, nome, cpf, tel, cel, email, end);
            cliente.usuario = Global.usuario;

            ClienteDAO clienteDAO = new ClienteDAO();

            try
            {
                clienteDAO.Delete(cliente);
                MessageBox.Show("Cliente excluido com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente!: " + ex.ToString());
            }
        }

        private void btn_cliente_pesquisar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(nmr_cliente_id.Value);
            
            Cliente cliente = new Cliente();
            cliente.usuario = Global.usuario;

            ClienteDAO clienteDAO = new ClienteDAO();

            try
            {
                cliente = clienteDAO.BuscarPorId(id);
                MessageBox.Show("Cliente encontrado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente!: " + ex.ToString());
            }

            txb_nome_cliente.Text = cliente.nome_cliente;
            txb_cpf_cliente.Text = cliente.cpf_cliente;
            txb_telefone_cliente.Text = cliente.tel_cliente;
            txb_celular_cliente.Text = cliente.cel_cliente;
            txb_email_cliente.Text = cliente.email_cliente;
            txb_end_cliente.Text = cliente.end_cliente;
        }

        private void btn_cliente_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

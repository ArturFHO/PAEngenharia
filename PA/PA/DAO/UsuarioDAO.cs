using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;
using PA.View;
using Npgsql;

namespace PA.DAO
{
    public class UsuarioDAO
    {
        public void Insert(Usuario usuario)
        {
            /*NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO Cliente (nome_cliente, cpf_cliente, tel_cliente, cel_cliente, email_cliente, end_cliente) VALUES (@nome, @cpf, @telefone, @celular, @email, @endereco)";

            comando.Parameters.AddWithValue("@nome", cliente.nome_cliente);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf_cliente);
            comando.Parameters.AddWithValue("@telefone", cliente.tel_cliente);
            comando.Parameters.AddWithValue("@celular", cliente.cel_cliente);
            comando.Parameters.AddWithValue("@email", cliente.email_cliente);
            comando.Parameters.AddWithValue("@endereco", cliente.end_cliente);

            ConexaoBanco.CRUD(comando);*/
        }

        public void Update(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            /* comando.CommandText = 'INSERT INTO Cliente (nome_cliente, cpf_cliente, tel_cliente, cel_cliente, email_cliente, end_cliente) VALUES (@nome, @cpf, @telefone, @celular, @email, @endereco)';

            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf);
            comando.Parameters.AddWithValue("@telefone", cliente.telefone);
            comando.Parameters.AddWithValue("@celular", cliente.celular);
            comando.Parameters.AddWithValue("@email", cliente.email);
            comando.Parameters.AddWithValue("@endereco", cliente.endereco);

            ConexaoBanco.CRUD(comando);*/

        }

        public void Delete(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            /* comando.CommandText = 'INSERT INTO Cliente (nome_cliente, cpf_cliente, tel_cliente, cel_cliente, email_cliente, end_cliente) VALUES (@nome, @cpf, @telefone, @celular, @email, @endereço)';

            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);

            ConexaoBanco.CRUD(comando); */
        }

        public void BuscarPorId(int id)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Cliente WHERE id_cliente=@id";
            comando.Parameters.AddWithValue("@id");

            ConexaoBanco.CRUD(comando);
        }

        public Usuario ValidarUsuario(Usuario usuario, String user, String senha)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Usuario WHERE nome_usuario=@user AND senha_usuario=@senha";
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@senha", senha);

            NpgsqlDataReader dr = ConexaoBanco.Selecionar(comando);
            
            if(dr.HasRows)
            {
                dr.Read();
                usuario.id_usuario = (int)dr["id_usuario"];
                usuario.nome_usuario = (string)dr["nome_usuario"];
                usuario.senha_usuario = (string)dr["senha_usuario"];
                usuario.email_usuario = (string)dr["email_usuario"];
                usuario.tel_usuario = (string)dr["tel_usuario"];
            
            }
            else
            {
                usuario = null;
            }
            return usuario;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;
using Npgsql;

namespace PA.DAO
{
    public class ClienteDAO
    {
        public void Insert(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = 'INSERT INTO Cliente (nome_cliente, cpf_cliente, tel_cliente, cel_cliente, email_cliente, end_cliente) VALUES (@nome, @cpf, @telefone, @celular, @email, @endereço)';

            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);

            ConexaoBanco.CRUD(comando);
        }

        public void Update(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = 'INSERT INTO Cliente (nome_cliente, cpf_cliente, tel_cliente, cel_cliente, email_cliente, end_cliente) VALUES (@nome, @cpf, @telefone, @celular, @email, @endereço)';

            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);

            ConexaoBanco.CRUD(comando);

        }

        public void Delete(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = 'INSERT INTO Cliente (nome_cliente, cpf_cliente, tel_cliente, cel_cliente, email_cliente, end_cliente) VALUES (@nome, @cpf, @telefone, @celular, @email, @endereço)';

            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);
            comando.Parameters.AddWithValue("@nome", cliente);

            ConexaoBanco.CRUD(comando);
        }

        public void BuscarPorId(int id)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Cliente WHERE id_cliente=@id";
            comando.Parameters.AddWithValue("@id");
            
            ConexaoBanco.CRUD(comando);
        }
    }
}

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
    public class ClienteDAO
    {
        public void Insert(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO Cliente (nome_cliente, cpf_cliente, tel_cliente, cel_cliente, email_cliente, end_cliente, fk_id_usuario) "+ 
                                        "VALUES (@nome, @cpf, @telefone, @celular, @email, @endereco, @id_usuario)";

            comando.Parameters.AddWithValue("@nome", cliente.nome_cliente);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf_cliente);
            comando.Parameters.AddWithValue("@telefone", cliente.tel_cliente);
            comando.Parameters.AddWithValue("@celular", cliente.cel_cliente);
            comando.Parameters.AddWithValue("@email", cliente.email_cliente);
            comando.Parameters.AddWithValue("@endereco", cliente.end_cliente);
            comando.Parameters.AddWithValue("@id_usuario", cliente.usuario.id_usuario);

            ConexaoBanco.CRUD(comando);
        }

        public void Update(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE Cliente SET nome_cliente=@nome, cpf_cliente=@sal, tel_cliente=@telefone, cel_cliente=@celular, email_cliente=@email, end_cliente=@endereco,  fk_id_usuario=@id_usuario) " + 
                                               "WHERE id_Cargo=@id";

            comando.Parameters.AddWithValue("@nome", cliente.nome_cliente);
            comando.Parameters.AddWithValue("@cpf", cliente.cpf_cliente);
            comando.Parameters.AddWithValue("@telefone", cliente.tel_cliente);
            comando.Parameters.AddWithValue("@celular", cliente.cel_cliente);
            comando.Parameters.AddWithValue("@email", cliente.email_cliente);
            comando.Parameters.AddWithValue("@endereco", cliente.end_cliente);
            comando.Parameters.AddWithValue("@id_usuario", Global.usuario.id_usuario);

            ConexaoBanco.CRUD(comando);
        }

        public void Delete(Cliente cliente)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Cliente WHERE id_cliente=@id";

            comando.Parameters.AddWithValue("@id", cliente.id_cliente);
        
            ConexaoBanco.CRUD(comando);
        }

        public Cliente BuscarPorId(int id)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Cliente WHERE id_cliente=@id";
            
            comando.Parameters.AddWithValue("@id", id);

            NpgsqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Cliente cliente = new Cliente();
            if (dr.HasRows)
            {
                dr.Read();
                cliente.id_cliente = (int)dr["id_cliente"];
                cliente.nome_cliente = (string)dr["nome_cliente"];
                cliente.cpf_cliente = (string)dr["cpf_cliente"];
                cliente.tel_cliente = (string)dr["tel_cliente"];
                cliente.cel_cliente = (string)dr["cel_cliente"];
                cliente.email_cliente = (string)dr["email_cliente"];
                cliente.end_cliente = (string)dr["end_cliente"];
                cliente.usuario.id_usuario = (int)dr["fk_id_usuario"];
            }
            else
            {
                cliente = null;
            }
            return cliente;
        }    
    }
}

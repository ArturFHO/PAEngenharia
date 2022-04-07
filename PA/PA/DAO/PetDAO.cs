using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;
using Npgsql;

namespace PA.DAO
{   public class PetDAO
    {
        public void Insert(Pet pet)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO Pet (nome_pet, sexo_pet, tipo_pet, raca_pet, fk_id_cliente, fk_id_usuario) " +
                                         "VALUES (@nome, @sexo, @tipo, @raca, @id_cliente, @id_usuario)";

            comando.Parameters.AddWithValue("@nome", pet.nome_pet);
            comando.Parameters.AddWithValue("@sexo", pet.sexo_pet);
            comando.Parameters.AddWithValue("@tipo", pet.tipo_pet);
            comando.Parameters.AddWithValue("@raca", pet.raca_pet);
            comando.Parameters.AddWithValue("@id_cliente", pet.cliente.id_cliente);
            comando.Parameters.AddWithValue("@id_usuario", pet.usuario.id_usuario);

            ConexaoBanco.CRUD(comando);
        }
        public void Update(Pet pet)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE Pet SET nome_pet=@nome, sexo_pet=@sexo, tipo_pet=@tipo, raca_pet=@raca, fk_id_cliente=@id_cliente, fk_id_usuario=@id_usuario" + 
                                               "WHERE id_Cargo=@id";

            comando.Parameters.AddWithValue("@nome", pet.nome_pet);
            comando.Parameters.AddWithValue("@sexo", pet.sexo_pet);
            comando.Parameters.AddWithValue("@tipo", pet.tipo_pet);
            comando.Parameters.AddWithValue("@raca", pet.raca_pet);
            comando.Parameters.AddWithValue("@id_cliente", pet.cliente.id_cliente);
            comando.Parameters.AddWithValue("@id_usuario", Global.usuario.id_usuario);

            ConexaoBanco.CRUD(comando);
        }
        public void Delete(Pet pet)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Pet WHERE id_pet=@id";

            comando.Parameters.AddWithValue("@id", pet.id_pet);
        
            ConexaoBanco.CRUD(comando);
        }
        public Pet BuscarPorId(int id)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Pet WHERE id_pet=@id";
            
            comando.Parameters.AddWithValue("@id", id);

            NpgsqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Pet pet = new Pet();
            if (dr.HasRows)
            {
                dr.Read();
                pet.id_pet = (int)dr["id_pet"];
                pet.nome_pet = (string)dr["nome_pet"];
                pet.sexo_pet = (string)dr["sexo_pet"];
                pet.tipo_pet = (string)dr["tipo_pet"];
                pet.raca_pet = (string)dr["raca_pet"];
                pet.cliente.id_cliente = (int)dr["fk_id_cliente"];
                pet.usuario.id_usuario = (int)dr["fk_id_usuario"];
            }
            else
            {
                pet = null;
            }
            return pet;
        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PA.Model;

namespace PA.DAO
{
    public class CargoDAO
    {
        public void Insert(Cargo cargo)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO Cargo (desc_cargo, salario_cargo, nivel_Cargo) " +
                                         "VALUES (@desc, @sal, @nivel)";

            comando.Parameters.AddWithValue("@desc", cargo.desc_cargo);
            comando.Parameters.AddWithValue("@sal", cargo.salario_cargo);
            comando.Parameters.AddWithValue("@nivel", cargo.nivel_cargo);
        
            ConexaoBanco.CRUD(comando);
        }
        public void Update(Cargo cargo)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE Cargo SET desc_cargo=@desc, salario_cargo=@sal, nivel_cargo=@nivel) " + 
                                               "WHERE id_cargo=@id";

            comando.Parameters.AddWithValue("@id", cargo.id_cargo);
            comando.Parameters.AddWithValue("@desc", cargo.desc_cargo);
            comando.Parameters.AddWithValue("@sal", cargo.salario_cargo);
            comando.Parameters.AddWithValue("@nivel", cargo.nivel_cargo);

            ConexaoBanco.CRUD(comando);
        }
        public void Delete(Cargo cargo)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Cargo WHERE id_cargo=@id";

            comando.Parameters.AddWithValue("@id", cargo.id_cargo);
        
            ConexaoBanco.CRUD(comando);
        }
        public Cargo BuscarPorId(int id)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Cargo WHERE id_cargo=@id";
            
            comando.Parameters.AddWithValue("@id", id);

            NpgsqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Cargo cargo = new Cargo();
            if (dr.HasRows)
            {
                dr.Read();
                cargo.id_cargo = (int)dr["id_cargo"];
                cargo.desc_cargo = (string)dr["desc_cargo"];
                cargo.salario_cargo = (string)dr["salario_cargo"];
                cargo.nivel_cargo = (string)dr["nivel_cargo"];
            }
            else
            {
                cargo = null;
            }
            return cargo;
        }    
    }
}

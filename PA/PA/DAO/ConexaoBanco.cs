using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PA.DAO
{
    public class ConexaoBanco
    {
        public static NpgsqlConnection Conectar()
        {
            string stringConexao = "Server=localhost;" +
                                   "Port=5432;" +
                                   "User Id=postgres;" +
                                   "Password=031298;" +
                                   "Database=PA";

            NpgsqlConnection conexao = new NpgsqlConnection(@stringConexao);
            conexao.Open();
            return conexao;
        }

        public static void CRUD(NpgsqlCommand comando)
        {
            NpgsqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public static NpgsqlDataReader Selecionar(NpgsqlCommand comando)
        {
            NpgsqlConnection con = Conectar();
            comando.Connection = con;
            NpgsqlDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return dr;
        }
    }
}

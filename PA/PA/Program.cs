using System;
using PA.Model;
using PA.DAO;
using PA.View;

namespace PA
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cliente cliente = new Cliente();
            
            cliente.cpf = "2323";
            cliente.telefone = "fdsadf";
            cliente.celular = "3232";
            cliente.email = "fadfadsf";
            cliente.endereco = "fadufashf";

            ClienteDAO teste = new ClienteDAO();
            teste.Insert(cliente);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
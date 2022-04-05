using System;
using PA.Model;
using PA.DAO;
using PA.View;

namespace PA
{
    public static class Global
    {
        public static int id_usuario;
    }
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cliente cliente = new Cliente("bijão", "1311313", "434242", "4324234", "fafuidf@gmail.com", "fakdsjflkasjfkdsj");
            
            

            ClienteDAO teste = new ClienteDAO();
            teste.Insert(cliente);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
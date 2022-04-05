using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nome_usuario { get; set; }
        public string senha_usuario { get; set; }
        public string email_usuario { get; set; }
        public string tel_usuario { get; set; }
        
        public Usuario()
        {

        }
        public Usuario(String nome, String senha, String email, String telefone)
        {
            this.nome_usuario = nome;
            this.senha_usuario = senha;
            this.email_usuario= email;
            this.tel_usuario = telefone;
        }
    }
}

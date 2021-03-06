using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAO;

namespace PA.Model
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public String nome_cliente { get; set; }
        public String cpf_cliente { get; set; }
        public String tel_cliente { get; set; }
        public String cel_cliente { get; set; }
        public String email_cliente { get; set; }
        public String end_cliente { get; set; }
        public Usuario usuario;

        public Cliente () {
            this.usuario = new Usuario ();
        }

        public Cliente(int id, String nome, String cpf, String tel, String cel, String email, String end)
        {
            this.id_cliente = id;
            this.nome_cliente = nome;
            this.cpf_cliente = cpf;
            this.tel_cliente = tel;
            this.cel_cliente = cel;
            this.email_cliente = email;
            this.end_cliente = end;
            Usuario usuario = new Usuario();
            this.usuario = usuario;

        }
        public Cliente(String nome, String cpf, String tel, String cel, String email, String end)
        {
            this.nome_cliente = nome;
            this.cpf_cliente = cpf;
            this.tel_cliente = tel;
            this.cel_cliente = cel;
            this.email_cliente = email;
            this.end_cliente = end;
            Usuario usuario = new Usuario();
            this.usuario = usuario;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Pet
    {
        public int id_pet { get; set; }
        public string nome_pet { get; set; }
        public string sexo_pet { get; set; }
        public string tipo_pet { get; set; }
        public string raca_pet { get; set; }
        public Usuario usuario;
        public Cliente cliente;

        public Pet(String nome, String sexo, String tipo, String raca)
        {
            this.nome_pet = nome;
            this.sexo_pet = sexo;
            this.tipo_pet = tipo;
            this.raca_pet = raca;
            Usuario usuario = new Usuario();
            this.usuario = usuario;
            Cliente cliente = new Cliente();
            this.cliente = cliente;
        }

    }
}

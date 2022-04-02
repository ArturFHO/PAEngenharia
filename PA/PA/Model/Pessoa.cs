using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public abstract class Pessoa
    {
        protected String nome { get; set;  }
        protected String cpf { get; set; }
        protected String telefone { get; set; }
        protected String celular { get; set; }
        protected String email { get; set; }
        protected String endereco { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Cargo
    {
        public int id_cargo { get; set; }
        public string desc_cargo { get; set; }
        public string salario_cargo { get; set; }
        public string nivel_cargo { get; set; }

        public Cargo()
        {
            
        }
        
        public Cargo(String desc, String salario, String nivel)
        {
            this.desc_cargo = desc;
            this.salario_cargo = salario;
            this.nivel_cargo = nivel;
        }
    }
}

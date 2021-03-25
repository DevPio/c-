using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
        public string titular { get; set; }
        public string titularCPF { get; set; }
        public string titularProfissao { get; set; }


        public Cliente(string titular, string titularCPF, string titularProfissao)
        {
            this.titular = titular;
            this.titularCPF = titularCPF;
            this.titularProfissao = titularProfissao;
        }
    }

   
}

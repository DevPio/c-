using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{

   
    public class GerenciaBonificacao
    {

        private double total;



        public double GetBonificacao()
        {
            return 1;
        }

        public void Registrar(Funcionario funcionario)
        {
            this.total += funcionario.GetBonificao();
        }

        public void Registrar(Diretor diretor)
        {
            this.total += diretor.GetBonificao();
        }

    }
}

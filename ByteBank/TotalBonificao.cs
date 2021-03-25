using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class TotalBonificao
    {
        private static double _totalBonidica = 0;


        public static void Registrar(double valor)
        {
            TotalBonificao._totalBonidica += valor;
        }


        public static double GetBonificaoTotal() { return TotalBonificao._totalBonidica; }
    }
}

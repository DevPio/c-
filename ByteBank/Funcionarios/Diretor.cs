using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
       

        

       public Diretor(string nome, string cpf, double salario, string tipo) : base(nome, cpf, salario, tipo)
        {
            this.nome = nome;
            this.CPF = cpf;
            this.salario = salario;
            this.tipo = tipo;
        }

      

        public override double GetBonificao()
        {
            
            TotalBonificao.Registrar(this.salario);
            return this.salario + base.GetBonificao();
        }
    }
}

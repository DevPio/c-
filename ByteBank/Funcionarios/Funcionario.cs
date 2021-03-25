using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        private int numCPF = 10;
        private int numCPFCriterio = 11;

        private static int totalFunc;


        public string nome { get; set; }
        private string _cpf;
        private int incremente;
        public double salario { get; set; }
        protected string tipo {  get; set; }


        public static int ObteFunc {
            get 
            {

                return Funcionario.totalFunc;

            } private set { } }
        public string CPF
        {
            get
            {
                return this._cpf;
            }
            set
            {

                if (value.Length < 11)
                {
                    return;
                }
                int sum = 0;
                int sumJ = 0;

                List<int> numTotal = new List<int>();

                int j = 0;
                int k = 0;

                foreach (var item in value)
                {
                    
                    var numMomente = this.numCPF;

                    int itemEditado =  (int)Char.GetNumericValue(item) * numMomente;
                    sum += itemEditado;
                    numTotal.Add((int)Char.GetNumericValue(item));
                    this.incremente++;
                    this.numCPF--;
                    if (this.incremente >= 9)
                    {
                        break;
                    }
                }
               
                if((sum % 11) == 0 || (sum % 11) == 1)
                {
                    j = 0;
                    numTotal.Add(j);
                }
                else
                {
                    j = (11 - sum % 11);
                    numTotal.Add(j);
             
                }



                foreach (var item in numTotal)
                { 


                    var numMomente = this.numCPFCriterio;

                    int itemEditado = item * numMomente;
                  
                    sumJ += itemEditado;
                    
                     
                    this.numCPFCriterio--;
                   
                }


                if ((sumJ % 11) == 0 || (sumJ % 11) == 1)
                {
                    k = 0;
                    
                }
                else
                {
                    k = (11 - sumJ % 11);
                  

                }
              

                if (j == this.Converter(value[9]) || k == this.Converter(value[10]))
                {
                    this._cpf = value;
                }
                else
                {
                    return;
                }
            }
        }

        public Funcionario(string nome, string cpf, double salario,string tipo)
        {
            this.nome = nome;
            this.CPF = cpf;
            this.salario = salario;
            this.tipo = tipo;
            Funcionario.totalFunc++;
        }
        private double Converter(char value)
        {
            return (int)Char.GetNumericValue(value);
        }

        public virtual double GetBonificao()
        {

            TotalBonificao.Registrar(this.salario * 0.1);
            return this.salario * 0.1;

        }
    }
}

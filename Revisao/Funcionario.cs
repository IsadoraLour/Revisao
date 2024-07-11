using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Funcionario : Pessoa 
    {
        private int matricula { get; set; }
        private string placaVeiculo { get; set; }
        public bool verificarVeiculo(Automovel automovel)
        {
          
           if(automovel.placa.Length == 7)
           {
              return true; 
           }
           else
           {
              return false; 
           }
            
        }

        public string ValorMatricula()
        {
            Console.WriteLine("Qual o número da sua matricula");
            string ValorMatricula =Console.ReadLine();

            return ValorMatricula;
        }

      
    }
}

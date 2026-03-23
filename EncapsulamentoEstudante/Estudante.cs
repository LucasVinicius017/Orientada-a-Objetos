using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private string nome;
        private decimal nota1, nota2;
        public decimal Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public decimal Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public string Nome
        {   
            get { return nome; }
            set { 
                if (value != "")
                    nome = value; 
                else Console.WriteLine("Valor inválido");
            }
        }
    }
}

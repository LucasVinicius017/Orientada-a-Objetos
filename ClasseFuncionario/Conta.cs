using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Conta
    {
        public string codigo;
        public string? nome;
        public decimal salario;
        public static int qtdContas = 0;
        static Conta()
        {
            qtdContas = 100;
        }
        public Conta()
        {
            qtdContas++;
        }
        public Conta(string? codigo)
        {
            qtdContas++;
        }
        public Conta(string? nome, decimal salario)
        {
            qtdContas++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + codigo + 
                "\tTitular: " + nome +    
                "\tSaldo: " + salario);
        }
    }
}
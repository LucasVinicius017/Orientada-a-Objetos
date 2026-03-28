using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;
        private static int contador;

        public static int Contador
        {
            get { return contador; }
        }
         public Conta()
        {
            contador ++;      
        }
        public Conta(string? titular)
        {
            this.titular = titular;
            contador ++;            
        }
        public Conta(string? titular, double saldo)
        {
            this.titular = titular;            
            this.saldo = saldo;
            contador ++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} \tSaldo R$ {saldo}");
        }
    }
}
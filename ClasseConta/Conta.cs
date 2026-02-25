using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta //subpasta
{
    public class Conta
    {
        //declaração dos atributos
        public int numero;
        public string titular;
        public double saldo;
        //declaração dos métodos
        public void Sacar(double valorSaque)
        {
            saldo -= valorSaque;
        }

        public void Depositar(double valorDeposito)
        {
            saldo = saldo + valorDeposito;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + 
                "\tTitular: " + titular +    
                "\tSaldo: " + saldo);
        }
    }
}
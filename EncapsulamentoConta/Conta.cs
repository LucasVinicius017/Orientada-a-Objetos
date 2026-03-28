using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta //subpasta
{
    public class Conta
    {
        //declaração dos atributos
        private int numero;
        private string? titular;
        private decimal saldo;
        //declaração dos métodos-funções
        public int Numero //propriedade
        { // 11 linhas
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }
        public string? Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
        
        public void Sacar(decimal valorSaque){
            saldo -= valorSaque;
        }
        public void Depositar(decimal valorDeposito){
            saldo = saldo + valorDeposito;
        }
        public void MostrarAtributos(){
            Console.WriteLine("Número: "+ numero +
                    "\tTitular: " + titular +
                    "\tSaldo: " + saldo);
        }
    }
}
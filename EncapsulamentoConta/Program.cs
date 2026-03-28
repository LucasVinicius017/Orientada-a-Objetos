// Main()
using EncapsulamentoConta;
Conta c = new Conta();
c.Numero = 1;
c.Titular = "Ana"; // set
c.Saldo = 100;
Console.WriteLine(c.Numero + " - " + c.Titular + " - " + c.Saldo); //get
decimal total = c.Saldo + 1000;
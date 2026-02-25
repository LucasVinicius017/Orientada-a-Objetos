using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //declaração de variável e instância
        Conta c1 = new Conta();
        c1.numero = 10;
        c1.titular = "Fatec";
        c1.saldo = 100;
        c1.MostrarAtributos();
        c1.Depositar(250);
        c1.MostrarAtributos();
        
        Conta c2 = new Conta();
        c2.MostrarAtributos();
        double valor = 50;
        c2.Sacar(valor);
        c2.MostrarAtributos();
        c2.numero = 20;
        c2.titular = "Fatec";
        c2.saldo = 200;
        Console.WriteLine("Número: " + c2.numero + "\tTitular: " + 
        c2.titular + "\tSaldo: " + c2.saldo);
        Console.Write("Digite o número: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
    }
}
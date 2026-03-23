using ConstrutorConta;

class Program
{
    static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.MostrarAtributos();

        Conta c2 = new Conta("Ana");
        c2.MostrarAtributos();

        Conta c3 = new Conta("Bia", 300);
        c3.MostrarAtributos();

        Console.WriteLine("Qtde de instâncias? " + Conta.Contador);
    }
}
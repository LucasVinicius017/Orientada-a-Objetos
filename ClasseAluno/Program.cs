using ClasseAluno;
// Fazer 2 instância
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a1 = new conta();
        a1.ra = Convert.(Console.ReadLine());
        Console.Write("Digite o RA: ");
        a1.nome = Convert.(Console.ReadLine());
        Console.Write("Digite o nome: ");
        a1.p1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a nota da P1: ");
        a1.p2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a nota da P2: ");
        a1.media = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a média: ");
        a1.CalcularMédia();
        
        Aluno a2 = new conta();
        a2.ra = Convert.(Console.ReadLine());    
        Console.Write("Digite o RA: ");
        a2.nome = Convert.(Console.ReadLine());
        Console.Write("Digite o nome: ");
        a2.p1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a nota da P1: ");
        a2.p2 = Convert.ToInt32(Console.ReadLine());    
        Console.Write("Digite a nota da P2: ");
        a2.media = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a média: ");
        a2.CalcularMédia();
       
    }
}
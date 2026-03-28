using EncapsulamentoEstudante;
Estudante e1 = new Estudante();
Console.Write("Digite o nome: ");
e1.Nome = Console.ReadLine();
Console.Write("Digite a primeira nota: ");
e1.Nota1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
e1.Nota2 = Convert.ToDecimal(Console.ReadLine());


e1.MostrarAtributo();
e1.CalcularMedia();
e1.MostrarAtributos();

decimal media = (e1.Nota1 + e1.Nota2) / 2;
string resultado = (media >= 6)? "Aprovado":"Reprovado";    
Console.WriteLine($"Média: {media} \tResultado: {resultado}");

set
{
    if (value >= 0 && value <= 10)
        media = value
}
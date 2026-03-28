using ArrayConta;
//declarar o vetor
Conta[] vetConta = new Conta[3];
//laço de repetição para controla cada índice
for(int i = 0; i < vetConta.Length; i++)
{
    //instancia de cada índice
    vetConta[i] = new Conta();
    //cadastrar os atributos
    Console.Write("Digite o número: ");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetConta[i].titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}
// foreach (var c item in vetConta)
// {
//     c.MostrarAtributos();
// }

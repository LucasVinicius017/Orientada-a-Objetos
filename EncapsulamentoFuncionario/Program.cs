using EncapsulamentoFuncionario;

//Fazer 2 insância e digitar
//criar o método CalculaAumento() que 
//terá um parâmetro da porcentagem
//criar o método Mostrar atributos()
Funcionario f1 = new Funcionario();
Console.Write("Digite o código: ");
f1.Codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f1.Nome = Console.ReadLine();
COnsole.Write("Digite o salário: ");
f1.Salrio = Convert.ToDecimal(Console.ReadLine());
f1.MostrarAtributos();
f1.CalculaAumento(5);
f1.MostrarAtributos();


int idade = 18; // operador ternário
string texto = (idade >= 18)? "Maior idade":"Menor idade";
System.Console.WriteLine(texto);
if (idade >= 18)
    Console.WriteLine("Maior idade");
else
    Console.WriteLine("Menor idade");
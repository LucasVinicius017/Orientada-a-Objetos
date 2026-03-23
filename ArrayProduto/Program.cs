using ArrayProduto;
Produto[] vetProduto = new Produto[3];
for (int i = 0; i < vetProduto.Length; i++)
{
    vetProduto[i] = new Produto();
    Console.Write("Digite o Código: ");
    vetProduto[i].codigo = Console.ReadLine();
    Console.Write("Digite o Nome: ");
    vetProduto[i].nome = Console.ReadLine();
    Console.Write("Digite o Preço: ");
    vetProduto[i].preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a Quantidade: ");
    vetProduto[i].qtde = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o Total: ");
    vetProduto[i].total = Convert.ToDouble(Console.ReadLine());

foreach (var p in vetProduto)
{
    Console.Write("Digite o aumento: ");
    double porc = Convert.ToDouble(Console.ReadLine());
    p.CalcularAumento(porc);
    
    Console.Write("Digite a saída do estoque: ");
    double sai = Convert.ToDouble(Console.ReadLine());
    p.CalcularBaixaEstoque(sai);

    Console.Write("Digite a entrada do estoque: ");
    double ent = Convert.ToDouble(Console.ReadLine());
    p.CalcularEntradaEstoque(ent);    
}

}

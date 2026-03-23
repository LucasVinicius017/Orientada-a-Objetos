using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        //criar os atributos: código, nome
        public string codigo;
        public string nome;
        //preço, qtde, total
        public double aumento;
        public double porc;
        public double preco;
        public double qtde;
        public double total;
        //criar os métodas: MostraAtributos()
        public void MostraAtributos()
        {
            Console.WriteLine($"Codigo: {codigo} \tNome: {nome} \tPreço: {preco:2} \tQuantidade: {qtde} \tTotal: {total:2}");
        }
        //CalcularAumento(), a porcentagem é
        //um parâmetro e aplicar no preço
        public void CalcularAumento(double porc)
        {
            aumento = preco * (porc / 100);
            preco = preco + aumento;
      
        }
        //CalcularBaixaEstoque(), usar parâmetro
        //para calcular a baixar
        public void CalcularBaixaEstoque(double sai)
        {
            qtde = qtde - sai;
        }
        //CalcularEntradaEstoque(), usar parâmetro
        //para acrescentar no estoque
        public void CalcularEntradaEstoque(double ent)
        {
            qtde = qtde + ent;
        }
        //use um vetor de 3 posições
    }
}
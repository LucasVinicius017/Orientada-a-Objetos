using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAluno
{
    public class Aluno
    {
        // Cria os atributos:
        // ra, nome, p1, p2 e média
        // Criar as funções/métodos
        // MostrarAtributos()
        // CalcularMédia(), não tem parâmetro
        // e não tem retorno
        // Na Main() digite valores para 
        // dois objetos.
        public string ra;

        public string nome;

        public double p1, p2, media;

        public void CalcularMédia()
        {
            media = (p1 + p2) / 2; 
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Ra: " + ra + 
            "\tNome: " + nome + 
            "\tP1: " + p1 + 
            "\tP2: " + p2 + 
            "\tMédia: " + media);
        }

    }
}
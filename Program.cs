using System;

namespace Aula16
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Sapato = new Produto("Adidas", "branco, um cadarço extra tamanho 33", 55, 505050);
            Console.WriteLine($"Nome:{Sapato.Nome} - Descrição:{Sapato.Descricao ?? null} "+
                                $"Estoque:{Sapato.Estoque} - Código:{Sapato.Codigo}");
        }
    }
}

using System;
using System.Globalization;

namespace fazendo_um_app_com_orientacao_obj___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
           
            Console.WriteLine();
           
            Console.Write("Digite o numero de produtos a serem adicionados no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.Adiciona(qtd);
           
            Console.WriteLine();

            Console.Write("dados atualizado no estoque: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a serem removidos no estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.Remove(qtd);
            
            Console.WriteLine();

            Console.Write("dados atualizado no estoque: " + p);

            Console.WriteLine();


        }




    }
}

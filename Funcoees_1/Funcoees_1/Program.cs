using System;

namespace Funcoees_1
{
    class Program
    {
        static int Maior(int a, int b, int c)
        {
 
            if (a > b && a > c)
                return a;
            else if (b > c)
                return b;
            else
                return c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

    }
}

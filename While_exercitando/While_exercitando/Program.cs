using System;

namespace While_exercitando
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            while (numero >= 0)
            {
                Console.Write("Digite um numero para saber sua raiz quadrada: ");
                numero = double.Parse(Console.ReadLine());
                Console.WriteLine("Raiz quadrada de " + numero + " = " + Math.Sqrt(numero).ToString("F3"));
            }
            Console.WriteLine("Programa finalizado. Numero negativo.");
        }
    }
}


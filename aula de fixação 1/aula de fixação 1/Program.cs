using System;
using System.Globalization;

namespace aula_de_fixação_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            int result;

            num = int.Parse(Console.ReadLine());

            result = num % 2;
            if(result == 0)
                Console.WriteLine("Numero par");   
            else
                Console.WriteLine("Numero impar");
           

        }
    }
}

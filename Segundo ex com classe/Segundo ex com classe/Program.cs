using System;
using System.Globalization;

namespace Segundo_ex_com_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler nome e salario de dois funcionarios.
            //Depois mostrar o salario medio dos funcionarios.

            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.Salario + b.Salario) / 2;

            Console.WriteLine("Salario medio = " + media.ToString("F2"));

        }
    }
}

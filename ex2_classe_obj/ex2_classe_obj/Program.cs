using System;
using System.Globalization;

namespace ex2_classe_obj {
    class Program {
        static void Main(string[] args) {
            /*
             * Fazer um programa para ler os dados de um funcionário (nome,
                salário bruto e imposto). Em seguida, mostrar os dados do
                funcionário (nome e salário líquido). Em seguida, aumentar o salário
                do funcionário com base em uma porcentagem dada (somente o
                salário bruto é afetado pela porcentagem) e mostrar novamente os
                dados do funcionário. Use a classe projetada abaixo.
              */

            Funcionario x = new Funcionario();
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(x);

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine());
            x.AumentarSalario(aumento);

            Console.WriteLine(x);



        }
    }
}

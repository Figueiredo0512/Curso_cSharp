using System;
using System.Globalization;

namespace ex3_classe_obj {
    class Program {
        static void Main(string[] args) {

            Aluno x = new Aluno();

            Console.Write("Nome do aluno: ");
            
            x.Nome = Console.ReadLine();
            x.Nota_1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.Nota_2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.Nota_3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            x.Situacao();

            Console.WriteLine(x);

        }
    }
}

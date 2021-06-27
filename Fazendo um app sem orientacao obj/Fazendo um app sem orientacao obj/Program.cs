using System;
using System.Globalization;

namespace Fazendo_um_app_sem_orientacao_obj
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do tringulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p;
            double areax, areay;

            p = (x.A+ x.B + x.C) / 2.0;
            areax = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;
            areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X = " + areax.ToString("F4" , CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areay.ToString("F4" , CultureInfo.InvariantCulture));
            Console.Write("Maior area: ");

            if(areay < areax)
                Console.WriteLine("X");
            else
                Console.WriteLine("Y");


        }
    }
}

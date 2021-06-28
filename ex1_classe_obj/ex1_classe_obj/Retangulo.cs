using System;
using System.Globalization;

namespace ex1_classe_obj {
    class Retangulo {
        public double Largura;
        public double Altura;
    
        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal() {
            return Math.Sqrt(((Largura * 2) + (Altura * 2)));
        }


        public override string ToString() {
            return "Area = " + Area() + "\r\n" + 
                   "Perimetro = " + Perimetro() + 
                   "\r\nDiagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture) ;
        }

    }


}

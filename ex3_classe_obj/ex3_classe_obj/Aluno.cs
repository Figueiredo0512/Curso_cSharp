using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex3_classe_obj {
    class Aluno {

        public string Nome;
        public double Nota_1;
        public double Nota_2;
        public double Nota_3;
        public double Media = 0.0;
        public double Resta;

        public void Situacao() {
            Media = (Nota_1 + Nota_2 + Nota_3) / 3;
        }


        public override string ToString() {
            if (Media < 50.00) {
                Resta = 50 - Media;
                return "Reprovado!\r\nFaltaram " + Resta.ToString("F2", CultureInfo.InvariantCulture) + " Pontos";
            }
            else {
                return "Nota Final: " + Media.ToString("F2", CultureInfo.InvariantCulture) + "\r\nAprovado!";
            }
        }
    }
}

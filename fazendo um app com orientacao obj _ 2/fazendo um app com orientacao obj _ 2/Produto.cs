using System;
using System.Globalization;

namespace fazendo_um_app_com_orientacao_obj___2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public double Valor_Total()
        {
            return Preco * Qtd;
        }


        public void Adiciona(int quantidade)
        {
            Qtd = Qtd + quantidade;
        }

        public void Remove(int quantidade)
        {
            Qtd = Qtd - quantidade;
        }


        public override string ToString()
        {
            return Nome +
                ", R$" +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + Qtd + " Unidades, Total: R$"
                + Valor_Total().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

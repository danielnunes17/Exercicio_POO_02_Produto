using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO_02_Produto
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() => Preco * Quantidade;

        public void AdcionarProdutos(int quantidade) => Quantidade += quantidade;

        public void RemoverProdutos(int quantidade) => Quantidade -= quantidade;

        public override string ToString()
        {
            return Nome + ", " +
                "R$: " +
                Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " +
                Quantidade +
                " unidades, Total: R$" +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

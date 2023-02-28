/*Fazer um programa para ler os dados de um produto em estoque (nome, preço e
quantidade no estoque). Em seguida:
• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
estoque)
• Realizar uma entrada no estoque e mostrar novamente os dados do produto
• Realizar uma saída no estoque e mostrar novamente os dados do produto
Para resolver este problema, você deve criar
uma CLASSE conforme projeto ao lado:
Entre os dados do produto:
Nome: TV
Preço: 900.00
Quantidade no estoque: 10
Dados do produto: TV, $ 900.00, 10 unidades, Total: $ 9000.00
Digite o número de produtos a ser adicionado ao estoque: 5
Dados atualizados: TV, $ 900.00, 15 unidades, Total: $ 13500.00
Digite o número de produtos a ser removido do estoque: 3
Dados atualizados: TV, $ 900.00, 12 unidades, Total: $ 10800.00*/

using Exercicio_POO_02_Produto;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Digite a quantidade do produto: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidade);

        Console.WriteLine("Dados do produto: " + produto + "\n");

        Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
        int adicionarQtd = int.Parse(Console.ReadLine());
        produto.AdcionarProdutos(adicionarQtd);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto + "\n");

        Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
        int subtrairQtd = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(subtrairQtd);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto);
    }
}
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.23456700;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2);
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine("Medida com seis casas decimais: " + medida);
            Console.WriteLine("Arredondado com três casas decimais: " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
using System;
using System.Globalization;

namespace TarefaDois
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);
            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine(quartos);
            Console.WriteLine("Diga o valor do seu produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(produto);
            Console.WriteLine("Diga seu ultimo nome, idade e altura:");

            string[] vetor = Console.ReadLine().Split(" ");
            string nome1 = vetor[0];
            int idade1 = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            
            Console.WriteLine(nome1);
            Console.WriteLine(idade1);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}



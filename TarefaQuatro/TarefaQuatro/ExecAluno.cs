using System;


namespace TarefaQuatro {
    internal class ExecAluno {
        public static void ExecutarAluno() {
            Aluno a1, a2;
            a1 = new Aluno();
            a2 = new Aluno();

            Console.WriteLine("Digite seu nome:");
            a1.nome = Console.ReadLine();
            Console.WriteLine("Digite suas três notas:");
            a1.nota1 = int.Parse(Console.ReadLine());
            a1.nota2 = int.Parse(Console.ReadLine());
            a1.nota3 = int.Parse(Console.ReadLine());

            int notaFinal1 = a1.notaFinal(a1.nota1,a1.nota2,a1.nota3);

            a1.aprovado(notaFinal1);
            //Aluno 2
            Console.WriteLine("Digite seu nome:");
            a2.nome = Console.ReadLine();
            Console.WriteLine("Digite suas três notas:");
            a2.nota1 = int.Parse(Console.ReadLine());
            a2.nota2 = int.Parse(Console.ReadLine());
            a2.nota3 = int.Parse(Console.ReadLine());

            int notaFinal2 = a2.notaFinal(a2.nota1, a2.nota2, a2.nota3);

            a2.aprovado(notaFinal2);

        }
    }
}

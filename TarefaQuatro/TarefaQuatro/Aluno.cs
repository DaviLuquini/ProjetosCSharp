using System;


namespace TarefaQuatro {
    internal class Aluno {
        public string nome;
        public int nota1;
        public int nota2;
        public int nota3;

        public int notaFinal(int nota1, int nota2, int nota3) {
            return (nota1 + nota2 + nota3);
        }

        public void aprovado(int notaFinal) {
            if(notaFinal >= 60) {
                Console.WriteLine("Nota Final:" + notaFinal);
                Console.WriteLine("Aprovado!");
            } else {
                int pontosMenos = 60 - notaFinal;
                Console.WriteLine("Nota Final:" + notaFinal);
                Console.WriteLine("Reprovado por " + pontosMenos + " pontos");
            }
        }
    }
}

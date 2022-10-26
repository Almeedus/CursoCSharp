using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharpZTP.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;

        public Aluno(string nome, int idade, double nota) {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
    }

    internal class LINQ {
        public static void Executar() {
            //Linguagem de consulta integrada == LINQ

            var alunos = new List<Aluno>() {
                new Aluno ("Pedro", 24, 8.1),
                new Aluno ("Andre", 21, 4.3),
                new Aluno ("Ana", 25, 9.5),
                new Aluno ("Jorge", 20, 8.5),
                new Aluno ("Ana", 21, 7.7),
                new Aluno ("Julia", 22, 7.5),
                new Aluno ("Marcio", 18, 6.8),
            };


            //filter
            Console.WriteLine("==APROVADOS=================");
            //Criando uma nova lista onde só entrarão os alunos (a) com uma nota maior que 7, depois será ordenado por nome
            var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => a.Nome);

            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            //MAP = transformar um array em outro array
            Console.WriteLine("==CHAMADA===================");
            //Transformando o objeto aluno em uma string só com o nome
            //Select faz essa transformação
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            foreach (var aluno in chamada) {
                Console.WriteLine("  [  ]   {0}",aluno);
            }


            Console.WriteLine("==APROVADOS POR IDADE=======");

            //Parecido com comandos SQL
            //Da variavel aluno dentro da lista alunos, onde a nota do aluno é igual ou maior que sete
            //ordenando pelo nome, retorne uma lista de string dos nomes
            var nomeAlunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Nota
                select aluno.Nome;

            var notaAlunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Nota
                select aluno.Nota;

            foreach (var aluno in nomeAlunosAprovados) {
                Console.Write($"{aluno}  ");
            }
            Console.WriteLine();
            foreach (var nota in notaAlunosAprovados) {
                Console.Write($" {nota}  ");
            }
            Console.WriteLine();
        }
    }
}
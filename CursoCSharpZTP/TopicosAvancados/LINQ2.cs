using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.TopicosAvancados {
    internal class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno>() {
                new Aluno ("Pedro", 24, 8.1),
                new Aluno ("Andre", 21, 4.3),
                new Aluno ("Ana", 25, 9.5),
                new Aluno ("Jorge", 20, 8.5),
                new Aluno ("Ana", 21, 7.7),
                new Aluno ("Julia", 22, 7.5),
                new Aluno ("Marcio", 18, 6.8),
            };

            //Procura pelo nome Ana e se não encontrar devolve um valor default "Null"
            Console.Write("Informe um aluno para pesquisa: ");
            string aluno1 = Console.ReadLine();
            var pesquisa = alunos.FirstOrDefault(aluno => aluno.Nome.Equals(aluno1));

            if (pesquisa == null) {
                Console.WriteLine("Aluno não encontrado");
            } else {
                Console.WriteLine($"{pesquisa.Nome} - {pesquisa.Nota}");
            }
        }
    }
}

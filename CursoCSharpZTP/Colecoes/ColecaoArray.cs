using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Colecoes {
    internal class ColecaoArray {
        public static void Executar() {
            //Array é uma estrutura indexada, com inicio no 0
            //Array é uma estrutura homogenea, de um só tipo
            //Array é uma estrutua estática, ela não crescerá com a quantidade de elementos
            string[] alunos = new string[5];
            //<tipo>[] <nomeArray> = new <tipo>[tamanho]

            alunos[0] = "Eduardo";
            alunos[1] = "Bianca";
            alunos[2] = "Bruna";
            alunos[3] = "Beatriz";
            alunos[4] = "Hellen";

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}

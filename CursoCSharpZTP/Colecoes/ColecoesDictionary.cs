using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Colecoes {
    internal class ColecoesDictionary {
        public static void Executar() {
            //Chave (int): valor (string)   -> EXEMPLO
            //Dicionario aceita repetição no valor e não na chave
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Os incriveis");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Gladiador");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {

                Console.WriteLine($"2004: {filmes[2004]}");
            }
            Console.WriteLine($"Removeu: {filmes.Remove(2004)}");

            //percorrendo o dicionario
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            //Percorrendo valores
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            //Percorrer chave e valor - HARD
            foreach (KeyValuePair<int, string> movie in filmes) {
                Console.WriteLine($"{movie.Value} é de {movie.Key}");
            }

            //Percorrendo chave e valor - IZ
            foreach (var movies2 in filmes) {
                Console.WriteLine($"{movies2.Value} é de {movies2.Key}");
            }   

            Console.WriteLine($"2004: {filmes.TryGetValue(2004, out string filmeOut)}");
        }
    }
}

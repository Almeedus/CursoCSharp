using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Colecoes {
    internal class ColecaoSet {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);


            //Set não é indexada
            //Não aceita repetição
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro); //adiciona apenas um

            var combo = new HashSet<Produto> {
                new Produto ("Camisa", 29.9),
                new Produto ("8ª Temporada de Game of Thrones", 99.9),
                new Produto ("Poster", 10)
            };

            carrinho.UnionWith(combo);

            foreach (var produto in carrinho) {
                Console.WriteLine($"Produto: {produto.Nome} - {produto.Preco:C2}");
            }
        }
    }
}

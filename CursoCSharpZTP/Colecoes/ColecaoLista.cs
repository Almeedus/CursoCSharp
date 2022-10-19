using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto( string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return base.Equals(obj);
        }
        public override int GetHashCode() {
            return Nome.Length;
        }

        public Produto() { }

    }
    internal class ColecaoLista {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);
            //A lista aceita repetição de elementos

            //Aqui estou declarando uma lista especifica com o valor
            //do tipo PRODUTO

            //Para usar o generics em uma lista precisa passar o tipo
            //do dado entre sinal de maior e menor <tipoGenerics>
            var carrinho = new List<Produto>();
            carrinho.Add(livro); //adiciona apenas um

            var combo = new List<Produto>() {
                new Produto ("Camisa", 29.9),
                new Produto ("8ª Temporada de Game of Thrones", 99.9),
                new Produto ("Poster", 10)
            };

            carrinho.AddRange(combo); //adiciona mais de uma variavel

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" - {item.Nome}: {item.Preco:C2}");
            }
        }
    }
}

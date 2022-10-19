using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Colecoes {
    internal class ColecaoIgualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.9);
            var p2 = new Produto("Caneta", 1.9);

            Console.WriteLine(p1 == p2); //comparar endereço de memória

            Console.WriteLine(p1.Equals(p2)); //comparando o conteúdo, lembre de usar o override na classe que criar
        }
    }
}

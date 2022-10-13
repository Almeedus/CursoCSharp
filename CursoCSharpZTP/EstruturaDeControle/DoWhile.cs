using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.EstruturaDeControle {
    internal class DoWhile {
        public static void Executar() {
            int c = 1, soma = 0;

            do {
                Console.Write($"{c}-");
                soma += c;
                c++;
            }
            while (c <= 10);

            Console.Write(soma);
            Console.WriteLine();
        }
    }
}

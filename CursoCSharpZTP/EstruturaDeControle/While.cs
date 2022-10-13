using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.EstruturaDeControle {
    internal class While {
        public static void Executar() {
            int c = 1, soma = 0;

            while(c <= 10) {
                Console.Write($"{c}-");
                soma += c;
                c++;
            }
            Console.Write(soma);
            Console.WriteLine();
        }
    }
}

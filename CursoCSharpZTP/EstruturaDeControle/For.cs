using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.EstruturaDeControle {
    internal class For {
        public static void Executar() {
            int num = 2;

            for (int i = 0; i <= 10; i++) {
                if (i == 0) {
                    Console.Write($"{num} +");
                } else {
                    if (i <= 9) {
                        Console.Write($"+ {num} ");
                    } else {
                        Console.Write($"= {num}");
                        break;
                    }
                }
                num += num;
            }
        Console.WriteLine();
        }
    }
}


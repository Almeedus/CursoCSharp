 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.EstruturaDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            int num1 = 1;
            int num2 = 2;

            if (num1 < num2) {
                Console.WriteLine($"{num1} < {num2} = {num1<num2}");
            }
        }
    }
}

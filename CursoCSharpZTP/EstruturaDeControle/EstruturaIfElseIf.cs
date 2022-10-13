using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.EstruturaDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Informe uma nota: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 9) {
                Console.WriteLine("Parabens pela sua nota!!");
            } else {
                if (nota >= 7) {
                    Console.WriteLine("Boa, sua nota está acima da média");
                } else {
                    Console.WriteLine("Mano, bora estudar!! sua nota está péssima!");
                }
            }
        }
    }
}

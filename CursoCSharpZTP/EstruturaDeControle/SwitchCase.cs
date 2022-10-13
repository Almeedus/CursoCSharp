using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.EstruturaDeControle {
    internal class SwitchCase {
        public static void Executar() {
            Console.WriteLine("Qual sua nota para o sistema?");
            Console.WriteLine("0 - 1 - 2 - 3 - 4 - 5");
            int resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta) {
                case 0:
                    Console.WriteLine("0 - 1 - 2 - 3 - 4 - 5");
                    Console.WriteLine("^");
                    Console.WriteLine("Horrivel");
                    break;
                case 1:
                    Console.WriteLine("0 - 1 - 2 - 3 - 4 - 5");
                    Console.WriteLine("    ^");
                    Console.WriteLine("    Ruim!");
                    break;
                case 2:
                    Console.WriteLine("0 - 1 - 2 - 3 - 4 - 5");
                    Console.WriteLine("        ^");
                    Console.WriteLine("        Ruim!");
                    break;
                case 3:
                    Console.WriteLine("0 - 1 - 2 - 3 - 4 - 5");
                    Console.WriteLine("            ^");
                    Console.WriteLine("            Bom!");
                    break;
                case 4:
                    Console.WriteLine("0 - 1 - 2 - 3 - 4 - 5");
                    Console.WriteLine("                ^");
                    Console.WriteLine("                Perfeito!");
                    break;
                case 5:
                    Console.WriteLine("0 - 1 - 2 - 3 - 4 - 5");
                    Console.WriteLine("                    ^");
                    Console.WriteLine("                    Excelente!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Fim da pesquisa!");
        }
    }
}

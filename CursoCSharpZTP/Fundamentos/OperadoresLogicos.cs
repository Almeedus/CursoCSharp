using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            bool trab1 = true, trab2 = false;

            Console.WriteLine($"Comprou uma TV50: {trab1 && trab2}"); // && - e
            Console.WriteLine($"Comprou um sorvete: {trab1 || trab2}"); // || - ou
            Console.WriteLine($"Comprou uma TV32: {trab1 ^ trab2}"); // ^ - ou exclusivo
            Console.WriteLine($"Mais saudável se não comprar sorvete?: {!(trab1 || trab2)}"); // ! - negação
        }
    }
}

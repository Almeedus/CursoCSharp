using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class VariavelEConstantes {
        public static void Executar() {
            //iniciando variavel
            int num = 1;

            Console.WriteLine("Número qualquer");
            Console.WriteLine(num + " -> exemplo de variavel que pode ser alterada");
            //iniciando constant
            const double pi = 3.1415;

            Console.WriteLine();

            Console.WriteLine("Valor de Pi");
            Console.WriteLine(pi + " -> exemplo de constante que não pode ser alterada");
        }
    }
}

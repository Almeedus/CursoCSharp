using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            //Operadores de comparação -> Retorna True or False

            /* SIMBOLOS DOS OPERADORES RELACIONAIS
             * > maior que
             * < menor que
             * == igual que
             * != diferente que
             * >= maior igual que
             * <= menor igual que
             */

            int numero = 1, numero2 = 2;

            Console.WriteLine($"1 é maior que 2: {numero > numero2}");
            Console.WriteLine($"1 é menor que 2: {numero < numero2}");
            Console.WriteLine($"1 é igual que 2: {numero == numero2}");
            Console.WriteLine($"1 é menor igual que 2: {numero <= numero2}");
            Console.WriteLine($"1 é maior igual que 2: {numero >= numero2}");
        }
    }
}

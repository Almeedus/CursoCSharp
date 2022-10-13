using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            //Quantidade de operandos - 1

            int valorNeg = -5;
            int num1 = 2;
            int num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNeg); // negação
            Console.WriteLine(!booleano); // negação
            Console.WriteLine(num1++); // precedencia menor
            Console.WriteLine(--num1); // precedencia maior

            Console.WriteLine(num1++ == --num2);
            Console.WriteLine("{0} | {1}",num1, num2);
        }
    }
}

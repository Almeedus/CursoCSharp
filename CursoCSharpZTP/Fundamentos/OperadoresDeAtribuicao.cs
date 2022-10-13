using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class OperadoresDeAtribuicao {
        public static void Executar() {
            //Operadores de atribuição

            var num1 = 3; //atribuindo o valor de 3
            Console.WriteLine(num1);

            num1 += 10; //igual a num1 = num1 + 10
            Console.WriteLine(num1);

            num1 -= 3; //igual a num1 = num1 - 3
            Console.WriteLine(num1);

            num1 *= 3; //igual a num1 = num1 * 5
            Console.WriteLine(num1);

            num1 /= 3; //igual a num1 = num1 / 2
            Console.WriteLine(num1);
        }
    }
}

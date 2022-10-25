using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.FuncoesMetodos {
    //delegate define o tipo de parametros para que nao sejam necessarios informar o tipo nos parametros da função
    delegate double Operacao(double x, double y);

    internal class DelegateLambda {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(2,3));
            Console.WriteLine(sub(2,3));
            Console.WriteLine(mult(2,3));
        }
    }
}

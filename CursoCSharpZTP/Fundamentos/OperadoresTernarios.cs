using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class OperadoresTernarios {
        public static void Executar() {
            var nota = 7.0;
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
        }
    }
}

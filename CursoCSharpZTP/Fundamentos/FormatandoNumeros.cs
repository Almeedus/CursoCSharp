using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            int inteiro = 256;
            CultureInfo cultura = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            Console.WriteLine(valor.ToString("C3", cultura));

            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    internal class ParametrosNomeados {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
        }
        public static void Executar() {
            //passar por parametro nomeado
            Formatar(mes: 1, dia: 6, ano: 2022);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.EstruturaDeControle {
    internal class ForEach {
        public static void Executar() {
            //usado igual o for, mas sem a parte de incremento
            //usado para percorrer variaveis

            var nomes = new string[] {"Mariana", "Bianca", "Luciana", "Emanuelle" }; 

            foreach (string pessoa in nomes) {
                Console.WriteLine(pessoa);
            }
        }
    }
}

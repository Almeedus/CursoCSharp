using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class InferenciaDeTipos {
        public static void Executar() {
            //inferencia == deduzir o tipo

            var nome = "Eduardo";
            // deduziu que o tipo da variavel nome é string

            int num;
            num = 1;
            //criei a variavel primeiro e dps atribui um tipo

            bool verdadeiro = true;
            //criando a variavel e atribuindo o valor na mesma linha


            Console.WriteLine(nome +" "+ num + " " + verdadeiro);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.TopicosAvancados {
    internal class VariaveisDinamicas {
        public static void Executar() {
            dynamic meuObjeto = "teste";
            meuObjeto = 10;
            meuObjeto++;
            Console.WriteLine(meuObjeto);
        }
    }
}

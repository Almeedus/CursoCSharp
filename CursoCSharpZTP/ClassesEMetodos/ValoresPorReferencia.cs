using System;


namespace CursoCSharpZTP.ClassesEMetodos {
    internal class ValoresPorReferencia {
        public static void AlterarRef(ref int numero) { //preciso colocar "ref" aqui tbm
            numero += 1000;
        }
        public static void AlterarOut(out int numero) {
            numero = 0;
            numero += 15;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a); //alterando o valor pela referencia
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b); // Unidirecional, ele só recebe e não envia valor algum
            Console.WriteLine(b);
        }
    }
}

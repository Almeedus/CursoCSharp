using System;


namespace CursoCSharpZTP.ClassesEMetodos {
    internal class DesafioAcessarAtributo {
        int a = 10;

        public static void Executar() {
            //Acessar a variavel "a" mexendo só no método Executar



            //minha resolução
            DesafioAcessarAtributo numero = new DesafioAcessarAtributo();
            int num1 = numero.a;
            Console.WriteLine(num1);

            Console.WriteLine();

            //Resolução do vídeo
            DesafioAcessarAtributo desafio = new DesafioAcessarAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}

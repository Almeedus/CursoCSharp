using System;
using Encapsulamento;

namespace CursoCSharpZTP.OrientacaoObjetos {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("| FILHO NÃO RECONHECIDO |");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine();
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("| AMIGO DISTANTE |");
            Console.WriteLine(amigo.InfoPublica);
            Console.WriteLine();
        }
    }

    public class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}

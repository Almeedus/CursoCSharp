using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace CursoCSharpZTP.API {
    internal class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var LeituraDir = @"C:\Users\Touch\Documents\CursoCSharp";


            //Verifica se ja existe, se sim ele exclui de forma recursiva (apaga a pasta e tudo o que tiver dentro subsequente)
            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }

            //Criando uma pasta
            Directory.CreateDirectory(novoDir);
            //Informa a data de criação
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("====Pastas========================");
            var pastas = Directory.GetDirectories(LeituraDir);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            //Listando os arquivos dentro da pasta
            var arquivos = Directory.GetFiles(LeituraDir);
            Console.WriteLine("====Arquivos======================");
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }
        }
    }
}

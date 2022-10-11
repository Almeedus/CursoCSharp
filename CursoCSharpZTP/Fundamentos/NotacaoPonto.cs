using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá ".Insert(4, "World!").Replace("World!", "Mundo!").ToUpper();
            Console.WriteLine($"{saudacao}");

            string valorImportante = null;
            Console.WriteLine($"Não imprimi nada {valorImportante?.Length}");
        }
    }
}

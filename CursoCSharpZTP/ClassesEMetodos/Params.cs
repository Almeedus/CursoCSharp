using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    internal class Params {

        public static void Recepcionar(params string [] pessoas) {
            //Posso por ser um array, criar um foreach para percorrer todos os itens
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Seja Bem-vindo(a) {pessoa}");
            }
        }

        public static void Executar() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Informe o {i+1}º nome");
                Recepcionar(Console.ReadLine());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class LendoDadosDoConsole {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine($"{nome} qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} qual é o seu salario? R$");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Prazer {nome}, fico feliz que com {idade} anos você esteja ganhando R${salario}.");
        }
    }
}

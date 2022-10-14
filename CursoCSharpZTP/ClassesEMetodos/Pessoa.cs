using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    internal class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar(String Nome, int Idade) {
            if (Nome != "" && Idade != 0) {
                return string.Format($"Meu nome é {Nome} e tenho {Idade} anos");
            } else {
                return string.Format($"Não é possivel retornar um campo vazio");
            }
        }


        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar(Nome, Idade));
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}

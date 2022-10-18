using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace CursoCSharpZTP.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        private readonly DateTime Nascimento; //torna ele imutavel, nao poderá mudar mais
        //possibilita eu mudar o valor dentro do construtor

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }
        
        public string GetDataDeNascimento() {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    internal class Readondly {

        public static void Executar() {

            var Cliente1 = new Cliente( "Bianca", new DateTime(1987, 5, 22));

            Console.WriteLine(Cliente1.Nome);
            Console.WriteLine(Cliente1.GetDataDeNascimento());
        }
    }
}

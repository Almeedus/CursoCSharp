using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.OrientacaoObjetos {
    public class Animal {
        public string Nome { get; set; } //get : pegar um valor | set : alterar um valor

        public Animal(string nome) {
            Nome = nome;
        }

    }

    public class Cachorro : Animal {
        public double Altura { get; set; }
                                     //Pelo menos um dos construtores precisa chamar o construtor base(PAI)
        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }
                                                    //This pega o construtor pai para alterar o Nome do cachorro
        public Cachorro(string nome, double altura) : this(nome) {
        //Após alterado o nome pelo construtor pai, ele continua alterando dentro do próprio construtor a altura do cachorro
            Altura = altura;
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        //Sobrescrevendo uma classe chamada ToString que faz a conversão de todo o conteudo para uma string
        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }

    internal class ConstrutorThis {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            Cachorro max = new Cachorro("Max", 40f);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}

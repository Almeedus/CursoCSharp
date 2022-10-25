using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.OrientacaoObjetos {
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
        public Comida() { }
    }

    public class Feijao : Comida {
        public Feijao(double Peso) : base(Peso) { }
    }

    public class Arroz : Comida {
        public Arroz(double Peso) : base(Peso) { }
    }
    public class Carne : Comida {
        public Carne(double Peso) : base(Peso) { }
    }

    public class Pessoa {
        public double Peso; 
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }

        public Pessoa(double peso) {
            Peso = peso;
        }
    }




    internal class Polimorfismo {
        public static void Executar() {
            Feijao ingrediente1 = new Feijao(0.3);
            Arroz ingrediente2 = new Arroz(0.25);
            Carne ingrediente3 = new Carne(0.3);

            Pessoa cliente = new Pessoa(80.2);

            Console.WriteLine($"O peso de Eduarda é {cliente.Peso}");
            Console.WriteLine($"Eduarda comeu um feijão");
            cliente.Comer(ingrediente1);
            Console.WriteLine();
            Console.WriteLine($"O peso de Eduarda atualizou para {cliente.Peso}");
            Console.WriteLine($"Eduarda comeu um arroz");
            cliente.Comer(ingrediente2);
            Console.WriteLine();
            Console.WriteLine($"O peso de Eduarda atualizou para {cliente.Peso}");
            Console.WriteLine($"Eduarda comeu um carne");
            cliente.Comer(ingrediente3);
        }
    }
}

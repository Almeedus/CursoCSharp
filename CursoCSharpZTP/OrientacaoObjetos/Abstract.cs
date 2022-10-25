using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.OrientacaoObjetos {
    //Classes abstratas não podem ser instanciadas 
    //Classes abstratas precisam ser implementada
    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim Trim Trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Sam";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri";
        }
    }

    internal class Abstract {
        public static void Executar() {
            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}

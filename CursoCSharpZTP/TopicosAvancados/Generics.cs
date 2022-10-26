using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.TopicosAvancados {
    public class Caixa<T> {
                                                    //Exemplos
        //Atributo do tipo T
        T valorPrivado;

        //Propriedade do tipo T
        public T Coisa { get; set; }

        //Tipo genérico T em um construtor
        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        //método Tipo genérico T que retorna um tipo genérico T
        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        //Outro método que retorna um tipo T
        public T GetValor() {
            return valorPrivado;
        }
    }

    //Criando uma caixa que recebe por herança o valor T e altera para int
    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) { }
    }

    internal class Generics {
        public static void Executar() {
            //passando caixa como int
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));

            //passando caixa como string
            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
        }
    }
}

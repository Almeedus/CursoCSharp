using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ExcecaoTratamentoErro {
    //Para criar uma propria exceção, precisa criar uma relação de "é um", gerando uma herança de Exception

    public class NegativeException : Exception {
        //Construtor padrão
        public NegativeException() { }

        //Construtor padrão que tem como parametros uma mensagem que se baseia no construtor pai
        public NegativeException(string message) : base(message) { }

        //Construtor padrão que tem como parametros uma mensagem que se baseia no construtor pai
        //e uma Exceção para saber qual é a causa do erro
        public NegativeException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception {
        //Construtor padrão que tem como parametros uma mensagem que se baseia no construtor pai
        public ImparException(string message) : base(message) { }

    }
    internal class ExcecaoPersonalizada {

        public static int PositivoPar() {
            Random random = new Random();
            int num = random.Next(-30, 30);

            if (num < 0) {
                throw new NegativeException("Número negativo...");
            }

            if (num % 2 == 1) {
                throw new ImparException("Número impar...");
            }

            return num;
        }
        public static void Executar() {
            int num = PositivoPar();
            try {
                Console.WriteLine(num);
            } catch (NegativeException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Valor gerado: {0}", num);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.OrientacaoObjetos {
    interface OperacaoBinaria {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria {
        //obrigatoriamente o membro de uma interface precisa ser publico
        public int Operacao(int a, int b) => a + b;
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) => a - b;
    }

    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) => a * b;
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (var operacao in operacoes) {
                resultado += $"usando a {operacao.GetType().Name} = {operacao.Operacao(a,b)} \n";
            }

            return resultado;
        }
    }
    internal class Interface {
        public static void Executar() {
            var calculadora = new Calculadora();
            var resultado = calculadora.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}

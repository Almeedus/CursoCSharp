using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ExcecaoTratamentoErro {
    public class Conta {
        private double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                //Retornando uma exceção 
                //throw = "lançar" uma exceção e parar de forma bruta o método 
                //new = criando uma nova variavel
                //AgumentException = 
                throw new ArgumentException("Saldo Insuficiente");
            }

            Saldo -= valor;
        }
    }

    internal class PrimeiraExcessao {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            //try = tente fazer isso, é interessante passar o try para métodos que podem causar erros
            //Ele tenta fazer o bloco do try, caso de algum erro ele pega o bloco catch
            try {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com Sucesso");

            //bloco catch foi tratado no corpo do método sacar
            //sintaxe: catch (<TipoException> <NomeVariavel>) {BlocoDeCódigo}
            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);

            //ele termina sempre com o bloco FINALLY, mesmo que o bloco anterior seja catch ou try
            } finally {
                Console.WriteLine("thanks!");
            }
        }
    }
}

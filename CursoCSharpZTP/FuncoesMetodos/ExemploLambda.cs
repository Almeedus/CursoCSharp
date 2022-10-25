using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP {
    internal class ExemploLambda {
        public static void Executar() {
            //Arrow Function (=>)
            //Composta por (parametros) => {corpo da função}
            //Action é uma função que não tem retorno
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#");
            };
            algoNoConsole();

            //Função tem retorno
            //Função que randomiza a jogada de um dado
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            //Função que converte um inteiro para um HexaDecimal
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //Função que formata uma data
            Func<int, int, int, string> FormatarData = (dia, mes, ano) =>
            String.Format($"{dia:D2}/{mes:D2}/{ano:D4}");

            Console.WriteLine(FormatarData(12,23,2003));
        }
    }
}

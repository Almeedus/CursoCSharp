using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {

    class CalculadoraComum {

        public void Resposta(int a, int b) {
            Console.Write("0 - Adição | ");
            Console.WriteLine("1 - Subtração");
            Console.Write("2 - Multiplicação | ");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine();
            Console.Write("Informe a operação: ");
            string resp = Console.ReadLine();


            switch (resp) {
                case "0":
                    Console.WriteLine(Resultado(a, b, resp));
                    break;
                case "1":
                    Console.WriteLine(Resultado(a, b, resp));
                    break;
                case "2":
                    Console.WriteLine(Resultado(a, b, resp));
                    break;
                case "3":
                    Console.WriteLine(Resultado(a, b, resp));
                    break;
            }
        }

        public int Somar(int a, int b) => a + b;
        public int Subtrair(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;
        public int Dividir(int a, int b) => a / b;

        public string Resultado(int a, int b, string resp) {
            if (resp == "0") {
                return string.Format($"{a} + {b} = {Somar(a, b)}");
            } else {
                if (resp == "1") {
                    return string.Format($"{a} - {b} = {Subtrair(a, b)}");
                } else {
                    if (resp == "2") {
                        return string.Format($"{a} * {b} = {Multiplicar(a, b)}");
                    } else {
                        if (resp == "3") {
                            return string.Format($"{a} / {b} = {Dividir(a, b)}");
                        } else {
                            return string.Format($"Escolha Inválida");
                        }
                    }
                }
            }
        }
    }
    internal class MetodosComRetorno {
        public static void Executar() {

            Console.Write("Informe o primeiro valor inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            CalculadoraComum Calculadora = new CalculadoraComum();

            Calculadora.Resposta(num1, num2);


        }
    }
}

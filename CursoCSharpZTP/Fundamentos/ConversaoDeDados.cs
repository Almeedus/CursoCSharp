using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class ConversaoDeDados {
        public static void Executar() {

            //Conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine($"valor inteiro: {inteiro}");
            Console.WriteLine($"valor quebrado: {quebrado}");


            //Conversão explicita
            double nota = 9.7;
            int notaTruncada = (int)nota;

            Console.WriteLine($"A nota foi: {nota}");
            Console.WriteLine($"A nota sem virgula foi: {notaTruncada}");

            //Testes de aprendizado
            string nome = "1021";

            Console.WriteLine($"O numero {nome} é do tipo {nome.GetType()}");
            Console.WriteLine();

            // int numero = (int) nome;  -> Strings não podem ser convertidas em int desta forma, precisam do int.Parse() 
            int numero = int.Parse(nome);
            Console.WriteLine($"O numero {numero} é do tipo {numero.GetType()}");
            Console.WriteLine();

            double numero1 = Convert.ToDouble(nome);
            Console.WriteLine($"O numero {numero1} é do tipo {numero1.GetType()}");


            //SEM OTIMIZAÇÃO
            Console.WriteLine("Digite um número: ");
            string palavra = Console.ReadLine();
            int.TryParse(palavra, out int numeroConvertidoNome); //Não é preciso criar a variavel antes do 

            Console.WriteLine($"Resultado sem otimização {numeroConvertidoNome}");

            //OTIMIZADO
            Console.WriteLine("Digite outro número: ");
            int.TryParse(Console.ReadLine(), out int outroNumero);

            Console.WriteLine($"Resultado otimizado {outroNumero}");
        }
    }
}

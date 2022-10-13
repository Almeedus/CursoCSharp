using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            //Calculo Desconto de Preço -> soma, subtração e multiplicação
            var preco = 1000.0; //double
            var imposto = 355; // int
            var desconto = 0.1; //double

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto); // Na ordem de precedencia a * é feito primeiro que a -, mas para deixar melhor visivelmente, deixei dentro dos ()
 
            Console.WriteLine($"Total Desconto Preço: {total} - {total * desconto} = {totalDesconto}");

            //Calculo de IMC -> potencia e divisão
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);

            //Lembrando que o .ToString("N2") serve para e sua simplificação pode ser :N2
            Console.WriteLine($"Total IMC: {peso} / {Math.Pow(altura,2):N2} = {imc:N2}"); 

            //Calculo de Número Par/Impar  -> módulo (resto divisão)
            int par = 24;
            int impar = 13;

            bool ePar = par % 2 == 0; //True
            bool eImpar = impar % 2 == 0; //False

            Console.WriteLine($"O número {par} é Par? {ePar}");
            Console.WriteLine($"O número {impar} é Par? {eImpar}");
        }
    }
}

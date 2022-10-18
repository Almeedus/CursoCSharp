using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    public class Dependente {
        public string Nome;
        public int Idade;

    }

    internal class AtribuicaoValorEReferencia {
        public static void Executar() {
            //ints passam atribuição por valor
            int numero = 3;
            int copiaNumero = numero;

            Console.WriteLine($"{numero} = {copiaNumero}");
            numero++;
            Console.WriteLine($"{numero} != {copiaNumero}");



            //Classes passam atribuição por referencia 
            Dependente dependente1 = new Dependente() { 
                Nome = "Bianca",
                Idade = 18,
            };
            Dependente copiaDependente1 = dependente1;

            Console.WriteLine($"{dependente1.Nome} = {copiaDependente1.Nome}");
            Console.WriteLine($"{dependente1.Idade} = {copiaDependente1.Idade}");
            dependente1.Nome = "Bruna";
            copiaDependente1.Idade = 13;
            Console.WriteLine($"{dependente1.Nome} = {copiaDependente1.Nome}");
            Console.WriteLine($"{dependente1.Idade} = {copiaDependente1.Idade}");
        }
    }
}

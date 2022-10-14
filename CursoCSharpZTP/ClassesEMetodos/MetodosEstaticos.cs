using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    internal class MetodosEstaticos {

        //membro de instancia
        public int Somar(int a, int b) => a + b;


        //membro de objeto
        public static int Multiplicar(int a, int b) => a * b;

        public static void Executar() {
            var resultado = MetodosEstaticos.Multiplicar(2, 4); // usando o membro de objeto
            Console.WriteLine($"2 x 4 = {resultado}");




            MetodosEstaticos MetEstatico = new MetodosEstaticos(); //usando o membro de instancia 
            Console.WriteLine("2 + 5 = {0}",MetEstatico.Somar(2,5));
        }
    }
}

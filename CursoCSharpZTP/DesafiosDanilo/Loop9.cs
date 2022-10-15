using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.DesafiosDanilo {
    internal class Loop9 {
        //Ir até 49 parar no 10 e escrever pequena sereia
        //while E  foreach
        public static void Executar() {

            //while
            int num = 0;

            while (num <= 49) {
                if (num == 10) {
                    Console.Write($"{num} - ");
                    Console.WriteLine("Fala pequena sereia");
                    break;
                } else {
                    Console.WriteLine($"{num}");
                };
                num++;
            }

            //foreach
            int[] numeros = new int[50];

            for (int i = 0; i < numeros.Length; i++) {
                numeros[i] = i;
            }

            foreach (int n in numeros) {

                if (n == 10) {
                    Console.Write($"{n} - ");
                    Console.WriteLine("Fala pequena sereia");
                    break;
                } else {
                    Console.WriteLine($"{n}");
                };
            }
        }
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Colecoes {
    internal class ColecaoStack {
        public static void Executar() {
            //LIFO - Last In First Out

            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);



            foreach (var item in pilha) {
                Console.Write($"{item} - ");
            }
            Console.WriteLine();
            Console.WriteLine($"Pop: {pilha.Pop()}");//tira o ultimo elemento que entrou

            foreach (var item in pilha) {
                Console.Write($"{item} - ");
            }
            Console.WriteLine();
            Console.WriteLine($"Peek: {pilha.Peek()}");//le primeiro o elemento da lista (index == 0)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.Colecoes {
    internal class ColecaoQueue {
        public static void Executar() {
            //FIFO - First in first out (primeiro a entrar, primeiro a sair)
            var fila = new Queue<string>();

            fila.Enqueue("Eduardo"); //enqueue = adicionar algo na fila
            fila.Enqueue("Almeida");
            fila.Enqueue("Santos");

            Console.WriteLine(fila.Peek()); //Pega o primeiro elemento da fila por ordem de entrada

            Console.WriteLine(fila.Count); ;//
        }
    }
}

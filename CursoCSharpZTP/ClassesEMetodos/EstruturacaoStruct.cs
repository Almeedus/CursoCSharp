using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }  
    }

    internal class EstruturacaoStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Cordenada Inicial");
            Console.WriteLine($"X: {coordenadaInicial.X} | Y: {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada final");
            Console.WriteLine($"X: {coordenadaFinal.X} | Y: {coordenadaFinal.Y}");
        }
    }
}

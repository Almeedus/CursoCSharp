using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    internal class GettersESetters {

        public class Moto {
            //Usado para privar/esconder alguns atributos ou métodos
            private string Marca;
            private string Modelo;
            private uint Cilindrada;

            // construtor parametrado
            public Moto(string marca, string modelo, uint cilindrada) {
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }
            // construtor simples
            public Moto() { }

            //método set e get para acessar as variaveis privadas
            public string GetMarca() {
                return Marca;
            }
            public void SetMarca(string marca) {
                Marca = marca;
            }
            public string GetModelo() {
                return Modelo;
            }
            public void SetModelo(string modelo) {
                Modelo = modelo;
            }
            public uint GetCilindrada() {
                return Cilindrada;
            }
            public void SetCilindrada(uint cilindrada) {
                if (cilindrada > 0) {
                    Cilindrada = cilindrada;
                }
            }
        }
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
        }
    }
}

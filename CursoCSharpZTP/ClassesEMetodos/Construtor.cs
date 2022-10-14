using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    internal class Construtor {

        class Carro { //construindo uma classe
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public string RetornoCarro() {
                return string.Format($"Modelo: {Modelo}| Fabricante: {Fabricante}| Ano: {Ano}");
            }

            public Carro() {
            } //construtor Padrao (Não é necessario criar, mas to criando pq no exemplo de baixo criei um com parametro)

            public Carro(string modelo, string fabricante, int ano) {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            } //construindo um construtor Parametrizado
        }

        public static void Executar() {

            //Exemplo Construtor Padrão
            Carro carro1 = new Carro {
                Fabricante = "BMW",
                Modelo = "325i",
                Ano = 2017
            };

            //Exemplo Construtor Parametrizado
            Carro carro2 = new Carro("Ka", "Ford", 2018);


            //Retorno
            Console.WriteLine(carro1.RetornoCarro());
            Console.WriteLine();
            Console.WriteLine(carro2.RetornoCarro());
        }
    }
}

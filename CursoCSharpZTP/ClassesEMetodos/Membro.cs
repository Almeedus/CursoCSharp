using CursoCSharpZTP.ClassesEMetodos; //Exportando de Pessoa minha classe
using System;

namespace CursoCSharpZTP {
    internal class Membro {
        public static void Executar() {

            //Pessoa 1
            Pessoa user1 = new Pessoa {
                Nome = "Eduardo",
                Idade = 20
            };
            user1.ApresentarNoConsole();
            user1.Zerar();
            user1.ApresentarNoConsole();

            Console.WriteLine();
            //Pessoa 2
            var user2 = new Pessoa {
                Nome = "Danilo",
                Idade = 35
            };
            user2.ApresentarNoConsole();
            user2.Zerar();
            user1.ApresentarNoConsole();

            Console.WriteLine();



            //Console.WriteLine("=======================");
            ////Nesta forma preciso colocar centro do Console.WriteLine
            ////Estou retornando uma string, numa aplicação WEB essa irá funcionar
            //Console.WriteLine(user2.Apresentar(user2.Nome, user2.Idade));


            //Aqui basta chamar a função
            ////retornando uma chamada do terminal, ou seja, numa aplicação WEB essa nao vai funcionar
            //user2.ApresentarNoConsole();


            ////Posso utilizar métodos entrelaçados com o meu método, ex.: Length
            //Console.WriteLine(user2.Apresentar(user2.Nome, user2.Idade).Length);
            //Console.WriteLine("=======================");
        }
    } 
}

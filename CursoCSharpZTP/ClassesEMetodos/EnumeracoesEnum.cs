using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {
    //criando uma enumeração 
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    internal class EnumeracoesEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao; //convertendo um enum para um int


            var FilmeParaFamilia = new Filme() {
                Titulo = "Sharkardo 17",
                GeneroDoFilme = Genero.Comedia,
            };

            Console.WriteLine($"{FilmeParaFamilia.Titulo} é do genero {FilmeParaFamilia.GeneroDoFilme}");
        }
    }
}

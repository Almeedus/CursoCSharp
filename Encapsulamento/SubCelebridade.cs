using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {
        //Todos
        public string InfoPublica = "Tenho um instagram!";

        //Herança - Protected
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 551199999999;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias!";

        //Mesma classe e herança no mesmo projeto
        private protected string SegredoFamilia = "Blá blá";

        //Private é o padrao
        bool UsaMuitoPhotoshop = true;
        

        public void MeusAcessos() {
            Console.WriteLine("| CELEBRIDADE |");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
            Console.WriteLine();
        }
    }
}

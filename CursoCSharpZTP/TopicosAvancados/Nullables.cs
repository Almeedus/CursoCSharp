using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.TopicosAvancados {
    internal class Nullables {
        public static void Executar() {
            //iniciando um int que aceita default
            int? num2 = null;
            Console.WriteLine("num2: {0}",num2);

            //se o valor num2 for nulo, ele pega 0, se ele nao for nulo ele pega o valor de num2
            int num1 = num2 ?? 0;
            Console.WriteLine("num1: {0}", num1);
            //se o valor de seraQueÉVerdade for diferente de nulo, ele seta o valor para eVerdade
            //Senao, ele atribui o valor default do tipo bolean que é false
            bool? seraQueEVerdade = null;
            Console.WriteLine("seraQueEVerdade: {0}", seraQueEVerdade);

            bool eVerdade = seraQueEVerdade.GetValueOrDefault();
            Console.WriteLine("eVerdade: {0}", eVerdade);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.OrientacaoObjetos {
    //Sealed não permite a sobrescrita
    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }

    public class Avo {
        public virtual bool HonraFamilia() {
            return true;
        }
    }

    public class Pai : Avo {
        //public override sealed bool HonraFamilia() {
        //    return true;
        //}
    }

    public class FilhoRebelde : Pai {
        public override bool HonraFamilia() {
            return false;
        }
    }
    internal class ClasseMetodoSelad {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.Write("A fortuna é de: ");
            Console.WriteLine($"{semFilho.ValorDaFortuna():C}");

            FilhoRebelde filho = new FilhoRebelde();
            Console.Write("A honra da famílida é: ");
            Console.WriteLine(filho.HonraFamilia() ? "Seguida" : "Desrespeitada");
        }
    }
}

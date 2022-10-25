using System;


namespace CursoCSharpZTP.OrientacaoObjetos {

    public class Carro {
        //Usando o protected para que esse atributo seja transmitido apenas por herança
        //Readonly é usado para que seu valor não seja alterado, deixando apenas o valor que foi definido na classe carro
        protected readonly int VelocidadeMaxima;

        //Iniciando a velocidade como privada para que não seja acessada por qualquer objeto
        private int VelocidadeAtual;

        //Criando apenas um construtor, força com que a criação do objeto seja da forma desejada
        public Carro(int velocidadeMaxima) {
            //Atribuindo o valor passado para a variavel velocidadeMaxima
            VelocidadeMaxima = velocidadeMaxima;
        }

        //Usando o protected para que esse atributo seja transmitido apenas por herança
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            //Verificando se a velocidade é menor que 0
            if (novaVelocidade < 0) {
                VelocidadeAtual = 0; //Se for, ele zera a velocidade

                //verificando se a velocidade é maior que a permitida
            } else if (novaVelocidade > VelocidadeMaxima){
                VelocidadeAtual = VelocidadeMaxima; //Se for, ele altera a velocidade e passa seu valor máxmimo permitido

                //Caso não aconteça nenhum dos eventos listados, ele permite que a velocidade passada seja a velocidade atual
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        //Criando uma classe publica que pode ser acessível por qualquer objeto criado a partir da classe carro
        //A palavra virtual possibilita a sobrescrita explicita do método por uma classe herdada
        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        //Criando uma classe publica que pode ser acessível por qualquer objeto criado a partir da classe carro
        public int Frear() {
            return AlterarVelocidade(-5);
        }


        //Criando uma classe que herda de carro
        public class Uno : Carro {
            //Se não usar o construtor padrão, é necessário criar um passando os parametros já determinados anteriormente
            //Public = acessível por qualquer objeto | uno() criação do construtor | base() descrevendo que o construtor do uno
            //precisa passar os mesmos parametros do construtor do carro()
            public Uno () : base (200) {

            }
        }

        public class Ferrari : Carro {
            public Ferrari() : base(250) {

            }
            //override = torna esplicito que está havendo uma sobrescrita do método
            public override int Acelerar() {
                return AlterarVelocidade(15);
            }

            //Com a escrita new, ao voce faz uma sobrescrita implicita, ou seja, "escondendo" da classe pai a modificação
            public new int Frear() {
                return AlterarVelocidade(-15);
            }
        }
    };
    internal class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Carro.Uno carro1 = new Carro.Uno();

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine();
            Console.WriteLine("Celta...");
            Carro.Ferrari carro2 = new Carro.Ferrari(); //Criando objeto normal

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            //Criando objeto usando o Polimorfismo
            Console.WriteLine();
            Console.WriteLine("Ferrari com o tipo carro...");
            Carro carro3 = new Carro.Ferrari();

            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            carro3 = new Carro.Uno();
            Console.WriteLine("Uno com o tipo carro...");
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

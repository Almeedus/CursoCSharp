using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpZTP.ClassesEMetodos {

    public class Produto { //criando classe sem método static
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1; //passando o static no atributo, faz com que esse atributo nao seja do objeto
        //e sim da classe, padronizando um valor apenas e não aceitando varios

        public Produto(string nome, double preco) { //Método construtor criado
            Nome = nome;
            Preco = preco;
        }

        public string CalcularDesconto(string Produto, double Preco, double Desconto) { //Método de calculo de desconto
            double DescontoProtudo = Preco - (Preco * Desconto);
            return string.Format($"Valor atual do produto {Produto} é de R${Preco:N2} e seu desconto é de {Desconto:P}. Totalizando assim R${DescontoProtudo:N2}");
        }
    }

    internal class AtributoEstatico {
        public static void Executar() {
            Produto produto1 = new Produto("Caneta", 3.2); //utilizando a classe para criar o objeto por referencia
            Produto produto2 = new Produto("Borracha", 5.3);

            Produto.Desconto = 0.8; //mudando o desconto de 10% para 80% para TODOS os produtos

            Console.WriteLine(produto1.CalcularDesconto(produto1.Nome, produto1.Preco, Produto.Desconto));
            Console.WriteLine(produto2.CalcularDesconto(produto2.Nome, produto2.Preco, Produto.Desconto));
        }
    }
}

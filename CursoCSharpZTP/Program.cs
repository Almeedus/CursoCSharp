using System;
using System.Collections.Generic;

using CursoCSharpZTP.Fundamentos;
using CursoCSharpZTP.EstruturaDeControle;
using CursoCSharpZTP.ClassesEMetodos;
using CursoCSharpZTP;
using CursoCSharpZTP.DesafiosDanilo;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Comentario - Fundamentos", Comentario.Executar},
                {"Variavel E Constantes - Fundamentos", VariavelEConstantes.Executar},
                {"Inferencia De Tipos - Fundamentos", InferenciaDeTipos.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados Do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversão De Dados - Fundamentos", ConversaoDeDados.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuicao - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadoresTernarios.Executar},

                //Estrutura de controle
                {"Estrutura If - Estrutura De Controle", EstruturaIf.Executar},
                {"Estrutura Else - Estrutura De Controle", EstruturaElse.Executar},
                {"Estrutura If Else If - Estrutura De Controle", EstruturaIfElseIf.Executar},
                {"Switch Case - Estrutura De Controle", SwitchCase.Executar},
                {"While - Estrutura De Controle", While.Executar},
                {"Do While - Estrutura De Controle", DoWhile.Executar},
                {"For - Estrutura De Controle", For.Executar},
                {"Foreach - Estrutura De Controle", ForEach.Executar},

                //Classes e Métodos
                {"Membro - Classes e Metodos", Membro.Executar},
                {"Construtores - Classes e Metodos", Construtor.Executar},
                {"Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributo Estático - Classes e Metodos", AtributoEstatico.Executar},
                {"Desafio Acessar Atributo - Classes e Metodos", DesafioAcessarAtributo.Executar},
                {"Parametros Variaveis - Classes e Metodos", Params.Executar},

                //Danilão
                {"Pequena Sereia - Desafio", Loop9.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
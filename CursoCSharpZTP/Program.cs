using System;
using System.Collections.Generic;

using CursoCSharpZTP.Fundamentos;
using CursoCSharpZTP.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
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
                {"Estrutura If - Fundamentos", EstruturaIf.Executar},
                {"Estrutura Else - Fundamentos", EstruturaElse.Executar},
                {"Estrutura If Else If - Fundamentos", EstruturaIfElseIf.Executar},
                {"Switch Case - Fundamentos", SwitchCase.Executar},
                {"While - Fundamentos", While.Executar},
                {"Do While - Fundamentos", DoWhile.Executar},
                {"For - Fundamentos", For.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
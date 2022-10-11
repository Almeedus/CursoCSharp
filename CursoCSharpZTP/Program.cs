using System;
using System.Collections.Generic;

using CursoCSharpZTP.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados Do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversão De Dados - Fundamentos", ConversaoDeDados.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
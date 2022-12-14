using System;
using System.Collections.Generic;
using CursoCSharpZTP.Fundamentos;
using CursoCSharpZTP.EstruturaDeControle;
using CursoCSharpZTP.ClassesEMetodos;
using CursoCSharpZTP;
using CursoCSharpZTP.DesafiosDanilo;
using CursoCSharpZTP.Colecoes;
using CursoCSharpZTP.OrientacaoObjetos;
using CursoCSharpZTP.FuncoesMetodos;
using CursoCSharpZTP.ExcecaoTratamentoErro;
using CursoCSharpZTP.API;
using CursoCSharpZTP.TopicosAvancados;

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
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Getters E Setters - Classes e Metodos", GettersESetters.Executar},
                {"Propriedades - Classes e Metodos", Propriedades.Executar},
                {"Readondly - Classes e Metodos", Readondly.Executar},
                {"Enum - Classes e Metodos", EnumeracoesEnum.Executar},
                {"EstruturacaoStruct - Classes e Metodos", EstruturacaoStruct.Executar},
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Atribuicao Valor E Referencia - Classes e Metodos", AtribuicaoValorEReferencia.Executar},
                {"Valores Por Referencia (REF e OUT) - Classes e Metodos", ValoresPorReferencia.Executar},
                {"Parametros Com Valor Padrao - Classes e Metodos", ParametrosComValorPadrao.Executar},

                //Coleções
                {"Array - Coleções", ColecaoArray.Executar},
                {"List - Coleções", ColecaoLista.Executar},
                {"ArrayList - Coleções", ColecaoArrayList.Executar},
                {"Set - Coleções", ColecaoSet.Executar},
                {"Queue - Coleções", ColecaoQueue.Executar},
                {"Igualdade - Coleções", ColecaoIgualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", CursoCSharpZTP.OrientacaoObjetos.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Classe e Metodo Selad (selado) - Orientação a Objetos", ClasseMetodoSelad.Executar},

                //Funções e Métodos
                {"Exemplo Lambda - Funções e Métodos", ExemploLambda.Executar},
                {"Delegate Lambda - Funções e Métodos", DelegateLambda.Executar},
                {"Delegate como Função Anonima - Funções e Métodos", DelegateFuncaoAnonima.Executar},

                //Exceções e Tratamento de Erros
                {"Primeira Excessao - Exceções e Tratamento de Erros", PrimeiraExcessao.Executar},
                {"Exceção Personalizada - Exceções e Tratamento de Erros", ExcecaoPersonalizada.Executar},

                //API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - API", LendoArquivos.Executar},
                {"Usando o File Info - API", UsandoFileInfo.Executar},
                {"Diretórios - API", Diretorios.Executar},

                //Avançados
                {"LINQ - Avançados", LINQ.Executar},
                {"LINQ 2 - Avançados", LINQ2.Executar},
                {"Nullables - Avançados", Nullables.Executar},
                {"Variaveis Dinamicas - Avançados", VariaveisDinamicas.Executar},
                {"Generics - Avançados", Generics.Executar},

                //Danilão
                {"Pequena Sereia - Desafio", Loop9.Executar},
                {"Desafio De Ping - Desafio", DesafioDePing.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
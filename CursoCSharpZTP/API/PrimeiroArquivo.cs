using System;
using System.IO;


namespace CursoCSharpZTP.API {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            //enviroment.os.version.plataform é usado para descobrir qual o sistema operacional do usuario
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            //string home = (éLinux ou éMac) ? seVerdadeCaminho = "HOME" : seFalsoCaminho = "%HOMEDRIVE%HOMEPATH%"
            //HOME = caminho do linux e do mac
            //%HOMEDRIVE%HOMEPATH% = caminho do windows

            return path.Replace("~", home);
            //retornando o caminho no lugar do ~
        }
    }

    class PrimeiroArquivo {
        public static void Executar() {
            //@ antes da string permite que o console interprete o caminho da forma normal
            //~ : associada com a parte home do usuario
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            //Criando um arquivo de texto e escrevendo nele
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Primeiro");
                    sw.WriteLine("Programa");
                    sw.WriteLine("Usando uma");
                    sw.WriteLine("API de escrita");
                }
            }

            //Adicionando num arquivo já escrito
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("Também é");
                sw.WriteLine("  Possivel");
                sw.WriteLine("      Escrever");
                sw.WriteLine("  No arquivo");
                sw.WriteLine("Já criado");
            }
        }
    }
}

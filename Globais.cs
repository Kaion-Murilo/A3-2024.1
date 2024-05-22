using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_2024._1
{
    internal class Globais
    {
        public static string versao = "0,5";
        public static Boolean logado = false;
        public static int nivel = 0;

        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bancoA3.db";
        public static string caminhoBanco = caminho + @"\banco\";

    }
}

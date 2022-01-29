using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // teste Directory
            System.Console.WriteLine("---- Testando a classe Directory ----");

            var caminho = "D:\\workspace\\poo\\Arquivos";
            // Path para o teste de criar diretorio
            //var caminhoPathCombine = Path.Combine(caminho, "Galho", "folha");
            var caminhoPathCombine = Path.Combine(caminho, "Ramo");

            var caminhoArquivoSimples = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoSimplesCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");

            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");

            var listaString = new List<string> {"DEUS", "JESUS", "ESPÍRITO SANTO" };
            var listaStringContinuacao = new List<string> {"O Único DEUS", "O Salvador JESUS", "O Consolador ESPÍRITO SANTO" };

            var novoCaminhoArquivo = Path.Combine(caminho, "Raiz", "arquivo-teste-stream.txt");

            FileHelper helper = new FileHelper();
            // helper.ListaDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);

            //teste de criar diretorio
            //System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);

            // com a passagem do true confirma a exclusão de arquivos e subdiretorios permanentemente
            //helper.ApagarDiretorio(caminhoPathCombine, true);

            //helper.CriarArquivoTexto(caminhoArquivoSimples, "Jesus é o Caminho, a Verdade e a Vida");
            
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            
            //helper.LerArquivoStream(caminhoArquivo);

            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);

            helper.CopiarArquivo(caminhoArquivoSimples, caminhoArquivoSimplesCopia, false);




            //testa Calculadora e a interface ICalculadora
            System.Console.WriteLine("---- Testando a classe Calculadora com a Interface ----");
            ICalculadora calcI = new Calculadora();
            System.Console.WriteLine("A Soma de 6 + 1 é = " + calcI.Somar(6,1));
            System.Console.WriteLine("A Multiplicação de 2 x 7 é = " + calcI.Multiplicar(2,7));
            System.Console.WriteLine("A Subtração de 8 - 1 é = " + calcI.Subtrair(8,1));
            System.Console.WriteLine("A Divisão de 21 / 3 é = " + calcI.Dividir(21,3));
            System.Console.WriteLine();

            // testa a classe calculadora
            System.Console.WriteLine("---- Testando a classe Calculadora ----");
            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(35,35));
            System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(60,10,7));
            System.Console.WriteLine();

            // testa Conta e Corrente
            System.Console.WriteLine("---- Testando a classe Corrente ----");
            Corrente cc = new Corrente();
            cc.Creditar(7000);
            cc.ExibirSaldo();
            System.Console.WriteLine();          
       
                 
            // testa a classe Retangulo
            System.Console.WriteLine("---- Testando a classe Retangulo ----");
            Retangulo r = new Retangulo();

            r.DefinirMedidas(7,70);

            System.Console.WriteLine($"Área: {r.ObterArea()}");
            System.Console.WriteLine();




            // testa a classe Pessoa
            System.Console.WriteLine("---- Testando a classe Pessoa ----");
            Pessoa p1 = new Pessoa();

            p1.Nome = "JESUS";
            p1.Idade = 33;

            p1.Apresentar();
            System.Console.WriteLine();


            // testa a classe Aluno
            System.Console.WriteLine("---- Testando a classe Aluno ----");
            Aluno a1 = new Aluno();
            a1.Nome = "Fábio";
            a1.Idade = 46;
            a1.Nota = 10;
            a1.Apresentar();
            System.Console.WriteLine();

            //testa a classe Professor
            System.Console.WriteLine("---- Testando a classe Professor ----");
            Professor prof = new Professor();
            prof.Salario = 15500;
            prof.Nome = "Faria";
            prof.Idade = 46;
            prof.Documento = 23456;
            prof.Apresentar();
            System.Console.WriteLine();
        }

    }
}
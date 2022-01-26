using System;
using System.IO;
using System.Collections.Generic;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "PastaTeste3");
            var caminhoArquivo = Path.Combine(caminho, "ArquivoTesteStream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "ArquivoTeste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "ArquivoTesteBackup.txt");
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3" };
            var listaStringCont = new List<string> {"Linha 4", "Linha 5", "Linha 6" };
            var novocaminho = Path.Combine(caminho, "PastaTeste2", "ArquivoTesteStream.txt");

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivos(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringCont);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novocaminho, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);


            // iCalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir(20, 10));
            
            // Computador comp = new Computador();
            // Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // polimorfismo em tempo de compilação
            // Calculadora calc = new Calculadora();
            // Console.WriteLine("O resultado da primeira soma é " + calc.Somar(10,5));
            // Console.WriteLine("O resultado da segunda soma é " + calc.Somar(10,5,6));
            
            // polimorfismo em tempo de execução
            // Aluno a1 = new Aluno();
            // a1.Nome = "Bob";
            // a1.Idade = 20;
            // a1.Nota = 8;
            // a1.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Salario = 1000;
            // p1.Apresentar();

            //Encapsulamento 
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // Console.WriteLine ($"Área: {r.ObterArea()}");

            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(-30, 30);
            // Console.WriteLine ($"Área: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();

        }
    }
}
using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void operacao(int x, int y); //obedece a ordem FIFO: primeiro a entrar é primeiro a sair
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
            

            //operacao op = Calculadora.Somar;
            //operacao op = new operacao(Calculadora.Somar);
            //op += Calculadora.Subtrair;
            //op.Invoke(10,5); //chama tudo q tá no delegate
            //op(10, 5);

            //const double pi = 3.14;
            //Console.WriteLine(pi);

            //Data data = new Data();
            //data.SetMes(20);
            //data.Mes=12;
            //data.ApresentarMes();
            
            //Aluno a1 = new Aluno("Myllene", "Mendes", "Eln2");
            //a1.Apresentar();

            // //compartilha os mesmos valores de instancia
            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Intancia";
            // Log log2 = Log.GetInstance();
            // Console.WriteLine(log2.PropriedadeLog);

            //Pessoa p1 = new Pessoa();
            //p1.Apresentar();
        }
    }
}
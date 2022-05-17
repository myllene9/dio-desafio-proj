using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 8, 1, 9};
            int[] arrayCopia = new int[10];

            System.Console.WriteLine(($"Tipo atual: {array.GetType()}"));
            op.ConverterArray(array);
            System.Console.WriteLine($"Tipo após: {array.GetType()}");

            // int valor = 15;
            // System.Console.WriteLine(($"Capacidade atual: {array.Length}"));
            // op.RedimensionarArray(ref array, 10);
            // System.Console.WriteLine($"Capacidade após: {array.Length}");
            
            // int indice = op.ObterIndice(array, valor);
            // if(indice>-1)
            // {
            //     System.Console.WriteLine($"O indice de {valor} é {indice} no array");
            // }
            // else
            // {
            //     System.Console.WriteLine("O valor nao existe no array");
            // }

            // int valorAchado = op.ObterValor(array, valor);
            // if(valorAchado>0)
            // {
            //     System.Console.WriteLine("Encontrei");
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontrei");
            // }
            // bool todosMaiorQue = op.TodosMaiorQue(array, valor);
            // if(todosMaiorQue) 
            // {
            //     System.Console.WriteLine($"Todos os valores maior que {valor}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Existem valores menores que {valor}");
            // }

            // int valorProcurado = 10;
            // bool existe = op.Existe(array, valorProcurado);
            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // Console.WriteLine("\nAntes da Cópia:");
            // op.ImprimirArray(arrayCopia);
            // op.Copiar(ref array, ref arrayCopia);
            // Console.WriteLine("\nDepois da Cópia: ");
            // op.ImprimirArray(arrayCopia);

            // Console.WriteLine("normal:");
            // op.ImprimirArray(array);
            // //op.OrdenarBubbleSort(ref array);
            // Console.WriteLine("ordenado");
            // op.Ordenar(ref array);
            // op.ImprimirArray(array);
            // int[,] matriz = new int[4,2] 
            // {
            //     { 0, 8},
            //     { 1, 9},
            //     { 2, 10},
            //     { 3, 11}
            // };

            // for (int i = 0; i < matriz.GetLength(0) ; i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         Console.WriteLine(matriz[i,j]);
            //     }
            // }
            

            // int[] arrayint = new int[3];
            // arrayint[0] = 10;
            // arrayint[1] = 20;
            // arrayint[2] = 30;

            // for (int i = 0; i < arrayint.Length; i++)
            // {
            //     Console.WriteLine(arrayint[i]);
            // }

            // foreach (var item in arrayint)
            // {
            //     Console.WriteLine(item);
            // }


        }
    }
}
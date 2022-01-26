using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;

        public Pessoa() //mesmo nome da classe e sem retorno
        {
            nome = string.Empty;
            sobrenome = string.Empty;
            //construtor vazio
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("construtor classe pessoa");
        }

        public void Apresentar()
        {
            // não consegue alterar this.nome = "teste";
            Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }
}
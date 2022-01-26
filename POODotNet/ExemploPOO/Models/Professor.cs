using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario {get; set;}

        public override void Apresentar (){
            Console.WriteLine ($"Olá, Sou o professor {Nome} e meu salário é {Salario} reais");
        }
    }
}
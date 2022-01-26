using System;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar (){
            Console.WriteLine ($"Olá, Sou o professor {Nome} e meu salário é {Salario} reais");
        }
    }
}
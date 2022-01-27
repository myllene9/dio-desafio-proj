using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotech
{
    public class Atributos
    {
        private int genero;
        private int edicao;
        private string titulo;
        private string autor;
        private string sinopse;


        public int Genero()
        {
            Console.WriteLine("Qual gênero do Livro?");
            this.genero = int.Parse(Console.ReadLine());
            return this.genero;
        }

        public int Edicao()
        {
            Console.WriteLine("Qual a edição do Livro?");
            this.edicao = int.Parse(Console.ReadLine());
            return this.edicao;
        }

        public string Titulo()
        {
            Console.WriteLine("Digite o Título do Livro");
            this.titulo = Console.ReadLine();
            return this.titulo;
        }

        public string Autor()
        {
            Console.WriteLine("Qual o/a Autor(a) do Livro?");
            this.autor = Console.ReadLine();
            return this.autor;
        }

        public string Sinopse()
        {
            Console.WriteLine("Digite a Sinopse do Livro");
            this.sinopse = Console.ReadLine();
            return this.sinopse;
        }

    }
}
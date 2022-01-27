using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotech
{
    public class Livro : Base
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Autor {get; set;}
        private string Sinopse {get; set;}
        private int Edicao {get; set;}
        private bool Disponivel {get; set;}

        public Livro (int id,
                        Genero genero,
                        string titulo,
                        string autor,
                        string sinopse,
                        int edicao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Sinopse = sinopse;
            this.Edicao = edicao;
            this.Disponivel = true;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Edicao: " + this.Edicao + Environment.NewLine;
            
            if(this.Disponivel)
            {
                retorno += "Disponível";
            } 
            else 
            {
                retorno += "Indisponível";
            }
            return retorno;
        }

        public bool retornaDisponivel()
        {
            return this.Disponivel;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public string retornaAutor()
        {
            return this.Autor;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Disponivel = false;
        }

    }
}
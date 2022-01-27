using System;

namespace Bibliotech
{
    class Program
    {
        static LivroEstante estante = new LivroEstante();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarLivros();
                        break;
                    case "2":
                        CadastrarLivro();
                        break;
                    case "3":
                        AtualizarInfo();
                        break;
                    case "4":
                        ExcluiLivro();
                        break;
                    case "5":
                        VisualizarLivro();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.WriteLine();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem-vindo à sua Biblioteca!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar livros");
            Console.WriteLine("2 - Cadastrar novo livro");
            Console.WriteLine("3 - Atualizar informações");
            Console.WriteLine("4 - Remover livro");
            Console.WriteLine("5 - Visualizar livro");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarLivros()
        {
            Console.WriteLine("Lista de Livros");
            int c=0;
            var lista = estante.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Livro Cadastrado");
                return;
            }

            foreach(var livro in lista)
            {
                string status;
                if(livro.retornaDisponivel())
                    status = "Disponível";
                else
                    status = "Indisponível";
                Console.WriteLine($"#ID {livro.retornaId()} - {livro.retornaTitulo()} - {livro.retornaAutor()} - {status}");
                
                if (livro.retornaDisponivel() == false) { c++; }   
            }

            Console.WriteLine($"Temos {lista.Count - c} livros disponíveis!");
        }

        private static void CadastrarLivro()
        {
            Console.WriteLine("Cadastrar novo Livro");

            foreach ( int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            
            Atributos atributos = new Atributos();

            Livro novoLivro = new Livro(id: estante.ProximoId(),
                                        genero: (Genero)atributos.Genero(),
                                        titulo: atributos.Titulo(),
                                        autor: atributos.Autor(),
                                        sinopse: atributos.Sinopse(),
                                        edicao: atributos.Edicao());
            
            estante.Insere(novoLivro);
        }

        private static void AtualizarInfo()
        {
            Console.WriteLine("Digite o ID do Livro: ");
            int indice = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }

            Atributos atributos = new Atributos();

            Livro atualizaLivro = new Livro(id: estante.ProximoId(),
                                        genero: (Genero)atributos.Genero(),
                                        titulo: atributos.Titulo(),
                                        autor: atributos.Autor(),
                                        sinopse: atributos.Sinopse(),
                                        edicao: atributos.Edicao());
            
            estante.Atualiza(indice, atualizaLivro);
        }

        private static void ExcluiLivro()
        {
            Console.WriteLine("Digite o ID do Livro: ");
            int indice = int.Parse(Console.ReadLine());

            estante.Exclui(indice);
        }

        private static void VisualizarLivro()
        {
            Console.WriteLine("Digite o ID do Livro: ");
            int indice = int.Parse(Console.ReadLine());

            var livro = estante.RetornaPorId(indice);

            Console.WriteLine(livro);
        }
    }
}
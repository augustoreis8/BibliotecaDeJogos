using BibliotecaDejogos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            List<Jogo> ListaDeGames = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {

                Console.WriteLine("(-_(-_-)_-) +++___+++___---___---BIBLIOTECA DE GAMES---___---___+++___+++ (T-T)");

                Console.WriteLine("1 - Adicionar Game");
                Console.WriteLine("2 - Listar Games");
                Console.WriteLine("3 - Editar Game");
                Console.WriteLine("4 - Remover Game");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarGame(ListaDeGames);
                        if (resultado == true)
                        {
                            Console.WriteLine(" Game cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cadastro do game.");
                        }
                        break;

                    case "2":
                        resultado = ListarGames(ListaDeGames);
                        if (resultado == true)
                        {
                            Console.WriteLine(" Game listado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem do game.");
                        }
                        break;

                    case "3":
                        resultado = EditarGames(ListaDeGames);
                        if (resultado == true)
                        {
                            Console.WriteLine(" Game editado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na edição do game.");
                        }
                        break;

                    case "4":
                        resultado = RemoverGames(ListaDeGames);
                        if (resultado == true)
                        {
                            Console.WriteLine("Game Removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na remoção do game.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static bool AdicionarGame(List<Jogo> ListaDeGames)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();

            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Genero: ");
            String genero = Console.ReadLine();

            Console.Write("Empresa: ");
            String empresa = Console.ReadLine();

            Console.Write("Metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());

            if (titulo == "")
            {
                return false;
            }
            if (ano < 1958)
            {
                return false;
            }
            if (genero == "")
            {
                return false;
            }
            if (empresa == "")
            {
                return false;
            }

            Jogo novoJogo = new Jogo(titulo, ano, genero, empresa, metacritic);

            listaDejogos.Add(novoJogo);
            Console.Beep();
            return true;
        }

        public static bool ListarGames(List<Jogo> ListaDeGames)
        {
            foreach (Jogo jogo in listaDeJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());

                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());

                Console.Write("Genero: ");
                Console.WriteLine(jogo.getGenero());

                Console.Write("Empresa: ");
                Console.WriteLine(jogo.getEmpresa());

                Console.Write("Metacritic: ");
                Console.WriteLine(jogo.getMetacritic());

                Console.WriteLine("==========");
                Console.WriteLine("");
            }
            return true;
        }

        public static bool EditarGames(List<Jogo> ListaDeGames)
        {
            Console.Clear();

            Console.Write("Digite o título do jogo que para editar: ");
            String titulo = Console.ReadLine();
            foreach (Jogo jogo in listaJogos)
            {
                if (jogo.GetNome() == titulo)
                {
                    Console.Write("Título: ");
                    String novo_titulo = Console.ReadLine();

                    String titulo = novo_titulo;

                    Console.Write("Ano: ");
                    int novo_ano = Convert.ToInt32(Console.ReadLine());

                    int ano = novo_ano;

                    Console.Write("Gênero: ");
                    String novo_genero = Console.ReadLine();

                    String genero = novo_genero;

                    Console.Write("Empresa: ");
                    int nova_empresa = Console.ReadLine();

                    String empresa = nova_empresa;

                    Console.Write("Metacritic: ");
                    int novo_metacritic = Convert.ToInt32(Console.ReadLine());

                    int metacritic = novo_metaCritic;
                }
                else
                {
                    Console.WriteLine("Falha ao editar jogo");
                }
            }
            return true;
        }

        public static bool RemoverGames(List<Jogo> ListaDeGames)
        {
            Console.Clear();

            Console.Write("Digite o título do jogo que deseja remover: ");
            String titulo = Console.ReadLine();

            foreach (Jogo jogo in listaJogos)
            {
                if (jogo.GetNome() == titulo)
                {
                    listaJogos.Remove(jogo);
                    Console.WriteLine("Game removido com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Falha ao remover game");
                }

            }

            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadLine();

            return true;
        }
    }
}
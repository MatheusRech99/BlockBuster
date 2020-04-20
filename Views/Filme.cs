using System;
using Models;
using Controllers;

namespace Views
{
    public class FilmeView
    {
        public static void CadastrarFilme()
        {
            Console.WriteLine("Cadastrando Filme");
            Console.WriteLine("Título: ");
            String titulo = Console.ReadLine();
            Console.WriteLine("Sinopse: ");
            String sinopse = Console.ReadLine();
            Console.WriteLine("Data de Lançamento: ");
            String dataLancamento = Console.ReadLine();
            Console.WriteLine("Preço: ");
            Double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Estoque: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

            FilmeController.InserirFilme(titulo, sinopse, dataLancamento, preco, estoque);
        }

        public static void ListarFilme()
        {
            Console.WriteLine("Lista de Filmes: ");
            FilmeController.GetFilmes().ForEach(filme => Console.WriteLine(filme.ToString()));
        }

        public static void ConsultarFilme()
        {
            FilmeModels filme;
            do
            {
                Console.WriteLine("Informe o ID do Filme para consulta: ");
                int Filmeid = Convert.ToInt32(Console.ReadLine());
                filme = null;
                try
                {
                    filme = FilmeController.GetFilme(Filmeid);
                    if (filme == null)
                    {
                        Console.WriteLine("Filme não localizado, digite outro ID!");
                    }
                }
                catch
                {
                    Console.WriteLine("Filme não localizado, digite outro ID!");
                }

            } while (filme == null);
            Console.WriteLine(filme.ToString());
        }
    }
}
using System;
using Views;
using Controllers;
using Models;

namespace BlockBuster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opt;
            do
            {
                

                Console.WriteLine(" _____Locadora BlockBuster_____ ");
                Console.WriteLine("|1- Cadastrar Cliente          |");
                Console.WriteLine("|2- Consultar Cliente          |");
                Console.WriteLine("|3- Listar Cliente             |");
                Console.WriteLine("|4- Cadastrar Filme            |");
                Console.WriteLine("|5- Consultar Filmes           |");
                Console.WriteLine("|6- Listar Filme               |");
                Console.WriteLine("|7- Cadastrar Locacao          |");
                Console.WriteLine("|8- Consultar Locacao          |");
                Console.WriteLine("|9- Listar Locacao             |");
                Console.WriteLine("|0- Sair!                      |");
                Console.WriteLine("|______________________________|");

                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        ClienteView.CadastrarCliente();
                        break;
                    case 2:
                        ClienteView.ConsultarCliente();
                        break;
                    case 3:
                        ClienteView.ListarCliente();
                        break;
                    case 4:
                        FilmeView.CadastrarFilme();
                        break;
                    case 5:
                        FilmeView.ConsultarFilme();
                        break;
                    case 6:
                        FilmeView.ListarFilme();
                        break;
                    case 7:
                        LocacaoView.CadastrarConsulta();
                        break;
                    case 8:
                        LocacaoView.ConsultarLocacao();
                        break;
                    case 9:
                        LocacaoView.ListarLocacao();
                        break;
                }

            } while (opt != 0);
        }
    }
}

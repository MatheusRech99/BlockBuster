using System;
using Controllers;
using Models;
using System.Collections.Generic;

namespace Views{
    public class LocacaoView{
        public static void ListarLocacao(){
            Console.WriteLine("\n Lista de Locações");
            List<LocacaoModels> locacoes = LocacaoController.GetLocacaos();
            locacoes.ForEach(locacao => Console.WriteLine(locacao));
        }

        public static void ConsultarLocacao(){
            LocacaoModels locacao;

            do{
                Console.WriteLine("Informe a locacao para consulta: ");
                int Locacaoid = Convert.ToInt32(Console.ReadLine());
                locacao = null;
                try{
                    locacao = LocacaoController.GetLocacaos(Locacaoid);
                    if (locacao == null){
                        Console.WriteLine("Não foi possível locazilar a locação, digite outro id!");
                    }
                } catch{
                    Console.WriteLine("Não foi possível locazilar a locação, digite outro id!");
                }

            }while (locacao == null);
            Console.WriteLine(locacao.ToString());
        }

        public static void CadastrarConsulta(){
            Console.WriteLine("Cadastrar Locação\n");
            List<ClienteModels> clientes = ClienteController.GetCliente();
            List<FilmeModels> filmes = FilmeController.GetFilmes();

            int Clienteid = 0;

            Console.WriteLine("\nInsira o ID do cliente para continuar a locação: ");
            Clienteid = Convert.ToInt32(Console.ReadLine());

            if (Clienteid != 0){
                ClienteModels cliente = clientes.Find(cliente => cliente.ClienteId == Clienteid);
                LocacaoModels locacao = LocacaoController.adcionarLocacao(cliente);

                int Filmeid = 0;

                do{
                    Console.WriteLine("\nPara sair da tela de Locação digite '0' ");
                    Console.WriteLine("\nDigite o ID do filme que deseja locar: ");
                    Filmeid = Convert.ToInt32(Console.ReadLine());
                    if (Filmeid != 0){
                        FilmeModels filme = filmes.Find(filme => filme.FilmeId == Filmeid);
                        locacao.AdcionarFilmes(filme);
                    }
                }while (Filmeid !=0);
            }
        }
    }
}
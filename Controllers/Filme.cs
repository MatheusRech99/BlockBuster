using System;
using Models;
using System.Collections.Generic;

namespace Controllers{
    public class FilmeController{
        public static void InserirFilme(String titutlo, String sinopse, String dataLancamento, double preco, int estoque){
            DateTime dtLancamento;
            try{
                dtLancamento = Convert.ToDateTime(dataLancamento);
            } catch {
                Console.WriteLine("Formato inválido, a data atual será utilizada para completar o Cadastro!");
                dtLancamento = DateTime.Now;
            }

            new FilmeModels(titutlo, sinopse, dataLancamento, preco, estoque);
        }

        public static List<FilmeModels> GetFilmes(){
            return FilmeModels.GetFilmes();
        }
        public static FilmeModels GetFilme(int Filmeid){
            return FilmeModels.GetFilme(Filmeid);
        }
    }
}
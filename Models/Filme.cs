using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;


namespace Models
{
    public class FilmeModels
    {
        [Key]
        public int FilmeId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Sinopse { get; set; }
        [Required]
        public String DataLancamento { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public int Estoque { get; set; }
        public int LocacoesRealizadas { get; set; }

        public FilmeModels()
        {

        }

        public FilmeModels(String titutlo, String sinopse, String dataLancamento, double preco, int estoque)
        {
            Titulo = titutlo;
            Sinopse = sinopse;
            DataLancamento = dataLancamento;
            Preco = preco;
            Estoque = estoque;
            LocacoesRealizadas = 0;
        }

        public static List<FilmeModels> GetFilme(int FilmeId)
        {
            var db = new Context();
            return db.Filmes.ToList();
        }

        public override string ToString()
        {


            return $"Dados Filme\n\n" +
                   $"ID do Filme: {FilmeId}" +
                   $"Título do Filme: {Titulo}" +
                   $"Sinopse do Filme: {Sinopse}" +
                   $"Data de Lançamento: {DataLancamento}" +
                   $"Preço do Filme: {Preco}" +
                   $"Estoque: {Estoque}" +
                   $"Quantidade de Locações Realizadas: {LocacoesRealizadas}";
        }
    }
}
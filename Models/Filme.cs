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
        public List<FilmeLocacao> locacoes = new List<FilmeLocacao>();

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

            var db = new Context();
            db.Filmes.Add(this);
            db.SaveChanges();
        }

        public static List<FilmeModels> GetFilmes()
        {
            var db = new Context();
            return db.Filmes.ToList();
        }

        public static FilmeModels GetFilme(int Filmeid)
        {
            var db = new Context();
            return (from filme in db.Filmes
                    where filme.FilmeId == Filmeid
                    select filme).First();
        }

        public override string ToString()
        {
            var db = new Context();
            int quantidadeLocacao = (
                from filme in db.FilmeLocacao
                where filme.FilmeId == FilmeId
                select filme.FilmeId).Count();

            return $" ___________________Dados Filme____________________\n" +
                   $"|ID do Filme: {FilmeId}\n" +
                   $"|Título do Filme: {Titulo}\n" +
                   $"|Sinopse do Filme: {Sinopse}\n" +
                   $"|Data de Lançamento: {DataLancamento}\n" +
                   $"|Preço do Filme: {Preco:C2}\n" +
                   $"|Estoque: {Estoque}\n" +
                   $"|Quantidade de Locações: {quantidadeLocacao}\n"+
                   $"|__________________________________________________\n";
        }
    }
}
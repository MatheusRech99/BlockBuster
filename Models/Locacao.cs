using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models
{
    public class LocacaoModels
    {
        [Key]
        public int LocacaoId { get; set; }
        public ClienteModels Cliente { get; set; }

        [ForeignKey("clientes")]
        public int ClienteId { get; set; }
        [Required]
        public DateTime DataLocacao { get; set; }

        public LocacaoModels()
        {

        }

        public LocacaoModels(ClienteModels cliente, DateTime datalocacao)
        {
            ClienteId = cliente.ClienteId;
            DataLocacao = datalocacao;
        }

        public void AdcionarFilmes(FilmeModels filme)
        {
            FilmeLocacao filmeLocacao = new FilmeLocacao(){
                FilmeId = filme.FilmeId,
                LocacaoId = LocacaoId
            };
        }
        public static List<LocacaoModels> GetLocacao(){
            var db = new Context();
            return db.Locacoes.ToList();
        }

        public override string ToString(){
            return "";
        }



    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models{
    public class FilmeLocacao{
        [Key]
        public int FilmeLocacaoId{get;set;}
        [ForeignKey("filmes")]
        public int FilmeId {get;set;}
        public virtual FilmeModels Filme {get;set;}
        [ForeignKey("locacoes")]
        public int LocacaoId {get;set;}
        public virtual LocacaoModels Locacao {get;set;}
    }
}
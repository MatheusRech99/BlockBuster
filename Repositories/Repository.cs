using System;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories{
    public class Context : DbContext{
        public DbSet <ClienteModels> Clientes {get;set;}
        public DbSet <FilmeModels> Filmes {get;set;}
        public DbSet <LocacaoModels> Locacoes {get;set;}
        public DbSet<FilmeLocacao> FilmeLocacao {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseMySql("Server=localhost;User Id=root;Database=bancoteste");
        }
    }
}
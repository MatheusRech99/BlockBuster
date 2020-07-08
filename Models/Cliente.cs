using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;


namespace Models
{
    public class ClienteModels
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string DataNascimento { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public int DiasdeDevolucao { get; set; }

        public List<LocacaoModels> locacoes = new List<LocacaoModels>();

        public ClienteModels()
        {

        }

        public ClienteModels(String nome, String dataNascimento, String cpf, int diasdeDevolucao)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            DiasdeDevolucao = diasdeDevolucao;
            locacoes = new List<LocacaoModels>();

            var db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();

        }

        public void AtribuirLocacao(LocacaoModels locacao)
        {
            locacoes.Add(locacao);
        }

        public static List<ClienteModels> GetCliente()
        {
            var db = new Context();
            return db.Clientes.ToList();
        }


        public static ClienteModels GetCliente(int Clienteid)
        {
            var db = new Context();
            return (from cliente in db.Clientes
                    where cliente.ClienteId == Clienteid
                    select cliente).First();
        }

        public override string ToString()
        {
            return $"|-----------------Dados Cliente-------------------------\n" +
                   $"|ID do Cliente: {ClienteId}\n" +
                   $"|Nome do Cliente: {Nome}\n" +
                   $"|Data de Nascimento do Cliente: {DataNascimento}\n" +
                   $"|CPF do Cliente: {CPF}\n" +
                   $"|Dias para devolução do Cliente: {DiasdeDevolucao}\n" +
                   $"|-------------------------------------------------------";
        }
    }
}
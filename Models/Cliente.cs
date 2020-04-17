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

        public ClienteModels()
        {

        }

        public ClienteModels(String nome, String dataNascimento, String cpf, int diasdeDevolucao)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            DiasdeDevolucao = diasdeDevolucao;

            var db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();

        }

        public static List<ClienteModels> GetCliente(int Clienteid)
        {
            var db = new Context();
            return db.Clientes.ToList();
        }

        public override string ToString()
        {
            return $"Dados Cliente\n\n" +
                   $"ID do Cliente: {ClienteId}" +
                   $"Nome do Cliente: {Nome}" +
                   $"Data de Nascimento do Cliente: {DataNascimento}" +
                   $"CPF do Cliente: {CPF}" +
                   $"Dias para devolução do Cliente: {DiasdeDevolucao}"+
                   $"------------------------------------------------";
        }
    }
}
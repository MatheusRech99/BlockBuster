using System;
using Models;
using System.Collections.Generic;

namespace Controllers{
    public class ClienteController{
        public static void InserirCliente(string nome, string dataNascimento, string cpf, int diasdeDevolucao){
            DateTime dtNascimento;
            try {
                dtNascimento = Convert.ToDateTime (dataNascimento);
            } catch{
                Console.WriteLine("Formato inválido, a data atual será utilizada para completar o Cadastro!");
                dtNascimento = DateTime.Now;
            }

            new ClienteModels(nome, dataNascimento, cpf, diasdeDevolucao);
        }

        public static ClienteModels GetCliente (int ClienteId){
            return ClienteModels.GetCliente(ClienteId);
        }

        public static List<ClienteModels> GetCliente(){
            return ClienteModels.GetCliente();
        }
    }
}
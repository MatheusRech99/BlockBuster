using System;
using Models;
using Controllers;

namespace Views{
    public class ClienteView{
        public static void CadastrarCliente(){
            Console.WriteLine("Cadastrando Cliente: ");
            Console.WriteLine("Nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: ");
            String dataNascimento = Console.ReadLine();
            Console.WriteLine("CPF:");
            String cpf = Console.ReadLine();
            Console.WriteLine("Quantidade de dias para devolução: ");
            int diasdeDevolucao = Convert.ToInt32(Console.ReadLine());

            ClienteController.InserirCliente(nome, dataNascimento, cpf, diasdeDevolucao);
            
        }

        public static void ListarCliente(){
            Console.WriteLine("Lista de Clientes: "); 
            ClienteController.GetCliente().ForEach(cliente => Console.WriteLine(cliente));           
        }

        public static void ConsultarCliente(){

            ClienteModels cliente;
            do{
            Console.WriteLine("Informe o Id do Cliente: ");
            int ClienteId = Convert.ToInt32(Console.ReadLine());
            cliente = null;
            try{
                cliente = ClienteController.GetCliente(ClienteId);
                if (cliente == null){
                    Console.WriteLine("Cliente não encontrado, digite um ID válido!");
                }
            } catch{
                Console.WriteLine("Cliente não encontrado, digite um ID válido!");
            }
            } while (cliente == null);
            Console.WriteLine(cliente.ToString());
        
        }
    }
}
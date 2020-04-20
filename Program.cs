using System;
using Views;
using Controllers;
using Models;

namespace BlockBuster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opt;
            do
            {
                

                Console.WriteLine("Locadora BlockBuster");
                Console.WriteLine("1- Cadastrar Cliente");
                Console.WriteLine("2- Consultar Cliente");
                Console.WriteLine("3- Listar Cliente");

                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        ClienteView.CadastrarCliente();
                        break;
                    case 2:
                        ClienteView.ConsultarCliente();
                        break;
                    case 3:
                        ClienteView.ListarCliente();
                        break;
                }

            } while (opt != 0);
        }
    }
}

using System;
using System.Globalization;
using Sistema_Bancario.Entities;
using Sistema_Bancario.Exceptions;

namespace Sistema_Bancario
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client("Rodrigo Quaresma", "123456789-10", 123456);
            int tentativas = 0;

            Console.WriteLine("Seja bem-vindo(a) ao nosso Banco!");
            Console.WriteLine();
            Console.WriteLine("O meu nome é Code e sou o seu assistente virtual. Para prosseguirmos, preciso que digite o seu nome completo, cpf e senha, ok?");
            Console.WriteLine();
            Console.Write("Digite 's' (sim) para prosseguir ou 'n' (não) para sair: ");
            char choice = char.Parse(Console.ReadLine());

            if (choice == 's' || choice == 'S')
            {
                Console.Clear();
                Console.WriteLine("Certo, vamos lá!");
                Console.WriteLine();
                Console.Write("Qual é o seu nome? ");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Agora o seu cpf (xxxxxxxxx-xx): ");
                string userCpf = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Opa, só falta a senha, aquela mesma de seis dígitos: ");
                int userSenha = int.Parse(Console.ReadLine());
                
                while (userSenha != client.Senha)
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta. Tente novamente.");
                    Console.WriteLine();
                    Console.Write("Senha: ");
                    userSenha = int.Parse(Console.ReadLine());
                    tentativas++;                    
                }

                

                Console.Clear();
                Console.WriteLine("Olá, " + client.Name + "! Me diga qual dessas opções você deseja:");
                Console.WriteLine();
                Console.WriteLine("1- Depósito");
                Console.WriteLine("2- Empréstimo");
                Console.WriteLine("3- Saldo");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Até mais, volte sempre!");
            }

        }
    }
}

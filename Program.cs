using System;
using System.Globalization;
using Sistema_Bancario.Entities;


namespace Sistema_Bancario
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client();
            Account acc = new Account();

            Console.WriteLine("Olá, seja muito bem vindo(a) ao nosso Banco!");
            Console.WriteLine();
            Console.WriteLine("O meu nome é Code (*|*), sou o seu assistente virtual.");
            Console.WriteLine();
            Console.WriteLine("Vamos começar? Para isso eu preciso de alguns dados como nome e senha. Dessa forma eu consigo encontrar a sua conta. Beleza?");
            Console.WriteLine();
            Console.WriteLine("Então, vamos lá!");
            Console.WriteLine();
            Console.Write("Nome: ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Senha: ");
            int userSenha = int.Parse(Console.ReadLine());

            if (userName == client.Name && userSenha == client.Senha)
            {
                Console.Clear();
                Console.WriteLine("Olá, " + client.Name + "! Abaixo estão os dados da sua conta, o que você gostaria de fazer?");
                Console.WriteLine();
                Console.WriteLine(acc);
                Console.WriteLine();
                Console.WriteLine("1- Depósito ");
                Console.WriteLine("2- Saque ");
                Console.WriteLine("3- Saldo ");
                Console.WriteLine("Para sair, digite qualquer tecla ");
                Console.WriteLine();
                Console.Write("Opção desejada: ");
                char c1 = char.Parse(Console.ReadLine());

                if (c1 == '1')
                {
                    Console.Clear();
                    Console.WriteLine("**Depósito**");
                    Console.WriteLine();
                    Console.Write("Qual valor você deseja depositar? ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    acc.Deposit(quantia);
                    Console.WriteLine("Depósito confirmado!");
                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados:");
                    Console.WriteLine(acc);
                }
                else if (c1 == '2')
                {
                    Console.Clear();
                    Console.WriteLine("**Saque**");
                    Console.WriteLine();
                    Console.Write("Qual valor você deseja sacar? ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    acc.Deposit(quantia);
                    Console.WriteLine("Saque confirmado!");
                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados:");
                    Console.WriteLine(acc);
                }
                else if (c1 == '3')
                {
                    Console.Clear();
                    Console.WriteLine("**Saldo**");                    
                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados:");
                    Console.WriteLine(acc);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado e até logo!");
                }           

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dados incorretos: Tente mais tarde.");
            }



























        }
    }
}

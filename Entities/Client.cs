using Sistema_Bancario.Exceptions;

namespace Sistema_Bancario.Entities

{
    internal class Client
    {
        public string Name = "Rodrigo Quaresma";
        public string Cpf = "123456789-10";
        public int Senha = 123456;

        public Client()
        {            
        }

        public Client(string name, string cpf, int senha) 
        {
            Name = name;
            Cpf = cpf;
            Senha = senha;
        }       

        
                      

        public override string ToString()
        {
            return "Name: " + Name + " - Cpf: " + Cpf;
        }
    }

}

namespace Sistema_Bancario.Entities

{
    internal class Client
    {
        public string Name = "Rodrigo Quaresma";        
        public int Senha = 123456;
        public Account Number { get; set; }

        public Client()
        {
        }

        public Client(string name, int senha, Account number)
        {
            Name = name;
            Senha = senha;
            Number = number;
        }
    }

}

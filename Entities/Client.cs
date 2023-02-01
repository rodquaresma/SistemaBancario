namespace Sistema_Bancario.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, int cpf, string email, DateTime birthDate)
        {
            Name = name;
            Cpf = cpf;
            Email = email;
            BirthDate = birthDate;
        }
    }

}

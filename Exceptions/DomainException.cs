using System;

namespace Sistema_Bancario.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}

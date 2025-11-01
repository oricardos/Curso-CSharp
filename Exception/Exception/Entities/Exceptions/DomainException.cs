using System;

namespace Exception.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) {}
    }
}
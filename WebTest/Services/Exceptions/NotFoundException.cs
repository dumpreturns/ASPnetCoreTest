using System;


namespace WebTest.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
            //excecao personalizada
        }
    }
}

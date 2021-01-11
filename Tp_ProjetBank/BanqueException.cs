using System;

namespace Tp_ProjetBank
{
    class BanqueException : Exception
    {
        public BanqueException() : base()
        {            
        }
        public BanqueException(string message)
        {
            Console.WriteLine("Message : " + message);
        }
        public BanqueException(Exception exception)
        {
            Console.WriteLine("Exception : " + exception);
        }
        public BanqueException(string message, Exception exception)
        {
            Console.WriteLine(message + ", exception : " + exception);
        }

    }
}

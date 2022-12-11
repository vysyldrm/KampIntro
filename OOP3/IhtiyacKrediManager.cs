using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi odeme plani hesaplandi.");
        }
    }
}

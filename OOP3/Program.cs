using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();
            //List<ILoggerService> loggers = new List<ILoggerService> {databaseLoggerService, fileLoggerService }

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, logers);
            basvuruManager.BasvuruYap(tasitKrediManager, 
                new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});

            basvuruManager.BasvuruYap(konutKrediManager, 
                new List<ILoggerService> { new DatabaseLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}

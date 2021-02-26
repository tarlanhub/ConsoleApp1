using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager = new KonutKrediManager();

            

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };
            
            
            
            BasvuruManager basvurumanager = new BasvuruManager();
            basvurumanager.BasvuruYap(ihtiyacKrediManager, loggers);
           
            
            
            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager, tasitKrediManager,konutKrediManager};
            //basvurumanager.KrediOnBilgilendirmesiYap(krediler);

                
        }
    }
}

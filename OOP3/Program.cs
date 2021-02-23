using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvurumanager = new BasvuruManager();
            //basvurumanager.BasvuruYap(ihtiyacKrediManager);
            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager, tasitKrediManager};
            basvurumanager.KrediOnBilgilendirmesiYap(krediler);

                
        }
    }
}

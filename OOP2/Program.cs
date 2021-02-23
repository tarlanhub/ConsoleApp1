using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNo = "12345";
            musteri1.Name = "Tarlan";
            musteri1.Surname = "Abdullayev";
            musteri1.NationalNo = "123234434";
            musteri1.Id = 23;


            //corporatecustomer
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.TaxNo = "121212";
            musteri2.CompanyName = "Apple";
            musteri2.CustomerNo = "121212";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);




        }
    }
}

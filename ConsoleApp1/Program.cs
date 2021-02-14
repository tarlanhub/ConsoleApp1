using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//typesafety
			string kategorietiketi = "kategori";
			int ogrencisayisi = 32000;
			bool sistemegirisyapmismi = true;

			double dolarDun = 7.35;
			double dolarBugun = 7.45;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış Butonu");
			}
			else if (dolarDun<dolarBugun)
			{
				Console.WriteLine("Artış oku");
			}
			else	
			{
				Console.WriteLine("Giris yap butonu");
			}

			if (sistemegirisyapmismi == true)
			{
				Console.WriteLine("Kulanıcı ayarları butonu");
						
			}
			else
			{
				Console.WriteLine("Giris yap butonu");
			}
			Console.WriteLine(kategorietiketi);


		}
	}
}

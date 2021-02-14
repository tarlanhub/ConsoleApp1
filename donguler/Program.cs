using System;

namespace donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			string kurs1 = "Yazilim Geliştrici Yetiştirme kampı";
			string kurs2 = "Programlamaya başlamak için temel kurs";
			string kurs3 = "Java";

			//array = dizi

			string[] kurslar = new string[] { "Yazilim Geliştrici Yetiştirme kampı", 
				"Programlamaya başlamak için temel kurs", "Java" };

			for (int i = 0; i < kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);
			}

            foreach (string kurs in kurslar)
            {
				Console.WriteLine(kurs);
            }


			Console.WriteLine("Console sonu");
		
		}
	}
}

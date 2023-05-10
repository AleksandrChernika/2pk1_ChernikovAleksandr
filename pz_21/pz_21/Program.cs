using System;

namespace pz_21
{
	class Program
	{
		public static void Main(string[] args)
		{
			Adress adress1 = new Adress();
			Adress adress2 = new Adress(Console.ReadLine());
			Adress adress3 = new Adress(Console.ReadLine(), Console.ReadLine());
			Adress adress4 = new Adress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			Adress.GetAdress(adress1);
			Console.WriteLine();
			Adress.GetAdress(adress2);
			Console.WriteLine();
			Adress.GetAdress(adress3);
			Console.WriteLine();
			Adress.GetAdress(adress4);
			Console.ReadKey(true);
		}
	}
}
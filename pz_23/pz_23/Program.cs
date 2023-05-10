using System;

namespace pz_23
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Создание адресов");
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
            Console.WriteLine("Количество адрессов");
            Adress.Shet();
            Console.WriteLine();
            Console.WriteLine("Создание удалённых адресов");
			RemoteAdress remoteadress1 = new RemoteAdress(Console.ReadLine(),Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
			RemoteAdress remoteadress2 = new RemoteAdress(Console.ReadLine(),Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            RemoteAdress remoteadress3 = new RemoteAdress(Console.ReadLine(),Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("Удалённые адреса: ");
            RemoteAdress.GetAdress(remoteadress1);
            Console.WriteLine();
            RemoteAdress.GetAdress(remoteadress2);
            Console.WriteLine();
			RemoteAdress.GetAdress(remoteadress3);
			Console.ReadKey(true);
		}
	}
}
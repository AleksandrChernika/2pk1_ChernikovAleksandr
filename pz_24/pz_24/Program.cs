using System;

namespace pz_24
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
			Console.WriteLine();

            RemoteAdress remoteadress4 = (RemoteAdress)remoteadress1.Clone();
			remoteadress4.Country = "Россия";
			remoteadress4.City = "Москва";
            RemoteAdress remoteadress5 = (RemoteAdress)remoteadress4.Clone();
            remoteadress5.City = "Ростов";
            RemoteAdress remoteadress6 = (RemoteAdress)remoteadress5.Clone();
            remoteadress6.City = "Кострома";

            Console.WriteLine("Клонированные удалённые адресса");
            Adress.GetAdress(remoteadress4);
            Console.WriteLine();
            Adress.GetAdress(remoteadress5);
            Console.WriteLine();
			Adress.GetAdress(remoteadress6);
			Console.WriteLine();

			Console.WriteLine("Клонирование Адресов");
			Adress adress5 = (Adress)adress1.Clone();
            adress5.Country = "Россия";
			adress5.City = "Москва";
            Adress adress6 = (Adress)adress5.Clone();
            adress6.Country = "Россия";
            adress6.City = "Волгоград";
            Adress adress7 = (Adress)adress6.Clone();
            adress7.Country = "Россия";
            adress7.City = "Севастополь";

			Adress.GetAdress(adress5);
			Console.WriteLine();
            Adress.GetAdress(adress6);
            Console.WriteLine();
            Adress.GetAdress(adress7);
            Console.ReadKey(true);
		}
	}
}
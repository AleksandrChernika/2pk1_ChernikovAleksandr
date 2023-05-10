using System;

namespace pz_23
{
	public class RemoteAdress : Adress
	{
		public string Reason {get; set;}
		public RemoteAdress(string country, string city, string street, string Reason)
		{
		this.Country = country;
        this.City = city;
        this.Street = street;
        this.Reason = Reason;
		}
		public static void GetAdress(RemoteAdress a)
        {
			Console.WriteLine("Страна: "  + a.Country);
			Console.WriteLine("Город: " + a.City);
			Console.WriteLine("Улица: " + a.Street);
			Console.WriteLine("Дом: " + a.House);
			Console.WriteLine("Этаж: " + a.Flat);
			Console.WriteLine("Причина удаления: " + a.Reason);
        }
	}
}

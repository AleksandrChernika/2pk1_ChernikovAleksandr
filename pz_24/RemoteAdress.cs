using System;

namespace pz_24
{
	public class RemoteAdress : Adress, ICloneable
	{
		public object Clone()
		{
			return new RemoteAdress(Country, City, Street, Reason);
		}
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

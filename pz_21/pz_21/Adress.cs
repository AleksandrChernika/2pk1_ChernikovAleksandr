using System;

namespace pz_21
{
	public class Adress
	{
		public string country;
        public string city;
        public string street;
        public int house;
        public int flat;
        public string country1 = "Нет страны";
        public string city1 = "Нет города";
        public string street1 = "Нет улицы";
        public int house1 = 1;
        public int flat1 = 1;
		public Adress()
		{
	 	this.country = country1;
        this.city = city1;
        this.street = street1;
        this.house = house1;
        this.flat = flat1;
		}
		public Adress(string country)
		{
	 	this.country = country;
        this.city = city1;
        this.street = street1;
        this.house = house1;
        this.flat = flat1;
		}
		public Adress(string country, string city)
		{
	 	this.country = country1;
        this.city = city1;
        this.street = street1;
        this.house = house1;
        this.flat = flat1;
		}
		public Adress(string country, string city, string street)
		{
		this.country = country1;
        this.city = city1;
        this.street = street1;
        this.house = house1;
        this.flat = flat1;
		}
		public static void GetAdress(Adress a)
       {
			Console.WriteLine("Страна: "  + a.country);
			Console.WriteLine("Город: " + a.city);
			Console.WriteLine("Улица: " + a.street);
			Console.WriteLine("Дом: " + a.house);
			Console.WriteLine("Этаж: " + a.flat);
       }
	}
}

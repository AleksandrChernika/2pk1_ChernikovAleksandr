using System;

namespace pz_23
{
	public class Adress
	{
		private static int d;
		public static int c;
		private string country;
		public string Country
		{
			set
			{
				if (value != null & value !="")
				{
					country = value;
				}
				else country = country1;
			}
			get{return country;}
		}
		private string city;
		public string City
		{
			set
			{
				if (value != null & value !="")
				{
					city = value;
				}
				else city = city1;
			}
			get{return city;}
		}
		private string street;
		public string Street
		{
			set
			{
				if (value != null & value !="")
				{
					street = value;
				}
				else street = street1;
			}
			get{return street;}
		}
		private double house;
		public double House
		{
			set
			{
				if (value != null)
				{
					house = value;
				}
				else house = house1;
			}
			get{return house;}
		}
		private int flat;
		public int Flat
		{
			set
			{
				if (value != null)
				{
					flat = value;
				}
				else flat = flat1;
			}
			get{return flat;}
		}
		public string country1 = "Нет страны";
        public string city1 = "Нет города";
        public string street1 = "Нет улицы";
        public int house1 = 1;
        public int flat1 = 1;
		
		public Adress()
		{
		d++;
	 	this.Country = country;
        this.City = city;
        this.Street = street;
        this.House = house;
        if (house / 2.0 == 0)
		{
				c++;
		}
        this.Flat = flat;
		}
		public Adress(string country)
		{
		d++;
	 	this.Country = country;
        this.City = city;
        this.Street = street;
        this.House = house;
        this.Flat = flat;
		}
		public Adress(string country, string city)
		{
		d++;
	 	this.Country = country;
        this.City = city;
        this.Street = street;
        this.House = house;
        this.Flat = flat;
		}
		public Adress(string country, string city, string street)
		{
		d++;
		this.Country = country;
        this.City = city;
        this.Street = street;
        this.House = house;
        this.Flat = flat;
		}
		public static void GetAdress(Adress a)
        {
			Console.WriteLine("Страна: "  + a.country);
			Console.WriteLine("Город: " + a.city);
			Console.WriteLine("Улица: " + a.street);
			Console.WriteLine("Дом: " + a.house);
			Console.WriteLine("Этаж: " + a.flat);
        }
		public static void HouseChet(Adress a)
		{
			if (a.house / 2.0 == 0)
		{
				c++;
		}
		}
		public static void Shet()
		{
			Console.WriteLine(d);
		}
	}
}

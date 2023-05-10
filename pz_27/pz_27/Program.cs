using System;

namespace pz_27
{
	class Program
	{
		public static void Main(string[] args)
		{
			AEROFLOT plane1 = new AEROFLOT("Москва", 1, "A");
			AEROFLOT plane2 = new AEROFLOT("Петербург", 2, "B");
			AEROFLOT plane3 = new AEROFLOT("Москва", 3, "C");
			AEROFLOT plane4 = new AEROFLOT("Москва", 4, "D");
			AEROFLOT plane5 = new AEROFLOT("Петербург", 5, "A");
			AEROFLOT plane6 = new AEROFLOT("Москва", 6, "B");
			AEROFLOT plane7 = new AEROFLOT("Волгоград", 7, "C");
			AEROFLOT[] AIRPORT = new AEROFLOT[7] {plane1, plane2, plane3, plane4, plane5, plane6, plane7};
			Console.WriteLine("Добавить новый самолёт?");
			string c = Console.ReadLine();
			if (c == "Да") 
			{
				AIRPORT = Adding(AIRPORT);
			}
			foreach (AEROFLOT a in AIRPORT)
			{
				Console.WriteLine(a.NUMR);
			}
			Console.WriteLine("Введите тип самолёта");
			string d = Console.ReadLine();
			MARSHRUT(AIRPORT, ref d);
			Console.ReadKey(true);
		}
		
		public static AEROFLOT[] Adding(AEROFLOT[] air)
		{
			Array.Resize(ref air, air.Length+1);
			air[air.Length-1] = new AEROFLOT(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
			return air;
		}
		public static void MARSHRUT(AEROFLOT[] air, ref string d)
		{
			int f = 0;
			for (int i = 0; i < air.Length; i++) 
			{
				
				if (air[i].TIP == d) 
				{
					Console.WriteLine("Пункт назначения " + air[i].NAZN + " " + "Номер рейса " + air[i].NUMR);
					f++;
				}
			}
			if (f == 0) 
			{
				Console.WriteLine("Нет рейсов");
			}
		}
	}
}
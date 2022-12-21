/*
 * Created by SharpDevelop.
 * User: sherganov.bb2340
 * Date: 28.11.2022
 * Time: 9:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace pz_16
{
	class Program
	{
		public static void Main(string[] args)
		{
			string path = @"D:\pz16.txt";
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader rd = new StreamReader(file);
			string [] mass = new string[10];
			int[] god = new int[10];
			int[] mes = new int[10];
			int[] den = new int[10];
 			for (int i = 0; i < mass.Length; i++) 
			{
				string str = rd.ReadLine();
				mass [i] = str;
			}
 			for (int i = 0; i < mass.Length; i++) 
 			{
 				god[i] = int.Parse(mass[i].Remove(4));
 				mes[i] = int.Parse(mass[i].Substring(5, 2));
 				den[i] = int.Parse(mass[i].Substring(8, 2));
 			} 
 			Array.Sort(god);
 			Console.WriteLine(mass[8]);
			rd.Close();
			Console.ReadKey();
		}
	}
}
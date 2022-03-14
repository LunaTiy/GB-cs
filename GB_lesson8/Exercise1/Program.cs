using System;

namespace Exercise1
{
	class Program
	{
		// 1. С помощью рефлексии выведите все свойства структуры DateTime.

		static void Main(string[] args)
		{
			Type typeOfDateTime = typeof(DateTime);
			
			foreach(var property in typeOfDateTime.GetProperties())
				Console.WriteLine(property.Name);
		}
	}
}

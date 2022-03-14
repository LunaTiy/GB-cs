using System;
using VouchersDB;

namespace Tests
{
	class Program
	{
		static void Main(string[] args)
		{
			Vouchers database = new Vouchers();

			database.Add(new Voucher("Moskow", "New York", 
				new DateTime(2022, 3, 14, 15, 30, 0), new DateTime(2022, 3, 14, 18, 0, 0), "USA airline"));
			database.Add(new Voucher("Boston", "London",
				new DateTime(2022, 3, 14, 15, 40, 0), new DateTime(2022, 3, 14, 18, 20, 0), "USA airline"));
			database.Add(new Voucher("Kazan", "Saint-Petersburg",
				new DateTime(2022, 3, 15, 16, 0, 0), new DateTime(2022, 3, 14, 18, 0, 0), "RUS airline"));

			Console.WriteLine("Vouchers:");
			for(int i = 0; i < database.Count; i++)
				Console.WriteLine(database[i]);

			Console.WriteLine("Saving db");
			database.Save("db.txt");

			database.Remove(1);

			Console.WriteLine("Vouchers after remove: ");
			for (int i = 0; i < database.Count; i++)
				Console.WriteLine(database[i]);

			database.Load("db.txt");

			Console.WriteLine("Vouchers after load");
			for (int i = 0; i < database.Count; i++)
				Console.WriteLine(database[i]);
		}
	}
}

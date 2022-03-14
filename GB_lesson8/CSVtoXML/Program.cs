using System;

namespace ConverterCSVtoXML
{
	class Program
	{
		static void Main(string[] args)
		{
			Students students = new Students();
			string fileNameCsv = "students.csv";
			string fileNameXml = "students.xml";

			students.ReadFromCsv(fileNameCsv);

			Console.WriteLine("Read from csv file:");
			for(int i = 0; i < 10; i++)
				Console.WriteLine(students[i]);

			Console.WriteLine("Write in xml file");
			students.WriteToXml(fileNameXml);

			students.ReadFromXml(fileNameXml);

			Console.WriteLine("Read from xml file");
			for (int i = 0; i < 10; i++)
				Console.WriteLine(students[i]);
		}
	}
}

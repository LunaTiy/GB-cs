using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace ConverterCSVtoXML
{
	class Students
	{
		private List<Student> _students;

		public Students()
		{
			_students = new List<Student>();
		}

		public Student this[int index]
		{
			get
			{
				if (index >= _students.Count) return null;

				return _students[index];
			}
		}

		public int Count { get => _students.Count; }

		public void WriteToCsv(string fileName)
		{
			if (_students.Count == 0) return;

			if (!new Regex(@"\w+\.csv\z", RegexOptions.IgnoreCase).IsMatch(fileName)) return;

			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs);

			foreach (Student student in _students)
				sw.WriteLine(student.ToStringSavingCsv(';'));

			sw.Close();
			fs.Close();
		}

		public void ReadFromCsv(string fileName)
		{
			if (!File.Exists(fileName)) return;

			StreamReader sr = new StreamReader(fileName);

			while (!sr.EndOfStream)
			{
				string[] line = sr.ReadLine().Split(';');
				_students.Add(new Student(line[0], line[1], line[2], line[3], line[4], int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]), line[8]));
			}

			sr.Close();
		}

		public void WriteToXml(string fileName)
		{
			if (_students.Count == 0) return;

			if (!new Regex(@"\w+\.xml\z", RegexOptions.IgnoreCase).IsMatch(fileName)) return;

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

			xmlSerializer.Serialize(fs, _students);

			fs.Close();
		}

		public void ReadFromXml(string fileName)
		{
			if (!File.Exists(fileName)) return;

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

			_students = (List<Student>)xmlSerializer.Deserialize(fs);

			fs.Close();
		}
	}
}

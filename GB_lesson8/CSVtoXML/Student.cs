using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterCSVtoXML
{
	public class Student
	{
		public Student()
		{
			FirstName = "";
			SecondName = "";
			University = "";
			Faculty = "";
			Department = "";
			Age = 0;
			Course = 0;
			Group = 0;
			City = "";
		}

		public Student(string firtsName, string secondName, string university,
			string faculty, string department, int age, int course, int group, string city)
		{
			FirstName = firtsName;
			SecondName = secondName;
			University = university;
			Faculty = faculty;
			Department = department;
			Age = age;
			Course = course;
			Group = group;
			City = city;
		}

		#region Properties

		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string University { get; set; }
		public string Faculty { get; set; }
		public string Department { get; set; }
		public int Age { get; set; }
		public int Course { get; set; }
		public int Group { get; set; }
		public string City { get; set; }

		#endregion

		public override string ToString()
		{
			return $"{FirstName,15}{SecondName,25}{University,30}{Faculty,25}{Department,30}{Age,4}{Course,3}{Group,3}{City,25}";
		}

		public string ToStringSavingCsv(char split)
		{
			return $"{FirstName}{split}{SecondName}{split}{University}{split}{Faculty}{split}" +
				$"{Department}{split}{Age}{split}{Course}{split}{Group}{split}{City}";
		}
	}
}

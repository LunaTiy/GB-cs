using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_lesson6
{
	class Student
	{
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

		public string FirstName { get; private set; }
		public string SecondName { get; private set; }
		public string University { get; private set; }
		public string Faculty { get; private set; }
		public string Department { get; private set; }
		public int Age { get; private set; }
		public int Course { get; private set; }
		public int Group { get; private set; }
		public string City { get; private set; }

		#endregion

		public override string ToString()
		{
			return $"{FirstName, 15}{SecondName, 25}{University, 30}{Faculty, 25}{Department, 30}{Age, 4}{Course, 3}{Group, 3}{City, 25}";
		}

		public string ToStringCsv(char split)
		{
			return $"{FirstName}{split}{SecondName}{split}{University}{split}{Faculty}{split}" +
				$"{Department}{split}{Age}{split}{Course}{split}{Group}{split}{City}";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDB
{
	public class Student
	{
		private string _firstName;
		private string _secondName;
		private DateTime _birthday;

		public Student()
		{
			FirstName = "None";
			SecondName = "None";
			Birthday = DateTime.Now;
		}

		public Student(string firstName, string secondName, DateTime birthday)
		{
			FirstName = firstName;
			SecondName = secondName;
			Birthday = birthday;
		}

		public string FirstName
		{
			get => _firstName;
			set
			{
				if (value.Length > 0 && value.Length < 10) _firstName = value;
			}
		}

		public string SecondName
		{
			get => _secondName;
			set
			{
				if (value.Length > 0 && value.Length < 10) _secondName = value;
			}
		}

		public DateTime Birthday
		{
			get => _birthday;
			set
			{
				if (value <= DateTime.Now) _birthday = value;
			}
		}
	}
}

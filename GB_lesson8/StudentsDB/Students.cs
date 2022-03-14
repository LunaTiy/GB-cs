using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace StudentsDB
{
	public class Students
	{
		private List<Student> _students;
		private int _indexCurrentStudent;

		public event Action UpdateInfo;

		public Students()
		{
			_students = new List<Student>();
			_indexCurrentStudent = 0;
		}

		public Student CurrentStudent
		{
			get
			{
				if (_students.Count < 1) return new Student();

				return _students[_indexCurrentStudent];
			}
		}

		public int IndexCurrentStudent
		{
			get => _indexCurrentStudent;
		}

		public void Next()
		{
			if (_indexCurrentStudent + 1 < _students.Count) _indexCurrentStudent++;

			UpdateInfo();
		}

		public void Prev()
		{
			if (_indexCurrentStudent - 1 >= 0) _indexCurrentStudent--;

			UpdateInfo();
		}

		public void Add(Student student)
		{
			_students.Add(student);
			_indexCurrentStudent = _students.Count - 1;

			UpdateInfo();
		}

		public void Remove()
		{
			if (_students.Count == 0) return;

			_students.RemoveAt(_indexCurrentStudent);
			Prev();
		}

		public void SaveDB(string fileName)
		{
			if (fileName.Length < 3) return;

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

			xmlSerializer.Serialize(fs, _students);
			fs.Close();
		}

		public void LoadDB(string fileName)
		{
			if (!File.Exists(fileName)) return;

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

			_students = (List<Student>)xmlSerializer.Deserialize(fs);
			fs.Close();
		}
	}
}

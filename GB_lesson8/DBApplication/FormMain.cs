using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsDB;

namespace DBApplication
{
	public partial class FormMain : Form
	{
		private Students _students;

		public FormMain()
		{
			InitializeComponent();
		}

		private void UpdateInfo()
		{
			tbId.Text = _students.IndexCurrentStudent + 1.ToString();
			tbFirstName.Text = _students.CurrentStudent.FirstName;
			tbSecondName.Text = _students.CurrentStudent.SecondName;
			tbBirthday.Text = _students.CurrentStudent.Birthday.ToString();
		}

		private void Enabled()
		{
			tsbtnPrev.Enabled = true;
			tsbtnNext.Enabled = true;
			tsbtnAdd.Enabled = true;
			tsbtnRemove.Enabled = true;
		}

		private void miExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void miNewDB_Click(object sender, EventArgs e)
		{
			_students = new Students();

			Enabled();
			UpdateInfo();
			_students.UpdateInfo += UpdateInfo;			

			MessageBox.Show("Database was created!");
		}

		private void miSaveAs_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "XML файлы|*.xml|Все файлы|*.*";

			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				_students.SaveDB(saveFileDialog.FileName);
			}
		}

		private void miLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "XML файлы|*.xml|Все файлы|*.*";

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_students = new Students();
				_students.LoadDB(openFileDialog.FileName);

				Enabled();
				UpdateInfo();
				_students.UpdateInfo += UpdateInfo;
			}
		}

		private void tsbtnPrev_Click(object sender, EventArgs e)
		{
			_students.Prev();
		}

		private void tsbtnNext_Click(object sender, EventArgs e)
		{
			_students.Next();
		}

		private void tsbtnAdd_Click(object sender, EventArgs e)
		{
			if(_students == null)
			{
				MessageBox.Show("Database was not created!");
				return;
			}

			FormAddNewStudent formAddNewStudent = new FormAddNewStudent();
			formAddNewStudent.ShowDialog();

			if(formAddNewStudent.DialogResult == DialogResult.OK)
			{
				_students.Add(formAddNewStudent.NewStudent);
			}
		}

		private void tsbtnRemove_Click(object sender, EventArgs e)
		{
			_students.Remove();
		}

		private void miAutor_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Autor: Daniil Savushkin\nCorporation: MyGames");
		}

		private void miVersion_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Version: 1.0.0 alpha\nLast update: " + new DateTime(2022, 3, 13, 23, 14, 00));
		}
	}
}

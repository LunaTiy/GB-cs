using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace GuessNumber
{
	public partial class FormEnterNewNumber : Form
	{
		public FormEnterNewNumber()
		{
			InitializeComponent();
		}

		private void btnEnterNewNumber_Click(object sender, EventArgs e)
		{
			int number;
			if (!int.TryParse(tbEnterNewNumber.Text, out number))
			{ 
				MessageBox.Show("Введите число!");
				return;
			}

			Data.Number = number;
			this.Close();
		}
	}
}

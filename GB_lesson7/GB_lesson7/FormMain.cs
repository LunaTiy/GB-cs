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
	public partial class FormMain : Form
	{
		private Game _game;
		public FormMain()
		{
			InitializeComponent();
		}

		private void miExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void miNewGame_Click(object sender, EventArgs e)
		{
			_game = new Game();
			UpdateInfo();
			tbLogs.Text = "";

			btnOpenFormNewNumber.Enabled = true;
		}

		private void btnOpenFormNewNumber_Click(object sender, EventArgs e)
		{
			FormEnterNewNumber form = new FormEnterNewNumber();
			form.ShowDialog();

			string message = _game.NewAttempt(Data.Number);

			MessageBox.Show(message);
			tbLogs.Text += message + "\r\n";

			if (_game.IsGame == false) btnOpenFormNewNumber.Enabled = false;

			UpdateInfo();
		}

		private void UpdateInfo()
		{
			tbCountAttempt.Text = _game.CountAttempt.ToString();
			tbMaxCountAttempt.Text = _game.MaxCountAttempt.ToString();
		}
	}
}

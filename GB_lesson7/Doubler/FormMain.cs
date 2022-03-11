using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
	public partial class FormMain : Form
	{
		private Doubler _doubler;

		public FormMain()
		{
			InitializeComponent();
		}

		private void UpdateInfo()
		{
			tbScore.Text = _doubler.CurrentNumber.ToString();
			tbTargetScore.Text = _doubler.TargetNumber.ToString();
			tbCountCommands.Text = _doubler.CountCommands.ToString();
		}

		private void EnableButtons()
		{
			btnPlus.Enabled = true;
			btnDoubler.Enabled = true;
			btnRevoke.Enabled = true;
			btnClear.Enabled = true;
		}

		private void DisableButtons()
		{
			btnPlus.Enabled = false;
			btnDoubler.Enabled = false;
			btnRevoke.Enabled = false;
			btnClear.Enabled = false;

			MessageBox.Show($"Победа!!!\nВам удалось достичь результата за {_doubler.CountCommands} ходов");
		}

		private void miNewGame_Click(object sender, EventArgs e)
		{
			_doubler = new Doubler();
			_doubler.EventUpdateInfo += UpdateInfo;
			_doubler.EventEndGame += DisableButtons;

			UpdateInfo();
			EnableButtons();

			MessageBox.Show("Необходимо получить число: " + _doubler.TargetNumber);
		}

		private void miExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			_doubler.PlusOne();
		}

		private void btnDoubler_Click(object sender, EventArgs e)
		{
			_doubler.MultTwo();
		}

		private void btnRevoke_Click(object sender, EventArgs e)
		{
			_doubler.Revoke();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			_doubler.Clear();
		}
	}
}


namespace GuessNumber
{
	partial class FormEnterNewNumber
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnterNewNumber));
			this.tbEnterNewNumber = new System.Windows.Forms.TextBox();
			this.btnEnterNewNumber = new System.Windows.Forms.Button();
			this.lInfoEnter = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbEnterNewNumber
			// 
			resources.ApplyResources(this.tbEnterNewNumber, "tbEnterNewNumber");
			this.tbEnterNewNumber.Name = "tbEnterNewNumber";
			// 
			// btnEnterNewNumber
			// 
			resources.ApplyResources(this.btnEnterNewNumber, "btnEnterNewNumber");
			this.btnEnterNewNumber.Name = "btnEnterNewNumber";
			this.btnEnterNewNumber.UseVisualStyleBackColor = true;
			this.btnEnterNewNumber.Click += new System.EventHandler(this.btnEnterNewNumber_Click);
			// 
			// lInfoEnter
			// 
			resources.ApplyResources(this.lInfoEnter, "lInfoEnter");
			this.lInfoEnter.Name = "lInfoEnter";
			// 
			// FormEnterNewNumber
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lInfoEnter);
			this.Controls.Add(this.btnEnterNewNumber);
			this.Controls.Add(this.tbEnterNewNumber);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormEnterNewNumber";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbEnterNewNumber;
		private System.Windows.Forms.Button btnEnterNewNumber;
		private System.Windows.Forms.Label lInfoEnter;
	}
}
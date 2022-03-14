
namespace DBApplication
{
	partial class FormAddNewStudent
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.lFirstName = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.tbSecondName = new System.Windows.Forms.TextBox();
			this.lSecondName = new System.Windows.Forms.Label();
			this.lBirthday = new System.Windows.Forms.Label();
			this.dtBirthday = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(12, 197);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(84, 29);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(117, 197);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(94, 29);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lFirstName
			// 
			this.lFirstName.AutoSize = true;
			this.lFirstName.Location = new System.Drawing.Point(12, 9);
			this.lFirstName.Name = "lFirstName";
			this.lFirstName.Size = new System.Drawing.Size(116, 20);
			this.lFirstName.TabIndex = 2;
			this.lFirstName.Text = "Input first name:";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(12, 32);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(125, 27);
			this.tbFirstName.TabIndex = 3;
			// 
			// tbSecondName
			// 
			this.tbSecondName.Location = new System.Drawing.Point(12, 86);
			this.tbSecondName.Name = "tbSecondName";
			this.tbSecondName.Size = new System.Drawing.Size(125, 27);
			this.tbSecondName.TabIndex = 5;
			// 
			// lSecondName
			// 
			this.lSecondName.AutoSize = true;
			this.lSecondName.Location = new System.Drawing.Point(12, 63);
			this.lSecondName.Name = "lSecondName";
			this.lSecondName.Size = new System.Drawing.Size(138, 20);
			this.lSecondName.TabIndex = 4;
			this.lSecondName.Text = "Input second name:";
			// 
			// lBirthday
			// 
			this.lBirthday.AutoSize = true;
			this.lBirthday.Location = new System.Drawing.Point(12, 116);
			this.lBirthday.Name = "lBirthday";
			this.lBirthday.Size = new System.Drawing.Size(105, 20);
			this.lBirthday.TabIndex = 6;
			this.lBirthday.Text = "Input birthday:";
			// 
			// dtBirthday
			// 
			this.dtBirthday.Location = new System.Drawing.Point(12, 139);
			this.dtBirthday.Name = "dtBirthday";
			this.dtBirthday.Size = new System.Drawing.Size(158, 27);
			this.dtBirthday.TabIndex = 7;
			// 
			// FormAddNewStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 238);
			this.Controls.Add(this.dtBirthday);
			this.Controls.Add(this.lBirthday);
			this.Controls.Add(this.tbSecondName);
			this.Controls.Add(this.lSecondName);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.lFirstName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormAddNewStudent";
			this.Text = "Adding a student";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lFirstName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.TextBox tbSecondName;
		private System.Windows.Forms.Label lSecondName;
		private System.Windows.Forms.Label lBirthday;
		private System.Windows.Forms.DateTimePicker dtBirthday;
	}
}
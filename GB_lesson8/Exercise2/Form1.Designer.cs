
namespace Exercise2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numUpDown = new System.Windows.Forms.NumericUpDown();
			this.tbValue = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// numUpDown
			// 
			this.numUpDown.Location = new System.Drawing.Point(12, 12);
			this.numUpDown.Name = "numUpDown";
			this.numUpDown.Size = new System.Drawing.Size(150, 27);
			this.numUpDown.TabIndex = 0;
			this.numUpDown.ValueChanged += new System.EventHandler(this.numUpDown_ValueChanged);
			// 
			// tbValue
			// 
			this.tbValue.BackColor = System.Drawing.SystemColors.Window;
			this.tbValue.Location = new System.Drawing.Point(188, 12);
			this.tbValue.Name = "tbValue";
			this.tbValue.PlaceholderText = "Change value";
			this.tbValue.ReadOnly = true;
			this.tbValue.Size = new System.Drawing.Size(125, 27);
			this.tbValue.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 54);
			this.Controls.Add(this.tbValue);
			this.Controls.Add(this.numUpDown);
			this.Name = "Form1";
			this.Text = "Exercise 2";
			((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numUpDown;
		private System.Windows.Forms.TextBox tbValue;
	}
}



namespace GuessNumber
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.miFile = new System.Windows.Forms.ToolStripMenuItem();
			this.miNewGame = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.btnOpenFormNewNumber = new System.Windows.Forms.Button();
			this.tbLogs = new System.Windows.Forms.TextBox();
			this.lCountAttempt = new System.Windows.Forms.Label();
			this.lMaxCountAttempt = new System.Windows.Forms.Label();
			this.tbCountAttempt = new System.Windows.Forms.TextBox();
			this.tbMaxCountAttempt = new System.Windows.Forms.TextBox();
			this.lLogs = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// miFile
			// 
			this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewGame,
            this.toolStripMenuItem1,
            this.miExit});
			this.miFile.Name = "miFile";
			resources.ApplyResources(this.miFile, "miFile");
			// 
			// miNewGame
			// 
			this.miNewGame.Name = "miNewGame";
			resources.ApplyResources(this.miNewGame, "miNewGame");
			this.miNewGame.Click += new System.EventHandler(this.miNewGame_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			resources.ApplyResources(this.miExit, "miExit");
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// btnOpenFormNewNumber
			// 
			resources.ApplyResources(this.btnOpenFormNewNumber, "btnOpenFormNewNumber");
			this.btnOpenFormNewNumber.Name = "btnOpenFormNewNumber";
			this.btnOpenFormNewNumber.UseVisualStyleBackColor = true;
			this.btnOpenFormNewNumber.Click += new System.EventHandler(this.btnOpenFormNewNumber_Click);
			// 
			// tbLogs
			// 
			resources.ApplyResources(this.tbLogs, "tbLogs");
			this.tbLogs.Name = "tbLogs";
			this.tbLogs.ReadOnly = true;
			// 
			// lCountAttempt
			// 
			resources.ApplyResources(this.lCountAttempt, "lCountAttempt");
			this.lCountAttempt.Name = "lCountAttempt";
			// 
			// lMaxCountAttempt
			// 
			resources.ApplyResources(this.lMaxCountAttempt, "lMaxCountAttempt");
			this.lMaxCountAttempt.Name = "lMaxCountAttempt";
			// 
			// tbCountAttempt
			// 
			resources.ApplyResources(this.tbCountAttempt, "tbCountAttempt");
			this.tbCountAttempt.Name = "tbCountAttempt";
			this.tbCountAttempt.ReadOnly = true;
			// 
			// tbMaxCountAttempt
			// 
			resources.ApplyResources(this.tbMaxCountAttempt, "tbMaxCountAttempt");
			this.tbMaxCountAttempt.Name = "tbMaxCountAttempt";
			this.tbMaxCountAttempt.ReadOnly = true;
			// 
			// lLogs
			// 
			resources.ApplyResources(this.lLogs, "lLogs");
			this.lLogs.Name = "lLogs";
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.lLogs);
			this.Controls.Add(this.tbMaxCountAttempt);
			this.Controls.Add(this.tbCountAttempt);
			this.Controls.Add(this.lMaxCountAttempt);
			this.Controls.Add(this.lCountAttempt);
			this.Controls.Add(this.tbLogs);
			this.Controls.Add(this.btnOpenFormNewNumber);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem miFile;
		private System.Windows.Forms.ToolStripMenuItem miNewGame;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.Button btnOpenFormNewNumber;
		private System.Windows.Forms.TextBox tbLogs;
		private System.Windows.Forms.Label lCountAttempt;
		private System.Windows.Forms.Label lMaxCountAttempt;
		private System.Windows.Forms.TextBox tbCountAttempt;
		private System.Windows.Forms.TextBox tbMaxCountAttempt;
		private System.Windows.Forms.Label lLogs;
	}
}


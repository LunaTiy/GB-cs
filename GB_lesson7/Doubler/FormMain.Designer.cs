
namespace Doubler
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
			this.gbInfo = new System.Windows.Forms.GroupBox();
			this.tbTargetScore = new System.Windows.Forms.TextBox();
			this.lTargetScore = new System.Windows.Forms.Label();
			this.tbScore = new System.Windows.Forms.TextBox();
			this.lScore = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiProperties = new System.Windows.Forms.ToolStripMenuItem();
			this.miNewGame = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.gbControl = new System.Windows.Forms.GroupBox();
			this.tbCountCommands = new System.Windows.Forms.TextBox();
			this.lCountCommands = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnRevoke = new System.Windows.Forms.Button();
			this.btnDoubler = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.gbInfo.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.gbControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbInfo
			// 
			this.gbInfo.Controls.Add(this.tbTargetScore);
			this.gbInfo.Controls.Add(this.lTargetScore);
			this.gbInfo.Controls.Add(this.tbScore);
			this.gbInfo.Controls.Add(this.lScore);
			this.gbInfo.Location = new System.Drawing.Point(12, 41);
			this.gbInfo.Name = "gbInfo";
			this.gbInfo.Size = new System.Drawing.Size(147, 157);
			this.gbInfo.TabIndex = 0;
			this.gbInfo.TabStop = false;
			this.gbInfo.Text = "Info";
			// 
			// tbTargetScore
			// 
			this.tbTargetScore.Location = new System.Drawing.Point(16, 111);
			this.tbTargetScore.Name = "tbTargetScore";
			this.tbTargetScore.ReadOnly = true;
			this.tbTargetScore.Size = new System.Drawing.Size(99, 27);
			this.tbTargetScore.TabIndex = 3;
			// 
			// lTargetScore
			// 
			this.lTargetScore.AutoSize = true;
			this.lTargetScore.Location = new System.Drawing.Point(16, 88);
			this.lTargetScore.Name = "lTargetScore";
			this.lTargetScore.Size = new System.Drawing.Size(53, 20);
			this.lTargetScore.TabIndex = 2;
			this.lTargetScore.Text = "Target:";
			// 
			// tbScore
			// 
			this.tbScore.Location = new System.Drawing.Point(16, 55);
			this.tbScore.Name = "tbScore";
			this.tbScore.ReadOnly = true;
			this.tbScore.Size = new System.Drawing.Size(99, 27);
			this.tbScore.TabIndex = 1;
			// 
			// lScore
			// 
			this.lScore.AutoSize = true;
			this.lScore.Location = new System.Drawing.Point(16, 32);
			this.lScore.Name = "lScore";
			this.lScore.Size = new System.Drawing.Size(49, 20);
			this.lScore.TabIndex = 0;
			this.lScore.Text = "Score:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProperties});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(368, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiProperties
			// 
			this.tsmiProperties.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewGame,
            this.toolStripMenuItem1,
            this.miExit});
			this.tsmiProperties.Name = "tsmiProperties";
			this.tsmiProperties.Size = new System.Drawing.Size(90, 24);
			this.tsmiProperties.Text = "Properties";
			// 
			// miNewGame
			// 
			this.miNewGame.Name = "miNewGame";
			this.miNewGame.Size = new System.Drawing.Size(164, 26);
			this.miNewGame.Text = "New game";
			this.miNewGame.Click += new System.EventHandler(this.miNewGame_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(164, 26);
			this.miExit.Text = "Exit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// gbControl
			// 
			this.gbControl.Controls.Add(this.tbCountCommands);
			this.gbControl.Controls.Add(this.lCountCommands);
			this.gbControl.Controls.Add(this.btnClear);
			this.gbControl.Controls.Add(this.btnRevoke);
			this.gbControl.Controls.Add(this.btnDoubler);
			this.gbControl.Controls.Add(this.btnPlus);
			this.gbControl.Location = new System.Drawing.Point(181, 41);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(170, 157);
			this.gbControl.TabIndex = 2;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "Control";
			// 
			// tbCountCommands
			// 
			this.tbCountCommands.Location = new System.Drawing.Point(54, 111);
			this.tbCountCommands.Name = "tbCountCommands";
			this.tbCountCommands.ReadOnly = true;
			this.tbCountCommands.Size = new System.Drawing.Size(64, 27);
			this.tbCountCommands.TabIndex = 5;
			this.tbCountCommands.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lCountCommands
			// 
			this.lCountCommands.AutoSize = true;
			this.lCountCommands.Location = new System.Drawing.Point(24, 88);
			this.lCountCommands.Name = "lCountCommands";
			this.lCountCommands.Size = new System.Drawing.Size(128, 20);
			this.lCountCommands.TabIndex = 4;
			this.lCountCommands.Text = "Count commands:";
			// 
			// btnClear
			// 
			this.btnClear.Enabled = false;
			this.btnClear.Location = new System.Drawing.Point(87, 58);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(77, 26);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnRevoke
			// 
			this.btnRevoke.Enabled = false;
			this.btnRevoke.Location = new System.Drawing.Point(6, 58);
			this.btnRevoke.Name = "btnRevoke";
			this.btnRevoke.Size = new System.Drawing.Size(77, 26);
			this.btnRevoke.TabIndex = 2;
			this.btnRevoke.Text = "Revoke";
			this.btnRevoke.UseVisualStyleBackColor = true;
			this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
			// 
			// btnDoubler
			// 
			this.btnDoubler.Enabled = false;
			this.btnDoubler.Location = new System.Drawing.Point(87, 26);
			this.btnDoubler.Name = "btnDoubler";
			this.btnDoubler.Size = new System.Drawing.Size(77, 26);
			this.btnDoubler.TabIndex = 1;
			this.btnDoubler.Text = "x2";
			this.btnDoubler.UseVisualStyleBackColor = true;
			this.btnDoubler.Click += new System.EventHandler(this.btnDoubler_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Enabled = false;
			this.btnPlus.Location = new System.Drawing.Point(6, 26);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(77, 26);
			this.btnPlus.TabIndex = 0;
			this.btnPlus.Text = "+1";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(368, 216);
			this.Controls.Add(this.gbControl);
			this.Controls.Add(this.gbInfo);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Игра \"Удвоитель\"";
			this.gbInfo.ResumeLayout(false);
			this.gbInfo.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gbControl.ResumeLayout(false);
			this.gbControl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbInfo;
		private System.Windows.Forms.TextBox tbTargetScore;
		private System.Windows.Forms.Label lTargetScore;
		private System.Windows.Forms.TextBox tbScore;
		private System.Windows.Forms.Label lScore;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiProperties;
		private System.Windows.Forms.ToolStripMenuItem miNewGame;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.GroupBox gbControl;
		private System.Windows.Forms.TextBox tbCountCommands;
		private System.Windows.Forms.Label lCountCommands;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnRevoke;
		private System.Windows.Forms.Button btnDoubler;
		private System.Windows.Forms.Button btnPlus;
	}
}


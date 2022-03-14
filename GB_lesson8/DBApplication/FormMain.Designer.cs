
namespace DBApplication
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
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miNewDB = new System.Windows.Forms.ToolStripMenuItem();
			this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.miLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miAutor = new System.Windows.Forms.ToolStripMenuItem();
			this.miVersion = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbtnPrev = new System.Windows.Forms.ToolStripButton();
			this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
			this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
			this.tsbtnRemove = new System.Windows.Forms.ToolStripButton();
			this.gbInfo = new System.Windows.Forms.GroupBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.lId = new System.Windows.Forms.Label();
			this.tbBirthday = new System.Windows.Forms.TextBox();
			this.lBirthday = new System.Windows.Forms.Label();
			this.tbSecondName = new System.Windows.Forms.TextBox();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.lSecondName = new System.Windows.Forms.Label();
			this.lFirstName = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.gbInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(296, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewDB,
            this.miSaveAs,
            this.miLoad,
            this.toolStripMenuItem1,
            this.miExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// miNewDB
			// 
			this.miNewDB.Name = "miNewDB";
			this.miNewDB.Size = new System.Drawing.Size(187, 26);
			this.miNewDB.Text = "New database";
			this.miNewDB.Click += new System.EventHandler(this.miNewDB_Click);
			// 
			// miSaveAs
			// 
			this.miSaveAs.Name = "miSaveAs";
			this.miSaveAs.Size = new System.Drawing.Size(187, 26);
			this.miSaveAs.Text = "Save as";
			this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
			// 
			// miLoad
			// 
			this.miLoad.Name = "miLoad";
			this.miLoad.Size = new System.Drawing.Size(187, 26);
			this.miLoad.Text = "Load";
			this.miLoad.Click += new System.EventHandler(this.miLoad_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(187, 26);
			this.miExit.Text = "Exit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAutor,
            this.miVersion});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// miAutor
			// 
			this.miAutor.Name = "miAutor";
			this.miAutor.Size = new System.Drawing.Size(224, 26);
			this.miAutor.Text = "Autor";
			this.miAutor.Click += new System.EventHandler(this.miAutor_Click);
			// 
			// miVersion
			// 
			this.miVersion.Name = "miVersion";
			this.miVersion.Size = new System.Drawing.Size(224, 26);
			this.miVersion.Text = "Version";
			this.miVersion.Click += new System.EventHandler(this.miVersion_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPrev,
            this.tsbtnNext,
            this.tsbtnAdd,
            this.tsbtnRemove});
			this.toolStrip1.Location = new System.Drawing.Point(0, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(296, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbtnPrev
			// 
			this.tsbtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbtnPrev.Enabled = false;
			this.tsbtnPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrev.Image")));
			this.tsbtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnPrev.Name = "tsbtnPrev";
			this.tsbtnPrev.Size = new System.Drawing.Size(33, 24);
			this.tsbtnPrev.Text = "<=";
			this.tsbtnPrev.Click += new System.EventHandler(this.tsbtnPrev_Click);
			// 
			// tsbtnNext
			// 
			this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbtnNext.Enabled = false;
			this.tsbtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNext.Image")));
			this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnNext.Name = "tsbtnNext";
			this.tsbtnNext.Size = new System.Drawing.Size(33, 24);
			this.tsbtnNext.Text = "=>";
			this.tsbtnNext.Click += new System.EventHandler(this.tsbtnNext_Click);
			// 
			// tsbtnAdd
			// 
			this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbtnAdd.Enabled = false;
			this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
			this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnAdd.Name = "tsbtnAdd";
			this.tsbtnAdd.Size = new System.Drawing.Size(29, 24);
			this.tsbtnAdd.Text = "+";
			this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
			// 
			// tsbtnRemove
			// 
			this.tsbtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbtnRemove.Enabled = false;
			this.tsbtnRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRemove.Image")));
			this.tsbtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnRemove.Name = "tsbtnRemove";
			this.tsbtnRemove.Size = new System.Drawing.Size(29, 24);
			this.tsbtnRemove.Text = "-";
			this.tsbtnRemove.Click += new System.EventHandler(this.tsbtnRemove_Click);
			// 
			// gbInfo
			// 
			this.gbInfo.Controls.Add(this.tbId);
			this.gbInfo.Controls.Add(this.lId);
			this.gbInfo.Controls.Add(this.tbBirthday);
			this.gbInfo.Controls.Add(this.lBirthday);
			this.gbInfo.Controls.Add(this.tbSecondName);
			this.gbInfo.Controls.Add(this.tbFirstName);
			this.gbInfo.Controls.Add(this.lSecondName);
			this.gbInfo.Controls.Add(this.lFirstName);
			this.gbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbInfo.Location = new System.Drawing.Point(0, 55);
			this.gbInfo.Name = "gbInfo";
			this.gbInfo.Size = new System.Drawing.Size(296, 254);
			this.gbInfo.TabIndex = 2;
			this.gbInfo.TabStop = false;
			this.gbInfo.Text = "Info";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(12, 50);
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(180, 27);
			this.tbId.TabIndex = 7;
			// 
			// lId
			// 
			this.lId.AutoSize = true;
			this.lId.Location = new System.Drawing.Point(12, 27);
			this.lId.Name = "lId";
			this.lId.Size = new System.Drawing.Size(25, 20);
			this.lId.TabIndex = 6;
			this.lId.Text = "Id:";
			// 
			// tbBirthday
			// 
			this.tbBirthday.Location = new System.Drawing.Point(12, 215);
			this.tbBirthday.Name = "tbBirthday";
			this.tbBirthday.ReadOnly = true;
			this.tbBirthday.Size = new System.Drawing.Size(180, 27);
			this.tbBirthday.TabIndex = 5;
			// 
			// lBirthday
			// 
			this.lBirthday.AutoSize = true;
			this.lBirthday.Location = new System.Drawing.Point(12, 192);
			this.lBirthday.Name = "lBirthday";
			this.lBirthday.Size = new System.Drawing.Size(67, 20);
			this.lBirthday.TabIndex = 4;
			this.lBirthday.Text = "Birthday:";
			// 
			// tbSecondName
			// 
			this.tbSecondName.Location = new System.Drawing.Point(12, 156);
			this.tbSecondName.Name = "tbSecondName";
			this.tbSecondName.ReadOnly = true;
			this.tbSecondName.Size = new System.Drawing.Size(180, 27);
			this.tbSecondName.TabIndex = 3;
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(12, 103);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.ReadOnly = true;
			this.tbFirstName.Size = new System.Drawing.Size(180, 27);
			this.tbFirstName.TabIndex = 2;
			// 
			// lSecondName
			// 
			this.lSecondName.AutoSize = true;
			this.lSecondName.Location = new System.Drawing.Point(12, 133);
			this.lSecondName.Name = "lSecondName";
			this.lSecondName.Size = new System.Drawing.Size(102, 20);
			this.lSecondName.TabIndex = 1;
			this.lSecondName.Text = "Second name:";
			// 
			// lFirstName
			// 
			this.lFirstName.AutoSize = true;
			this.lFirstName.Location = new System.Drawing.Point(12, 80);
			this.lFirstName.Name = "lFirstName";
			this.lFirstName.Size = new System.Drawing.Size(80, 20);
			this.lFirstName.TabIndex = 0;
			this.lFirstName.Text = "First name:";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(296, 309);
			this.Controls.Add(this.gbInfo);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "DataBase";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.gbInfo.ResumeLayout(false);
			this.gbInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miNewDB;
		private System.Windows.Forms.ToolStripMenuItem miSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbtnPrev;
		private System.Windows.Forms.ToolStripButton tsbtnNext;
		private System.Windows.Forms.ToolStripButton tsbtnAdd;
		private System.Windows.Forms.ToolStripButton tsbtnRemove;
		private System.Windows.Forms.GroupBox gbInfo;
		private System.Windows.Forms.TextBox tbBirthday;
		private System.Windows.Forms.Label lBirthday;
		private System.Windows.Forms.TextBox tbSecondName;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label lSecondName;
		private System.Windows.Forms.Label lFirstName;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miAutor;
		private System.Windows.Forms.ToolStripMenuItem miVersion;
		private System.Windows.Forms.ToolStripMenuItem miLoad;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label lId;
	}
}


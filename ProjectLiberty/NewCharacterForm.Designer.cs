namespace ProjectLiberty
{
	partial class NewCharacterForm
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
			this.cbxRace = new System.Windows.Forms.ComboBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.cbxClass = new System.Windows.Forms.ComboBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblClass = new System.Windows.Forms.Label();
			this.lblRace = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbxRace
			// 
			this.cbxRace.FormattingEnabled = true;
			this.cbxRace.Items.AddRange(new object[] {
            "Man",
            "Elf",
            "Hobbit",
            "Dwarf",
            "Beorning",
            "High Elf"});
			this.cbxRace.Location = new System.Drawing.Point(12, 68);
			this.cbxRace.Name = "cbxRace";
			this.cbxRace.Size = new System.Drawing.Size(121, 21);
			this.cbxRace.TabIndex = 0;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(198, 110);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// cbxClass
			// 
			this.cbxClass.FormattingEnabled = true;
			this.cbxClass.Items.AddRange(new object[] {
            "Champion",
            "Guardian",
            "Hunter",
            "Captain",
            "Burglar",
            "Lore Master",
            "Minstrel",
            "Warden",
            "Rune Keeper",
            "Beorning"});
			this.cbxClass.Location = new System.Drawing.Point(152, 68);
			this.cbxClass.Name = "cbxClass";
			this.cbxClass.Size = new System.Drawing.Size(121, 21);
			this.cbxClass.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(12, 25);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 9);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name";
			// 
			// lblClass
			// 
			this.lblClass.AutoSize = true;
			this.lblClass.Location = new System.Drawing.Point(149, 52);
			this.lblClass.Name = "lblClass";
			this.lblClass.Size = new System.Drawing.Size(32, 13);
			this.lblClass.TabIndex = 5;
			this.lblClass.Text = "Class";
			// 
			// lblRace
			// 
			this.lblRace.AutoSize = true;
			this.lblRace.Location = new System.Drawing.Point(14, 52);
			this.lblRace.Name = "lblRace";
			this.lblRace.Size = new System.Drawing.Size(33, 13);
			this.lblRace.TabIndex = 6;
			this.lblRace.Text = "Race";
			// 
			// NewCharacterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 142);
			this.Controls.Add(this.lblRace);
			this.Controls.Add(this.lblClass);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cbxClass);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.cbxRace);
			this.Name = "NewCharacterForm";
			this.Text = "New Character";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxRace;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ComboBox cbxClass;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblClass;
		private System.Windows.Forms.Label lblRace;
	}
}
namespace HomeAssignment03
{
	partial class frmAddContact
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
			if(disposing && (components != null))
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
			this.lblWarning = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpInformation = new System.Windows.Forms.GroupBox();
			this.grpInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Location = new System.Drawing.Point(18, -4);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 13);
			this.lblWarning.TabIndex = 9;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 22);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(220, 207);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 34);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(110, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(211, 20);
			this.txtName.TabIndex = 1;
			this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(110, 207);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 34);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
			// 
			// grpInformation
			// 
			this.grpInformation.Controls.Add(this.btnCancel);
			this.grpInformation.Controls.Add(this.txtName);
			this.grpInformation.Controls.Add(this.btnSave);
			this.grpInformation.Controls.Add(this.lblName);
			this.grpInformation.Location = new System.Drawing.Point(12, 12);
			this.grpInformation.Name = "grpInformation";
			this.grpInformation.Size = new System.Drawing.Size(328, 258);
			this.grpInformation.TabIndex = 8;
			this.grpInformation.TabStop = false;
			this.grpInformation.Text = "Information";
			// 
			// frmAddContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 723);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpInformation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAddContact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Contact";
			this.grpInformation.ResumeLayout(false);
			this.grpInformation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox grpInformation;
	}
}
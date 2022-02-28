namespace FileRename
{
	partial class NumberForm
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
			this.numFrmEditStart = new System.Windows.Forms.TextBox();
			this.numFrmCBoxDirect = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numFrmBtnOK = new System.Windows.Forms.Button();
			this.numFrmBtnCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numFrmCBoxDigit = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numFrmLblContext = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// numFrmEditStart
			// 
			this.numFrmEditStart.Location = new System.Drawing.Point(300, 47);
			this.numFrmEditStart.Name = "numFrmEditStart";
			this.numFrmEditStart.Size = new System.Drawing.Size(86, 21);
			this.numFrmEditStart.TabIndex = 14;
			// 
			// numFrmCBoxDirect
			// 
			this.numFrmCBoxDirect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.numFrmCBoxDirect.FormattingEnabled = true;
			this.numFrmCBoxDirect.Location = new System.Drawing.Point(50, 47);
			this.numFrmCBoxDirect.Name = "numFrmCBoxDirect";
			this.numFrmCBoxDirect.Size = new System.Drawing.Size(64, 20);
			this.numFrmCBoxDirect.TabIndex = 11;
			this.numFrmCBoxDirect.SelectedIndexChanged += new System.EventHandler(this.numFrmCBoxDirect_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 19;
			this.label3.Text = "위치";
			// 
			// numFrmBtnOK
			// 
			this.numFrmBtnOK.Location = new System.Drawing.Point(208, 91);
			this.numFrmBtnOK.Name = "numFrmBtnOK";
			this.numFrmBtnOK.Size = new System.Drawing.Size(86, 33);
			this.numFrmBtnOK.TabIndex = 15;
			this.numFrmBtnOK.Text = "확인";
			this.numFrmBtnOK.UseVisualStyleBackColor = true;
			this.numFrmBtnOK.Click += new System.EventHandler(this.NumFrmBtnOK_Click);
			// 
			// numFrmBtnCancel
			// 
			this.numFrmBtnCancel.Location = new System.Drawing.Point(300, 91);
			this.numFrmBtnCancel.Name = "numFrmBtnCancel";
			this.numFrmBtnCancel.Size = new System.Drawing.Size(86, 33);
			this.numFrmBtnCancel.TabIndex = 17;
			this.numFrmBtnCancel.Text = "취소";
			this.numFrmBtnCancel.UseVisualStyleBackColor = true;
			this.numFrmBtnCancel.Click += new System.EventHandler(this.NumFrmBtnCancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(241, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 12);
			this.label2.TabIndex = 18;
			this.label2.Text = "시작 숫자";
			// 
			// numFrmCBoxDigit
			// 
			this.numFrmCBoxDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.numFrmCBoxDigit.FormattingEnabled = true;
			this.numFrmCBoxDigit.Location = new System.Drawing.Point(169, 47);
			this.numFrmCBoxDigit.Name = "numFrmCBoxDigit";
			this.numFrmCBoxDigit.Size = new System.Drawing.Size(64, 20);
			this.numFrmCBoxDigit.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(126, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 16;
			this.label1.Text = "자릿수";
			// 
			// numFrmLblContext
			// 
			this.numFrmLblContext.AutoSize = true;
			this.numFrmLblContext.Location = new System.Drawing.Point(15, 22);
			this.numFrmLblContext.Name = "numFrmLblContext";
			this.numFrmLblContext.Size = new System.Drawing.Size(30, 12);
			this.numFrmLblContext.TabIndex = 13;
			this.numFrmLblContext.Text = "Test";
			// 
			// NumberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 151);
			this.Controls.Add(this.numFrmEditStart);
			this.Controls.Add(this.numFrmCBoxDirect);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numFrmBtnOK);
			this.Controls.Add(this.numFrmBtnCancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numFrmCBoxDigit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numFrmLblContext);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "NumberForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NumberForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numFrmEditStart;
		private System.Windows.Forms.ComboBox numFrmCBoxDirect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button numFrmBtnOK;
		private System.Windows.Forms.Button numFrmBtnCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox numFrmCBoxDigit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label numFrmLblContext;
	}
}
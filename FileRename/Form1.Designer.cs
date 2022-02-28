namespace FileRename
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnChangeExtension = new System.Windows.Forms.Button();
			this.btnDelExtension = new System.Windows.Forms.Button();
			this.btnRestore = new System.Windows.Forms.Button();
			this.btnClearList = new System.Windows.Forms.Button();
			this.btnNumAdd = new System.Windows.Forms.Button();
			this.btnNameClearExt = new System.Windows.Forms.Button();
			this.btnNameClear = new System.Windows.Forms.Button();
			this.btnNameAddFront = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.listView1 = new System.Windows.Forms.ListView();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.btnApply);
			this.panel1.Controls.Add(this.btnChangeExtension);
			this.panel1.Controls.Add(this.btnDelExtension);
			this.panel1.Controls.Add(this.btnRestore);
			this.panel1.Controls.Add(this.btnClearList);
			this.panel1.Controls.Add(this.btnNumAdd);
			this.panel1.Controls.Add(this.btnNameClearExt);
			this.panel1.Controls.Add(this.btnNameClear);
			this.panel1.Controls.Add(this.btnNameAddFront);
			this.panel1.Controls.Add(this.btnLoad);
			this.panel1.Location = new System.Drawing.Point(309, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(247, 277);
			this.panel1.TabIndex = 3;
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.Location = new System.Drawing.Point(15, 233);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(216, 40);
			this.btnApply.TabIndex = 23;
			this.btnApply.Text = "변경사항 적용";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// btnChangeExtension
			// 
			this.btnChangeExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChangeExtension.Location = new System.Drawing.Point(125, 187);
			this.btnChangeExtension.Name = "btnChangeExtension";
			this.btnChangeExtension.Size = new System.Drawing.Size(106, 40);
			this.btnChangeExtension.TabIndex = 21;
			this.btnChangeExtension.Text = "확장자 변경";
			this.btnChangeExtension.UseVisualStyleBackColor = true;
			this.btnChangeExtension.Click += new System.EventHandler(this.btnChangeExtension_Click);
			// 
			// btnDelExtension
			// 
			this.btnDelExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelExtension.Location = new System.Drawing.Point(15, 187);
			this.btnDelExtension.Name = "btnDelExtension";
			this.btnDelExtension.Size = new System.Drawing.Size(106, 40);
			this.btnDelExtension.TabIndex = 22;
			this.btnDelExtension.Text = "확장자 삭제";
			this.btnDelExtension.UseVisualStyleBackColor = true;
			this.btnDelExtension.Click += new System.EventHandler(this.btnDelExtension_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestore.Location = new System.Drawing.Point(125, 141);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(106, 40);
			this.btnRestore.TabIndex = 16;
			this.btnRestore.Text = "원래대로 복구";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// btnClearList
			// 
			this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearList.Location = new System.Drawing.Point(15, 49);
			this.btnClearList.Name = "btnClearList";
			this.btnClearList.Size = new System.Drawing.Size(106, 40);
			this.btnClearList.TabIndex = 15;
			this.btnClearList.Text = "목록 지우기";
			this.btnClearList.UseVisualStyleBackColor = true;
			this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
			// 
			// btnNumAdd
			// 
			this.btnNumAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNumAdd.Location = new System.Drawing.Point(15, 141);
			this.btnNumAdd.Name = "btnNumAdd";
			this.btnNumAdd.Size = new System.Drawing.Size(106, 40);
			this.btnNumAdd.TabIndex = 20;
			this.btnNumAdd.Text = "번호 붙이기";
			this.btnNumAdd.UseVisualStyleBackColor = true;
			this.btnNumAdd.Click += new System.EventHandler(this.btnNumAdd_Click);
			// 
			// btnNameClearExt
			// 
			this.btnNameClearExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNameClearExt.Location = new System.Drawing.Point(125, 95);
			this.btnNameClearExt.Name = "btnNameClearExt";
			this.btnNameClearExt.Size = new System.Drawing.Size(106, 40);
			this.btnNameClearExt.TabIndex = 19;
			this.btnNameClearExt.Text = "문자열바꾸기";
			this.btnNameClearExt.UseVisualStyleBackColor = true;
			this.btnNameClearExt.Click += new System.EventHandler(this.btnNameClearExt_Click);
			// 
			// btnNameClear
			// 
			this.btnNameClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNameClear.Location = new System.Drawing.Point(125, 50);
			this.btnNameClear.Name = "btnNameClear";
			this.btnNameClear.Size = new System.Drawing.Size(106, 40);
			this.btnNameClear.TabIndex = 18;
			this.btnNameClear.Text = "이름 지우기";
			this.btnNameClear.UseVisualStyleBackColor = true;
			this.btnNameClear.Click += new System.EventHandler(this.btnNameClear_Click);
			// 
			// btnNameAddFront
			// 
			this.btnNameAddFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNameAddFront.Location = new System.Drawing.Point(15, 95);
			this.btnNameAddFront.Name = "btnNameAddFront";
			this.btnNameAddFront.Size = new System.Drawing.Size(106, 40);
			this.btnNameAddFront.TabIndex = 17;
			this.btnNameAddFront.Text = "이름 추가";
			this.btnNameAddFront.UseVisualStyleBackColor = true;
			this.btnNameAddFront.Click += new System.EventHandler(this.btnNameAddFront_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoad.Location = new System.Drawing.Point(15, 3);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(216, 40);
			this.btnLoad.TabIndex = 14;
			this.btnLoad.Text = "불러오기";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// listView1
			// 
			this.listView1.AllowDrop = true;
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(291, 274);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
			this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 291);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "화이트네이머";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnChangeExtension;
		private System.Windows.Forms.Button btnDelExtension;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Button btnClearList;
		private System.Windows.Forms.Button btnNumAdd;
		private System.Windows.Forms.Button btnNameClearExt;
		private System.Windows.Forms.Button btnNameClear;
		private System.Windows.Forms.Button btnNameAddFront;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ListView listView1;
	}
}


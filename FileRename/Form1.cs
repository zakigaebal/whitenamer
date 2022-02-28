using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileRename
{
	public partial class Form1 : Form
	{
		private List<Form1> mFileList = new List<Form1>();
		public string mStrDlgReturn = string.Empty;

		public string FileFullPath { get; set; }
		public string BackupFileFullPath { get; set; }
		public string FilePath { get; set; }
		public string BackupFilePath { get; set; }
		public string FileName { get; set; }
		public string BackupFileName { get; set; }
		public string BackupFileExtension { get; set; }
		public string FileExtension { get; set; }
	

		public Form1()
		{
			InitializeComponent();
			initialiizeControl();
		}

		private void initialiizeControl()
		{
			// 리스트 초기화
			{
				listView1.Columns.Add("현재이름", 100);
				listView1.Columns.Add("바꿀이름", 250);
			}
			//버튼초기화
			{
				btnClearList.Enabled = false;
				btnRestore.Enabled = false;
				btnNameAddFront.Enabled = false;
				btnNameClear.Enabled = false;
				btnNameClearExt.Enabled = false;
				btnNumAdd.Enabled = false;
				btnChangeExtension.Enabled = false;
				btnDelExtension.Enabled = false;
				btnApply.Enabled = false;
			}

		}
		public enum ListColumn
		{
			CurName,
			ReName,
			FilePath,
			FullPath,
			Max
		}

		public enum ListSize
		{
			CurName = 250,
			ReName = 250,
		}

		public enum FormType
		{
			AddName,          //이름추가
			ChangeExtension   //확장자변경
		}
		private void RefreshList(bool bIsBackupFullPathClear = false) 
		{
			listView1.Items.Clear();
			// 리스트뷰 아이템 초기화

			listView1.BeginUpdate();
			// 리스트뷰 비긴업데이트 메소드 시작
			foreach(Form1 file in mFileList)
			{
				string[] arrStr = new string[(int)ListColumn.Max];
				arrStr[(int)ListColumn.CurName] = file.BackupFileName + "." + file.BackupFileExtension;
				if (!string.IsNullOrEmpty(file.FileExtension))
					arrStr[(int)ListColumn.ReName] = file.FileName + "." + file.FileExtension;
				else
					arrStr[(int)ListColumn.ReName] = file.FileName;
				arrStr[(int)ListColumn.FilePath] = file.FilePath;
				file.FileFullPath = file.FilePath + file.FileName + "." + file.FileExtension;
				if (bIsBackupFullPathClear)
					file.BackupFileFullPath = file.FileFullPath;
				arrStr[(int)ListColumn.FullPath] = file.FileFullPath;


				ListViewItem listViewItem = new ListViewItem(arrStr);

				listView1.Items.Add(listViewItem);
			}
			listView1.EndUpdate();
		}
	
		private void btnLoad_Click(object sender, EventArgs e)
		{
			openFileDialog.Multiselect = true;
			DialogResult dialogResult = openFileDialog.ShowDialog();

			if (dialogResult == DialogResult.OK)
			{
				AddList(openFileDialog.FileNames);
			}
		}

		/// <summary>
		/// 메인 ListView에 파일 목록을 추가하는 함수
		/// </summary>
		/// <param name="strFileNames"></param>


		private void AddList(string[] strFileNames)
		{
		
			if (strFileNames.Length <= 0)
			{
				return;
			}
			bool blsContinue = false;

			foreach (string str in strFileNames)
			{

				Form1 fileObject = new Form1();
				fileObject.SetFile(str);

				foreach (Form1 file in mFileList)
		
				{

					if (fileObject.FileFullPath.CompareTo(file.FileFullPath) == 0)
					{
						blsContinue = true;
						break;
					}
				}
			
				if (!blsContinue) 
					mFileList.Add(fileObject);
				else 
					blsContinue = false;

			}
			RefreshList();
			if (mFileList.Count > 0)
			{
				btnClearList.Enabled = true;
				btnRestore.Enabled = true;
				btnNameAddFront.Enabled = true;
				btnNameClear.Enabled = true;
				btnNameClearExt.Enabled = true;
				btnNumAdd.Enabled = true;
				btnChangeExtension.Enabled = true;
				btnDelExtension.Enabled = true;
				btnApply.Enabled = true;
			}
		}


		private void SetFile(string strPath)
		{
			try
			{
				FileFullPath = strPath;
				BackupFileFullPath = strPath;

				int nLastSeparator = strPath.LastIndexOf(Path.DirectorySeparatorChar);
				FilePath = strPath.Substring(0, nLastSeparator + 1);
				BackupFilePath = FilePath;

				int nExtensionSeparator = strPath.LastIndexOf(".");
				FileName = strPath.Substring(nLastSeparator + 1, nExtensionSeparator - nLastSeparator - 1);
				BackupFileName = FileName;
				FileExtension = strPath.Substring(nExtensionSeparator + 1);
				BackupFileExtension = FileExtension;

				FileInfo fileInfo = new FileInfo(strPath);
			}
			catch (Exception ex)
			{
				
			}
		}
		
		private void btnNameClear_Click(object sender, EventArgs e)
		{
			foreach(Form1 file in mFileList)
				file.FileName = String.Empty;

			RefreshList();
		}

		private void btnClearList_Click(object sender, EventArgs e)
		{
			mFileList.Clear();
			listView1.Items.Clear();

			btnClearList.Enabled = false;
			btnRestore.Enabled = false;
			btnNameAddFront.Enabled = false;
			btnNameClear.Enabled = false;
			btnNameClearExt.Enabled = false;
			btnNumAdd.Enabled = false;
			btnChangeExtension.Enabled = false;
			btnDelExtension.Enabled = false;
			btnApply.Enabled = false;
		}

		private void btnNameAddFront_Click(object sender, EventArgs e)
		{
			using (NameForm nameForm = new NameForm())
			{
				nameForm.SetFormType(FormType.AddName);
				nameForm.Owner = this;
				DialogResult result = nameForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					if (!string.IsNullOrEmpty(mStrDlgReturn))
					{
						// mStrDlgReturn 데이터 스플릿
						// [0] = 문자열을 넣을 위치
						// [1] = 넣을 문자열
						string[] strToken = mStrDlgReturn.Split(',');

						if (strToken.Length == 2)
						{
							if (strToken[0].CompareTo("0") == 0)    // 앞에 추가
							{
								foreach (Form1 file in mFileList)
									file.FileName = strToken[1] + file.FileName;
							}
							else                                    // 뒤에 추가
							{
								foreach (Form1 file in mFileList)
									file.FileName = file.FileName + strToken[1];
							}
						}

						RefreshList();
					}
					mStrDlgReturn = string.Empty;
				}
			}
		}

		private void btnNameClearExt_Click(object sender, EventArgs e)
		{
			using (NameForm2 nameForm = new NameForm2())
			{
				nameForm.Owner = this;

				DialogResult result = nameForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					if (!string.IsNullOrEmpty(mStrDlgReturn))
					{
						// mStrDlgReturn 데이터 스플릿
						// [0] = 대상 문자열
						// [1] = 변경 문자열
						string[] strToken = mStrDlgReturn.Split(',');

						if (strToken.Length == 2)
						{
							foreach (Form1 file in mFileList)
							{
								file.FileName = file.FileName.Replace(strToken[0], strToken[1]);
							}
						}

						RefreshList();
					}
					mStrDlgReturn = string.Empty;
				}
			}
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			foreach (Form1 file in mFileList)
			{
				if (File.Exists(file.BackupFileFullPath))
				{
					File.Move(file.BackupFileFullPath, file.FileFullPath);
					file.BackupFileName = file.FileName;
					file.BackupFileExtension = file.FileExtension;
					file.BackupFilePath = file.FilePath;
				}
				else
				{
					file.BackupFileName = "원본파일이 존재하지 않음";
					file.BackupFileExtension = "";
				}
			}
			RefreshList(true);
		}

		private void btnNumAdd_Click(object sender, EventArgs e)
		{
			using (NumberForm numForm = new NumberForm())
			{
				numForm.Owner = this;
				DialogResult result = numForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					if (!string.IsNullOrEmpty(mStrDlgReturn))
					{
						// mStrDlgReturn 데이터 스플릿
						// [0] = 숫자를 붙이는 방향 (0 : 앞, 1 : 뒤)
						// [1] = 자릿수
						// [2] = 시작수
						string[] strToken = mStrDlgReturn.Split(',');

						if (strToken.Length == 3)
						{
							string strTmp = string.Empty;
							int nDirect = int.Parse(strToken[0]);
							int nDigit = int.Parse(strToken[1]);
							int nStart = int.Parse(strToken[2]);
							string strFormat = string.Format("D{0}", nDigit);
							strFormat = "{0,0:" + strFormat + "}";


							foreach (Form1 file in mFileList)
							{
								if (nDirect == 0)
									file.FileName = string.Format(strFormat, nStart++) + file.FileName;
								else
									file.FileName += string.Format(strFormat, nStart++);
							}
						}

						RefreshList();
					}
					mStrDlgReturn = string.Empty;
				}
			}
		}

		private void btnRestore_Click(object sender, EventArgs e)
		{
			foreach (Form1 file in mFileList)
			{
				file.FileName = file.BackupFileName;
				file.FilePath = file.BackupFilePath;
				file.FileFullPath = file.BackupFileFullPath;
				file.FileExtension = file.BackupFileExtension;
			}
			RefreshList();
		}

		private void btnDelExtension_Click(object sender, EventArgs e)
		{
			foreach (Form1 file in mFileList)
				file.FileExtension = string.Empty;

			RefreshList();
		}

		private void btnChangeExtension_Click(object sender, EventArgs e)
		{
			using (NameForm nameForm = new NameForm())
			{
				nameForm.SetFormType(FormType.ChangeExtension);
				nameForm.Owner = this;
				DialogResult result = nameForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					if (!string.IsNullOrEmpty(mStrDlgReturn))
					{
						foreach (Form1 file in mFileList)
							file.FileExtension = mStrDlgReturn;

						RefreshList();
					}
					mStrDlgReturn = string.Empty;
				}
			}
		}

		private void listView1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] strFileNames = e.Data.GetData(DataFormats.FileDrop) as string[];
				AddList(strFileNames);
			}
		}
		// DragDrop은 리스트 컨트롤에 마우스를 드래그해서 놓았을때 발생하는 함수


		private void listView1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}
		//DragEnter는 마우스로 리스트컨트롤 안으로 들어왔을 때 발생하는 함수
	}
}

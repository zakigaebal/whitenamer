using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileRename
{
  public partial class NameForm : Form
  {
    private Form1.FormType mFormType;

    public NameForm()
    {
      InitializeComponent();

      InitControl();
    }

    private void InitControl()
    {
      string[] STR_DIRECT = new string[2] { "앞", "뒤" };
      nameFrmCBoxDirect.Items.AddRange(STR_DIRECT);
      nameFrmCBoxDirect.SelectedIndex = 0;
    }

    /// <summary>
    /// 폼 생성 타입을 설정
    /// </summary>
    /// <param name="formType">폼 타입</param>
    public void SetFormType(Form1.FormType formType)
    {
      mFormType = formType;

      switch (mFormType)
      {
        case Form1.FormType.AddName:
          Text = "이름추가";
          nameFrmLblContext.Text = "파일에 이름을 추가합니다";
          nameFrmLblPos.Visible = true;
          nameFrmCBoxDirect.Visible = true;
          break;
        case Form1.FormType.ChangeExtension:
          Text = "파일 확장자 변경";
          nameFrmLblContext.Text = "파일의 확장자를 변경합니다";
          nameFrmLblPos.Visible = false;
          nameFrmCBoxDirect.Visible = false;
          break;
      }
    }

    /// <summary>
    /// 확인 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NameFrmBtnOK_Click(object sender, EventArgs e)
    {
      switch (mFormType)
      {
        case Form1.FormType.AddName:
          ((Form1)(Owner)).mStrDlgReturn = string.Format("{0},{1}", nameFrmCBoxDirect.SelectedIndex, nameFrmEdit.Text);
          break;
        case Form1.FormType.ChangeExtension:
          ((Form1)(Owner)).mStrDlgReturn = string.Format("{0}", nameFrmEdit.Text);
          break;
      }
      this.DialogResult = DialogResult.OK;
      Close();
    }

    /// <summary>
    /// 취소 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NameFrmBtnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}

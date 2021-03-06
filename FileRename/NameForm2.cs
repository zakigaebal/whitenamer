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
  public partial class NameForm2 : Form
  {
    public NameForm2()
    {
      InitializeComponent();

      InitControls();
    }
    private void InitControls()
    {
      // 타이틀
      {
        Text = "문자열 바꾸기";
      }

      // 라벨 초기화
      {
        nameFrm2LblContext1.Text = "대상문자열";
        nameFrm2LblContext2.Text = "바꿀문자열";
      }
    }

    /// <summary>
    /// 확인 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NameFrm2BtnOK_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(nameFrm2Edit1.Text))
      {
        string strReturn = string.Format("{0},{1}", nameFrm2Edit1.Text, nameFrm2Edit2.Text);

        ((Form1)(Owner)).mStrDlgReturn = strReturn;
        this.DialogResult = DialogResult.OK;
      }
    }

    /// <summary>
    /// 취소 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NameFrmBtn2Cancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}

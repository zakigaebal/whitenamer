using System;
using System.Windows.Forms;


namespace FileRename
{
  public partial class NumberForm : Form
  {
    public NumberForm()
    {
      InitializeComponent();

      InitControls();
    }

    private void InitControls()
    {
      string[] STR_DIRECT = new string[2] { "앞", "뒤" };
      numFrmCBoxDirect.Items.AddRange(STR_DIRECT);
      numFrmCBoxDirect.SelectedIndex = 0;

      for (int i = 1; i <= 10; i++)
        numFrmCBoxDigit.Items.Add(string.Format("{0}", i));
      numFrmCBoxDigit.SelectedIndex = 0;

      Text = "번호 붙이기";
      numFrmLblContext.Text = string.Format("파일 {0}에 번호를 붙입니다.", STR_DIRECT[0]);
    }

    /// <summary>
    /// 확인 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NumFrmBtnOK_Click(object sender, EventArgs e)
    {
      string strReturn = string.Format("{0},{1},{2}", numFrmCBoxDirect.SelectedIndex, numFrmCBoxDigit.SelectedIndex + 1, numFrmEditStart.Text);

      ((Form1)(Owner)).mStrDlgReturn = strReturn;
      this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// 취소 버튼
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NumFrmBtnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    /// <summary>
    /// 위치 콤보박스 - 선택 이벤트
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void numFrmCBoxDirect_SelectedIndexChanged(object sender, EventArgs e)
    {
      numFrmLblContext.Text = string.Format("파일 {0}에 번호를 붙입니다.", numFrmCBoxDirect.Text);
    }
  }
}

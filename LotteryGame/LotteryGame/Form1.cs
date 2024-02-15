using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LotteryGame
{
    public partial class frmMain : Form
    {
        List<Button> listButton = new List<Button>();
        List<int> listSelectNum = new List<int>();
        List<int> listRandNum = new List<int>();
        List<int> listResult = new List<int>();
        int currentMyComboBoxIndex = 0;
        List<int> tempNum = new List<int>();
        
        private System.Timers.Timer timerTick = new System.Timers.Timer();
        private System.Timers.Timer timerGameResult = new System.Timers.Timer();
        List<Label> listLabel = new List<Label>();
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnCreate(10, 8);

            InitializeGamePlayStateComboBox();
            InitializeLabelList();

            timerTick = new System.Timers.Timer();
            timerTick.Elapsed += timerTick_Elapsed;

            timerGameResult = new System.Timers.Timer(5000);
            timerGameResult.Elapsed += timerGameResult_Elapsed;
            
            timerTick.Start();
            timerGameResult.Start();

            btnSend.Enabled = false;
            btnClear.Enabled = false;
        }

        private void InitializeGamePlayStateComboBox()
        {
            cboGamePlayState.Items.AddRange(new string[]
            { 
                "十星", "九星", "八星", "七星", "六星", "五星", "四星", "三星", "二星", "一星"
            });
        }

        private void InitializeLabelList()
        {
            listLabel.AddRange(new Label[] 
            { 
                lblNumOne, lblNumTwo, lblNumThree, lblNumFour, lblNumFive, lblNumSix, lblNumSeven, lblNumEight, lblNumNine, lblNumTen 
            });
        }

        void btnCreate(int intColumn, int intRow)
        {
            int bNum = 0;

            for(int i = 0; i < intRow; i++)
            {
                for(int j = 0; j < intColumn; j++)
                {
                    bNum++;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Orange;
                    dButton.ForeColor = Color.DarkRed;
                    dButton.Font = new Font("微軟正黑體", 18);
                    dButton.Text = bNum.ToString();
                    dButton.Location = new Point(20 + 62 * j, 60 + 42 * i);
                    dButton.Size = new Size(60, 40);
                    dButton.Click += dButton_Click;
                    Controls.Add(dButton);
                    listButton.Add(dButton);
                }
            }
        }

        void dButton_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            int intNum = Convert.ToInt32(myBtn.Text);

            if(cboGamePlayState.Text == string.Empty)
            {
                MessageBox.Show("請選擇玩法");
            }

            if (myBtn.BackColor == Color.Orange && cboGamePlayState.Text != string.Empty)
            {
                int maxCount = 10 - currentMyComboBoxIndex;
                if (listSelectNum.Count < maxCount)
                {
                    myBtn.BackColor = Color.LightGoldenrodYellow;
                    listSelectNum.Add(intNum);
                }
                else
                {
                    MessageBox.Show("超出玩法規定號碼數");
                }
            }
            else
            {
                myBtn.BackColor = Color.Orange;
                listSelectNum.Remove(intNum);
            }
        }

        private void SetButtonsEnabledState(bool enabled)
        {
            foreach (Button button in listButton)
            {
                button.Enabled = enabled;
            }
        }

        private void SetButtonEnabledState(Button button, bool enabled)
        {
            button.Enabled = enabled;
        }

        // 快選
        private void btnQuickNum_Click(object sender, EventArgs e)
        {
            if(cboGamePlayState.SelectedItem == null)
            {
                MessageBox.Show("請選擇玩法");
            }
            else
            {
                //for (int i = 0; i < listButton.Count; i++)
                //{
                //    listButton[i].Enabled = false;
                //}
                SetButtonsEnabledState(false);
                SetButtonEnabledState(btnNumConfirm, false);
                SetButtonEnabledState(btnClear, true);
                SetButtonEnabledState(btnSend, true);
                ClearNum();
                QuickNum();
            }
        }

        // 自選
        private void btnNumConfirm_Click(object sender, EventArgs e)
        {
            if (cboGamePlayState.SelectedItem == null)
            {
                MessageBox.Show("請選擇玩法");
            }
            else if (listSelectNum.Count < 1)
            {
                MessageBox.Show("請選擇號碼");
            }
            else
            {
                SetButtonEnabledState(btnQuickNum, false);
                SetButtonEnabledState(btnSend, true);
                SetButtonEnabledState(btnClear, true);
                listBoxNum.Items.Clear();
                NumComfirm();
            }
        }

        // 清除
        private void btnClear_Click(object sender, EventArgs e)
        {
            if(listBoxNum.Items.Count > 0)
            {
                //for (int i = 0; i < listButton.Count; i++)
                //{
                //    listButton[i].Enabled = true;
                //}
                SetButtonsEnabledState(true);
                SetButtonEnabledState(btnNumConfirm, true);
                SetButtonEnabledState(btnQuickNum, true);
                SetButtonEnabledState(btnSend, false);
                ClearNum();
            }
            else
            {
                MessageBox.Show("號碼已清除");
            }
        }

        void QuickNum()
        {
            Random randNum = new Random();
            StringBuilder strMsgBuilder = new StringBuilder();
            tempNum.Clear();

            int maxCount = 10 - currentMyComboBoxIndex;
            listRandNum = Enumerable.Range(0, 81)
                .OrderBy(x => randNum.Next())
                .Take(maxCount)
                .ToList();
            listRandNum.Sort();
            foreach (int Num in listRandNum)
            {
                listButton[Num].BackColor = Color.LightGoldenrodYellow;
                strMsgBuilder.Append((Num + 1) + ", ");
                tempNum.Add(Num + 1);
                Console.WriteLine(strMsgBuilder.Length);
            }
            if (strMsgBuilder.Length > 0)
            {
                strMsgBuilder.Length -= 2;  // 移除最後的逗號和空格
                string strMsg = strMsgBuilder.ToString();
                Console.WriteLine(strMsg);
                listBoxNum.Items.Add(strMsg);
            }
        }

        void NumComfirm()
        {
            tempNum.Clear();
            string strMsg = string.Empty;

            listSelectNum.Sort();
            int count = listSelectNum.Count;
            int gameRoleNum = 10 - currentMyComboBoxIndex;

            if(gameRoleNum == count)
            {
                strMsg = string.Join(", ", listSelectNum);
                
                tempNum.AddRange(listSelectNum);
                listBoxNum.Items.Add(strMsg);
                SetButtonEnabledState(btnSend, true);
            }
            else
            {
                MessageBox.Show("請選擇正確數量的號碼", "數量錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetButtonEnabledState(btnSend, false);
            }
        }

        private void SetButtonsColor(Color backgroundColor)
        {
            foreach (Button button in listButton)
            {
                button.BackColor = backgroundColor;
            }
        }

        void ClearNum()
        {
            SetButtonsColor(Color.Orange);

            listBoxNum.Items.Clear();
            listRandNum.Clear();
            listSelectNum.Clear();
        }

        private void cboGamePlayState_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMyComboBoxIndex = cboGamePlayState.FindStringExact(cboGamePlayState.Text);
            ClearNum();
            Console.WriteLine(currentMyComboBoxIndex);
            //current = (string)cboGamePlayState.SelectedItem;
            //Console.WriteLine(current);
        }

        void timerTick_Elapsed(object sender, ElapsedEventArgs e)
        {
            timerTick.Stop();

            try
            {
                setText_Label(lblTIme, string.Format(DateTime.Now.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                timerTick.Start();
            }
        }

        void timerGameResult_Elapsed(object sender, ElapsedEventArgs e)
        {
            timerGameResult.Stop();

            try
            {
                Random randNum = new Random();
                string strResult = string.Empty;
                
                listResult = Enumerable.Range(1, 80).OrderBy(x => randNum.Next()).Take(10).ToList();
                for (int i = 0; i < listResult.Count; i++)
                {
                    setText_Label(listLabel[i], string.Format(listResult[i].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                timerGameResult.Start();
            }
        }

        private void setText_Label(Label _lbl, string txt)
        {
            Action setText = () =>
            {
                _lbl.Text = string.Format(txt);
            };

            if (_lbl.InvokeRequired)
            {
                _lbl.Invoke(setText);
            }
            else
            {
                setText();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();

            string strNum = string.Empty;
            string strLabel = string.Empty;
            int LabelCount = listLabel.Count;
            int NumCount = tempNum.Count;
            int commonCount = 0;

            tempNum.Sort();
            // 排序
            listLabel.Sort((label1, label2) => int.Parse(label1.Text).CompareTo(int.Parse(label2.Text)));

            if (cboGamePlayState.SelectedIndex != -1 && listBoxNum.Items.Count != 0)
            {
                foreach (var number in tempNum)
                {
                    foreach (var label in listLabel)
                    {
                        if (int.TryParse(label.Text, out int labelText) && labelText == number)
                        {
                            commonCount++;
                            break; // 找到相同的數字後跳出內層迴圈，進入下一個數字的比較
                        }
                    }
                }

                messageBuilder.AppendLine("開獎號碼: " + string.Join(", ", listLabel.Select(label => label.Text)));
                messageBuilder.AppendLine("選擇號碼: " + string.Join(", ", tempNum));
                messageBuilder.AppendLine("相同的數字有: " + commonCount);

                MessageBox.Show(messageBuilder.ToString());
            }
        }
    }
}

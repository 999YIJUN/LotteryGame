namespace LotteryGame
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNumConfirm = new System.Windows.Forms.Button();
            this.listBoxNum = new System.Windows.Forms.ListBox();
            this.btnQuickNum = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboGamePlayState = new System.Windows.Forms.ComboBox();
            this.lblNumOne = new System.Windows.Forms.Label();
            this.lblNumTwo = new System.Windows.Forms.Label();
            this.lblNumThree = new System.Windows.Forms.Label();
            this.lblNumFour = new System.Windows.Forms.Label();
            this.lblNumFive = new System.Windows.Forms.Label();
            this.lblNumSix = new System.Windows.Forms.Label();
            this.lblNumSeven = new System.Windows.Forms.Label();
            this.lblNumEight = new System.Windows.Forms.Label();
            this.lblNumNine = new System.Windows.Forms.Label();
            this.lblNumTen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTIme = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNumConfirm
            // 
            this.btnNumConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumConfirm.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNumConfirm.Location = new System.Drawing.Point(0, 0);
            this.btnNumConfirm.Name = "btnNumConfirm";
            this.btnNumConfirm.Size = new System.Drawing.Size(150, 73);
            this.btnNumConfirm.TabIndex = 0;
            this.btnNumConfirm.Text = "自選號碼";
            this.btnNumConfirm.UseVisualStyleBackColor = true;
            this.btnNumConfirm.Click += new System.EventHandler(this.btnNumConfirm_Click);
            // 
            // listBoxNum
            // 
            this.listBoxNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNum.FormattingEnabled = true;
            this.listBoxNum.ItemHeight = 31;
            this.listBoxNum.Location = new System.Drawing.Point(0, 0);
            this.listBoxNum.Name = "listBoxNum";
            this.listBoxNum.Size = new System.Drawing.Size(488, 73);
            this.listBoxNum.TabIndex = 1;
            // 
            // btnQuickNum
            // 
            this.btnQuickNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuickNum.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuickNum.Location = new System.Drawing.Point(0, 0);
            this.btnQuickNum.Name = "btnQuickNum";
            this.btnQuickNum.Size = new System.Drawing.Size(150, 73);
            this.btnQuickNum.TabIndex = 0;
            this.btnQuickNum.Text = "快選號碼";
            this.btnQuickNum.UseVisualStyleBackColor = true;
            this.btnQuickNum.Click += new System.EventHandler(this.btnQuickNum_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 73);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除號碼";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboGamePlayState
            // 
            this.cboGamePlayState.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboGamePlayState.FormattingEnabled = true;
            this.cboGamePlayState.Location = new System.Drawing.Point(9, 38);
            this.cboGamePlayState.Name = "cboGamePlayState";
            this.cboGamePlayState.Size = new System.Drawing.Size(185, 35);
            this.cboGamePlayState.TabIndex = 2;
            this.cboGamePlayState.SelectedIndexChanged += new System.EventHandler(this.cboGamePlayState_SelectedIndexChanged);
            // 
            // lblNumOne
            // 
            this.lblNumOne.AutoSize = true;
            this.lblNumOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOne.Location = new System.Drawing.Point(25, 60);
            this.lblNumOne.Name = "lblNumOne";
            this.lblNumOne.Size = new System.Drawing.Size(49, 36);
            this.lblNumOne.TabIndex = 3;
            this.lblNumOne.Text = "00";
            // 
            // lblNumTwo
            // 
            this.lblNumTwo.AutoSize = true;
            this.lblNumTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTwo.Location = new System.Drawing.Point(100, 60);
            this.lblNumTwo.Name = "lblNumTwo";
            this.lblNumTwo.Size = new System.Drawing.Size(49, 36);
            this.lblNumTwo.TabIndex = 3;
            this.lblNumTwo.Text = "00";
            // 
            // lblNumThree
            // 
            this.lblNumThree.AutoSize = true;
            this.lblNumThree.Location = new System.Drawing.Point(175, 60);
            this.lblNumThree.Name = "lblNumThree";
            this.lblNumThree.Size = new System.Drawing.Size(49, 36);
            this.lblNumThree.TabIndex = 3;
            this.lblNumThree.Text = "00";
            // 
            // lblNumFour
            // 
            this.lblNumFour.AutoSize = true;
            this.lblNumFour.Location = new System.Drawing.Point(250, 60);
            this.lblNumFour.Name = "lblNumFour";
            this.lblNumFour.Size = new System.Drawing.Size(49, 36);
            this.lblNumFour.TabIndex = 3;
            this.lblNumFour.Text = "00";
            // 
            // lblNumFive
            // 
            this.lblNumFive.AutoSize = true;
            this.lblNumFive.Location = new System.Drawing.Point(325, 60);
            this.lblNumFive.Name = "lblNumFive";
            this.lblNumFive.Size = new System.Drawing.Size(49, 36);
            this.lblNumFive.TabIndex = 3;
            this.lblNumFive.Text = "00";
            // 
            // lblNumSix
            // 
            this.lblNumSix.AutoSize = true;
            this.lblNumSix.Location = new System.Drawing.Point(25, 130);
            this.lblNumSix.Name = "lblNumSix";
            this.lblNumSix.Size = new System.Drawing.Size(49, 36);
            this.lblNumSix.TabIndex = 3;
            this.lblNumSix.Text = "00";
            // 
            // lblNumSeven
            // 
            this.lblNumSeven.AutoSize = true;
            this.lblNumSeven.Location = new System.Drawing.Point(100, 130);
            this.lblNumSeven.Name = "lblNumSeven";
            this.lblNumSeven.Size = new System.Drawing.Size(49, 36);
            this.lblNumSeven.TabIndex = 3;
            this.lblNumSeven.Text = "00";
            // 
            // lblNumEight
            // 
            this.lblNumEight.AutoSize = true;
            this.lblNumEight.Location = new System.Drawing.Point(175, 130);
            this.lblNumEight.Name = "lblNumEight";
            this.lblNumEight.Size = new System.Drawing.Size(49, 36);
            this.lblNumEight.TabIndex = 3;
            this.lblNumEight.Text = "00";
            // 
            // lblNumNine
            // 
            this.lblNumNine.AutoSize = true;
            this.lblNumNine.Location = new System.Drawing.Point(250, 130);
            this.lblNumNine.Name = "lblNumNine";
            this.lblNumNine.Size = new System.Drawing.Size(49, 36);
            this.lblNumNine.TabIndex = 3;
            this.lblNumNine.Text = "00";
            // 
            // lblNumTen
            // 
            this.lblNumTen.AutoSize = true;
            this.lblNumTen.Location = new System.Drawing.Point(325, 130);
            this.lblNumTen.Name = "lblNumTen";
            this.lblNumTen.Size = new System.Drawing.Size(49, 36);
            this.lblNumTen.TabIndex = 3;
            this.lblNumTen.Text = "00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumOne);
            this.groupBox2.Controls.Add(this.lblNumTwo);
            this.groupBox2.Controls.Add(this.lblNumTen);
            this.groupBox2.Controls.Add(this.lblNumThree);
            this.groupBox2.Controls.Add(this.lblNumNine);
            this.groupBox2.Controls.Add(this.lblNumFour);
            this.groupBox2.Controls.Add(this.lblNumEight);
            this.groupBox2.Controls.Add(this.lblNumFive);
            this.groupBox2.Controls.Add(this.lblNumSeven);
            this.groupBox2.Controls.Add(this.lblNumSix);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(873, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 194);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 73);
            this.panel2.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(488, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(797, 73);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cboGamePlayState);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 73);
            this.panel8.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "玩法選擇:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnQuickNum);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(197, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 73);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNumConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(347, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 73);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSend);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(497, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 73);
            this.panel6.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 73);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "送出號碼";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(647, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 73);
            this.panel5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 73);
            this.panel1.TabIndex = 4;
            // 
            // lblTIme
            // 
            this.lblTIme.AutoSize = true;
            this.lblTIme.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTIme.Location = new System.Drawing.Point(20, 24);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(74, 28);
            this.lblTIme.TabIndex = 4;
            this.lblTIme.Text = "Time:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 609);
            this.Controls.Add(this.lblTIme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1303, 656);
            this.MinimumSize = new System.Drawing.Size(1303, 656);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumConfirm;
        private System.Windows.Forms.ListBox listBoxNum;
        private System.Windows.Forms.Button btnQuickNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboGamePlayState;
        private System.Windows.Forms.Label lblNumOne;
        private System.Windows.Forms.Label lblNumTwo;
        private System.Windows.Forms.Label lblNumThree;
        private System.Windows.Forms.Label lblNumFour;
        private System.Windows.Forms.Label lblNumFive;
        private System.Windows.Forms.Label lblNumSix;
        private System.Windows.Forms.Label lblNumSeven;
        private System.Windows.Forms.Label lblNumEight;
        private System.Windows.Forms.Label lblNumNine;
        private System.Windows.Forms.Label lblNumTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTIme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
    }
}


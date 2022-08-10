namespace prjWinCSATMReview
{
    partial class frmATM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnNextNumber = new System.Windows.Forms.Button();
            this.lblGreating = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnNextPin = new System.Windows.Forms.Button();
            this.btnNextAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnNextTrans = new System.Windows.Forms.Button();
            this.radConsult = new System.Windows.Forms.RadioButton();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROYALE BANK-ATM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(157, 98);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(170, 26);
            this.txtNumber.TabIndex = 0;
            // 
            // btnNextNumber
            // 
            this.btnNextNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextNumber.Location = new System.Drawing.Point(252, 128);
            this.btnNextNumber.Name = "btnNextNumber";
            this.btnNextNumber.Size = new System.Drawing.Size(75, 33);
            this.btnNextNumber.TabIndex = 1;
            this.btnNextNumber.Text = "&Next >>";
            this.btnNextNumber.UseVisualStyleBackColor = true;
            this.btnNextNumber.Click += new System.EventHandler(this.btnNextNumber_Click);
            // 
            // lblGreating
            // 
            this.lblGreating.AutoSize = true;
            this.lblGreating.BackColor = System.Drawing.SystemColors.Control;
            this.lblGreating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreating.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGreating.Location = new System.Drawing.Point(46, 171);
            this.lblGreating.Name = "lblGreating";
            this.lblGreating.Size = new System.Drawing.Size(2, 22);
            this.lblGreating.TabIndex = 4;
            this.lblGreating.Click += new System.EventHandler(this.lblGreating_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client Pin:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(160, 205);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(168, 26);
            this.txtPin.TabIndex = 6;
            // 
            // btnNextPin
            // 
            this.btnNextPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPin.Location = new System.Drawing.Point(255, 235);
            this.btnNextPin.Name = "btnNextPin";
            this.btnNextPin.Size = new System.Drawing.Size(75, 31);
            this.btnNextPin.TabIndex = 7;
            this.btnNextPin.Text = "&Next >>";
            this.btnNextPin.UseVisualStyleBackColor = true;
            this.btnNextPin.Click += new System.EventHandler(this.btnNextPin_Click);
            // 
            // btnNextAccount
            // 
            this.btnNextAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAccount.Location = new System.Drawing.Point(253, 325);
            this.btnNextAccount.Name = "btnNextAccount";
            this.btnNextAccount.Size = new System.Drawing.Size(75, 31);
            this.btnNextAccount.TabIndex = 10;
            this.btnNextAccount.Text = "&Next >>";
            this.btnNextAccount.UseVisualStyleBackColor = true;
            this.btnNextAccount.Click += new System.EventHandler(this.btnNextAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Account:";
            // 
            // cboAccount
            // 
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(158, 292);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(170, 28);
            this.cboAccount.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWithdraw);
            this.groupBox1.Controls.Add(this.txtDeposit);
            this.groupBox1.Controls.Add(this.btnNextTrans);
            this.groupBox1.Controls.Add(this.radConsult);
            this.groupBox1.Controls.Add(this.radWithdraw);
            this.groupBox1.Controls.Add(this.radDeposit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 158);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "$";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(136, 74);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(167, 26);
            this.txtWithdraw.TabIndex = 14;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(136, 34);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(167, 26);
            this.txtDeposit.TabIndex = 13;
            this.txtDeposit.TextChanged += new System.EventHandler(this.txtDeposit_TextChanged);
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // btnNextTrans
            // 
            this.btnNextTrans.Location = new System.Drawing.Point(228, 111);
            this.btnNextTrans.Name = "btnNextTrans";
            this.btnNextTrans.Size = new System.Drawing.Size(75, 27);
            this.btnNextTrans.TabIndex = 13;
            this.btnNextTrans.Text = "&Next >>";
            this.btnNextTrans.UseVisualStyleBackColor = true;
            this.btnNextTrans.Click += new System.EventHandler(this.btnNextTrans_Click);
            // 
            // radConsult
            // 
            this.radConsult.AutoSize = true;
            this.radConsult.Checked = true;
            this.radConsult.Location = new System.Drawing.Point(21, 114);
            this.radConsult.Name = "radConsult";
            this.radConsult.Size = new System.Drawing.Size(94, 24);
            this.radConsult.TabIndex = 2;
            this.radConsult.TabStop = true;
            this.radConsult.Text = "Consult";
            this.radConsult.UseVisualStyleBackColor = true;
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(21, 76);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(108, 24);
            this.radWithdraw.TabIndex = 1;
            this.radWithdraw.Text = "Withdraw";
            this.radWithdraw.UseVisualStyleBackColor = true;
            this.radWithdraw.CheckedChanged += new System.EventHandler(this.radWithdraw_CheckedChanged);
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.Location = new System.Drawing.Point(21, 33);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(95, 24);
            this.radDeposit.TabIndex = 0;
            this.radDeposit.Text = "Deposit";
            this.radDeposit.UseVisualStyleBackColor = true;
            this.radDeposit.CheckedChanged += new System.EventHandler(this.radDeposit_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 587);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 158);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Location = new System.Drawing.Point(21, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(2, 22);
            this.lblInfo.TabIndex = 0;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminate.Location = new System.Drawing.Point(93, 767);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(156, 32);
            this.btnTerminate.TabIndex = 13;
            this.btnTerminate.Text = "&TERMINATE";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 828);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.cboAccount);
            this.Controls.Add(this.btnNextAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNextPin);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGreating);
            this.Controls.Add(this.btnNextNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmATM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmATM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnNextNumber;
        private System.Windows.Forms.Label lblGreating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnNextPin;
        private System.Windows.Forms.Button btnNextAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnNextTrans;
        private System.Windows.Forms.RadioButton radConsult;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}


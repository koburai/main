namespace Alyssa_Waddell_CPT_185_A80H_Test_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.ttYear = new System.Windows.Forms.ToolTip(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lblSalTotal = new System.Windows.Forms.Label();
            this.lblRecNum = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.lblBonusAmt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProc
            // 
            this.btnProc.AutoSize = true;
            this.btnProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnProc.Location = new System.Drawing.Point(16, 39);
            this.btnProc.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(157, 30);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "&Process the file ->";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnExit.Location = new System.Drawing.Point(16, 102);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnClear.Location = new System.Drawing.Point(114, 102);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(249, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Year:";
            // 
            // cboxYear
            // 
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Location = new System.Drawing.Point(301, 71);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(121, 28);
            this.cboxYear.TabIndex = 5;
            this.ttYear.SetToolTip(this.cboxYear, "Select a year to pull from.");
            // 
            // lblSalTotal
            // 
            this.lblSalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalTotal.Location = new System.Drawing.Point(172, 180);
            this.lblSalTotal.Name = "lblSalTotal";
            this.lblSalTotal.Size = new System.Drawing.Size(329, 27);
            this.lblSalTotal.TabIndex = 6;
            // 
            // lblRecNum
            // 
            this.lblRecNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecNum.Location = new System.Drawing.Point(172, 217);
            this.lblRecNum.Name = "lblRecNum";
            this.lblRecNum.Size = new System.Drawing.Size(329, 27);
            this.lblRecNum.TabIndex = 7;
            // 
            // lblAvg
            // 
            this.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvg.Location = new System.Drawing.Point(172, 256);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(329, 27);
            this.lblAvg.TabIndex = 8;
            // 
            // lblLargest
            // 
            this.lblLargest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargest.Location = new System.Drawing.Point(172, 295);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(329, 27);
            this.lblLargest.TabIndex = 9;
            // 
            // lblSmallest
            // 
            this.lblSmallest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallest.Location = new System.Drawing.Point(172, 334);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(329, 27);
            this.lblSmallest.TabIndex = 10;
            // 
            // lblBonusAmt
            // 
            this.lblBonusAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBonusAmt.Location = new System.Drawing.Point(172, 375);
            this.lblBonusAmt.Name = "lblBonusAmt";
            this.lblBonusAmt.Size = new System.Drawing.Size(329, 27);
            this.lblBonusAmt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnProc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(536, 418);
            this.Controls.Add(this.lblBonusAmt);
            this.Controls.Add(this.lblSmallest);
            this.Controls.Add(this.lblLargest);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblRecNum);
            this.Controls.Add(this.lblSalTotal);
            this.Controls.Add(this.cboxYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alyssa Waddell CPT 185 Test 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxYear;
        private System.Windows.Forms.ToolTip ttYear;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lblSalTotal;
        private System.Windows.Forms.Label lblRecNum;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label lblSmallest;
        private System.Windows.Forms.Label lblBonusAmt;
    }
}


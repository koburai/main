namespace Alyssa_Waddell_CPT185_A80H_Final
{
    partial class Egg_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egg_Select));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxRed = new System.Windows.Forms.PictureBox();
            this.pboxBlue = new System.Windows.Forms.PictureBox();
            this.pboxGreen = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.lblTitle.Location = new System.Drawing.Point(177, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 51);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Select Your Egg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick a name and then click on any of the below eggs to get started!";
            // 
            // pboxRed
            // 
            this.pboxRed.Image = ((System.Drawing.Image)(resources.GetObject("pboxRed.Image")));
            this.pboxRed.Location = new System.Drawing.Point(93, 164);
            this.pboxRed.Name = "pboxRed";
            this.pboxRed.Size = new System.Drawing.Size(218, 183);
            this.pboxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxRed.TabIndex = 5;
            this.pboxRed.TabStop = false;
            this.pboxRed.Click += new System.EventHandler(this.pboxRed_Click);
            // 
            // pboxBlue
            // 
            this.pboxBlue.Image = ((System.Drawing.Image)(resources.GetObject("pboxBlue.Image")));
            this.pboxBlue.Location = new System.Drawing.Point(389, 164);
            this.pboxBlue.Name = "pboxBlue";
            this.pboxBlue.Size = new System.Drawing.Size(218, 183);
            this.pboxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBlue.TabIndex = 6;
            this.pboxBlue.TabStop = false;
            this.pboxBlue.Click += new System.EventHandler(this.pboxBlue_Click);
            // 
            // pboxGreen
            // 
            this.pboxGreen.Image = ((System.Drawing.Image)(resources.GetObject("pboxGreen.Image")));
            this.pboxGreen.Location = new System.Drawing.Point(675, 164);
            this.pboxGreen.Name = "pboxGreen";
            this.pboxGreen.Size = new System.Drawing.Size(218, 183);
            this.pboxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxGreen.TabIndex = 7;
            this.pboxGreen.TabStop = false;
            this.pboxGreen.Click += new System.EventHandler(this.pboxGreen_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(665, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(755, 99);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(138, 26);
            this.txtbName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Afterwards, be sure to load your tempdata.txt file!";
            // 
            // Egg_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1001, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pboxGreen);
            this.Controls.Add(this.pboxBlue);
            this.Controls.Add(this.pboxRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Egg_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egg_Select";
            ((System.ComponentModel.ISupportInitialize)(this.pboxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxRed;
        private System.Windows.Forms.PictureBox pboxBlue;
        private System.Windows.Forms.PictureBox pboxGreen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label2;
    }
}
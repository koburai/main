namespace Alyssa_Waddell_CPT185_A80H_Final
{
    partial class How_To_Play
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
            this.btnCreatureSel = new System.Windows.Forms.Button();
            this.btnCreatureHealth = new System.Windows.Forms.Button();
            this.btnSaveLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ttBack = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCreatureSel
            // 
            this.btnCreatureSel.AutoSize = true;
            this.btnCreatureSel.Location = new System.Drawing.Point(73, 101);
            this.btnCreatureSel.Name = "btnCreatureSel";
            this.btnCreatureSel.Size = new System.Drawing.Size(136, 30);
            this.btnCreatureSel.TabIndex = 0;
            this.btnCreatureSel.Text = "Creature Select";
            this.btnCreatureSel.UseVisualStyleBackColor = true;
            this.btnCreatureSel.Click += new System.EventHandler(this.btnCreatureSel_Click);
            // 
            // btnCreatureHealth
            // 
            this.btnCreatureHealth.AutoSize = true;
            this.btnCreatureHealth.Location = new System.Drawing.Point(73, 163);
            this.btnCreatureHealth.Name = "btnCreatureHealth";
            this.btnCreatureHealth.Size = new System.Drawing.Size(138, 30);
            this.btnCreatureHealth.TabIndex = 1;
            this.btnCreatureHealth.Text = "Creature Health";
            this.btnCreatureHealth.UseVisualStyleBackColor = true;
            this.btnCreatureHealth.Click += new System.EventHandler(this.btnCreatureHealth_Click);
            // 
            // btnSaveLoad
            // 
            this.btnSaveLoad.AutoSize = true;
            this.btnSaveLoad.Location = new System.Drawing.Point(73, 225);
            this.btnSaveLoad.Name = "btnSaveLoad";
            this.btnSaveLoad.Size = new System.Drawing.Size(165, 30);
            this.btnSaveLoad.TabIndex = 2;
            this.btnSaveLoad.Text = "Saving and Loading";
            this.btnSaveLoad.UseVisualStyleBackColor = true;
            this.btnSaveLoad.Click += new System.EventHandler(this.btnSaveLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(73, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Back To Title";
            this.ttBack.SetToolTip(this.btnClose, "Return to title screen");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txtDesc.Location = new System.Drawing.Point(385, 101);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(382, 212);
            this.txtDesc.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.lblTitle.Location = new System.Drawing.Point(281, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 51);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "How To Play";
            // 
            // How_To_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(852, 363);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveLoad);
            this.Controls.Add(this.btnCreatureHealth);
            this.Controls.Add(this.btnCreatureSel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "How_To_Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How_To_Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatureSel;
        private System.Windows.Forms.Button btnCreatureHealth;
        private System.Windows.Forms.Button btnSaveLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip ttBack;
    }
}
namespace HangMan_Project
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
            this.HangMangb = new System.Windows.Forms.GroupBox();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.Wordgb = new System.Windows.Forms.GroupBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.Guessgb = new System.Windows.Forms.GroupBox();
            this.Wordtb = new System.Windows.Forms.TextBox();
            this.Lettertb = new System.Windows.Forms.TextBox();
            this.SubmitWordbtn = new System.Windows.Forms.Button();
            this.SubmitLetterbtn = new System.Windows.Forms.Button();
            this.MissedLabel = new System.Windows.Forms.Label();
            this.HangMangb.SuspendLayout();
            this.Wordgb.SuspendLayout();
            this.Guessgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // HangMangb
            // 
            this.HangMangb.Controls.Add(this.DrawPanel);
            this.HangMangb.Location = new System.Drawing.Point(440, 6);
            this.HangMangb.Name = "HangMangb";
            this.HangMangb.Size = new System.Drawing.Size(256, 439);
            this.HangMangb.TabIndex = 0;
            this.HangMangb.TabStop = false;
            this.HangMangb.Text = "HangMan";
            // 
            // DrawPanel
            // 
            this.DrawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanel.Location = new System.Drawing.Point(3, 16);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(250, 420);
            this.DrawPanel.TabIndex = 0;
            // 
            // Wordgb
            // 
            this.Wordgb.Controls.Add(this.MissedLabel);
            this.Wordgb.Controls.Add(this.LengthLabel);
            this.Wordgb.Location = new System.Drawing.Point(12, 6);
            this.Wordgb.Name = "Wordgb";
            this.Wordgb.Size = new System.Drawing.Size(422, 210);
            this.Wordgb.TabIndex = 1;
            this.Wordgb.TabStop = false;
            this.Wordgb.Text = "Word";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(6, 171);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(75, 13);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Word Length :";
            // 
            // Guessgb
            // 
            this.Guessgb.Controls.Add(this.Wordtb);
            this.Guessgb.Controls.Add(this.Lettertb);
            this.Guessgb.Controls.Add(this.SubmitWordbtn);
            this.Guessgb.Controls.Add(this.SubmitLetterbtn);
            this.Guessgb.Location = new System.Drawing.Point(12, 228);
            this.Guessgb.Name = "Guessgb";
            this.Guessgb.Size = new System.Drawing.Size(422, 210);
            this.Guessgb.TabIndex = 2;
            this.Guessgb.TabStop = false;
            this.Guessgb.Text = "Gussing";
            // 
            // Wordtb
            // 
            this.Wordtb.Location = new System.Drawing.Point(100, 108);
            this.Wordtb.Name = "Wordtb";
            this.Wordtb.Size = new System.Drawing.Size(192, 20);
            this.Wordtb.TabIndex = 3;
            this.Wordtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wordtb_KeyDown);
            // 
            // Lettertb
            // 
            this.Lettertb.Location = new System.Drawing.Point(179, 28);
            this.Lettertb.MaxLength = 1;
            this.Lettertb.Name = "Lettertb";
            this.Lettertb.Size = new System.Drawing.Size(35, 20);
            this.Lettertb.TabIndex = 2;
            this.Lettertb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lettertb_KeyDown);
            // 
            // SubmitWordbtn
            // 
            this.SubmitWordbtn.Location = new System.Drawing.Point(99, 134);
            this.SubmitWordbtn.Name = "SubmitWordbtn";
            this.SubmitWordbtn.Size = new System.Drawing.Size(194, 23);
            this.SubmitWordbtn.TabIndex = 1;
            this.SubmitWordbtn.Text = "Submit Word";
            this.SubmitWordbtn.UseVisualStyleBackColor = true;
            this.SubmitWordbtn.Click += new System.EventHandler(this.SubmitWordbtn_Click);
            // 
            // SubmitLetterbtn
            // 
            this.SubmitLetterbtn.Location = new System.Drawing.Point(99, 54);
            this.SubmitLetterbtn.Name = "SubmitLetterbtn";
            this.SubmitLetterbtn.Size = new System.Drawing.Size(194, 23);
            this.SubmitLetterbtn.TabIndex = 0;
            this.SubmitLetterbtn.Text = "Submit Letter";
            this.SubmitLetterbtn.UseVisualStyleBackColor = true;
            this.SubmitLetterbtn.Click += new System.EventHandler(this.SubmitLetterbtn_Click);
            // 
            // MissedLabel
            // 
            this.MissedLabel.AutoSize = true;
            this.MissedLabel.Location = new System.Drawing.Point(6, 194);
            this.MissedLabel.Name = "MissedLabel";
            this.MissedLabel.Size = new System.Drawing.Size(46, 13);
            this.MissedLabel.TabIndex = 5;
            this.MissedLabel.Text = "Missed :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.Guessgb);
            this.Controls.Add(this.Wordgb);
            this.Controls.Add(this.HangMangb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HangMan";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.HangMangb.ResumeLayout(false);
            this.Wordgb.ResumeLayout(false);
            this.Wordgb.PerformLayout();
            this.Guessgb.ResumeLayout(false);
            this.Guessgb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HangMangb;
        private System.Windows.Forms.GroupBox Wordgb;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.GroupBox Guessgb;
        private System.Windows.Forms.Button SubmitWordbtn;
        private System.Windows.Forms.Button SubmitLetterbtn;
        private System.Windows.Forms.TextBox Wordtb;
        private System.Windows.Forms.TextBox Lettertb;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label MissedLabel;
    }
}


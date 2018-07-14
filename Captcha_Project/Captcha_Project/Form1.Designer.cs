namespace Captcha_Project
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
            this.Selectbtn = new System.Windows.Forms.Button();
            this.Generatebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountNum = new System.Windows.Forms.NumericUpDown();
            this.Captchagb = new System.Windows.Forms.GroupBox();
            this.CaptchaPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Openbtn = new System.Windows.Forms.Button();
            this.Texttb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
            this.Captchagb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Selectbtn
            // 
            this.Selectbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Selectbtn.Location = new System.Drawing.Point(3, 12);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(172, 23);
            this.Selectbtn.TabIndex = 0;
            this.Selectbtn.Text = "Select Folder";
            this.Selectbtn.UseVisualStyleBackColor = true;
            this.Selectbtn.Click += new System.EventHandler(this.Selectbtn_Click);
            // 
            // Generatebtn
            // 
            this.Generatebtn.Location = new System.Drawing.Point(3, 109);
            this.Generatebtn.Name = "Generatebtn";
            this.Generatebtn.Size = new System.Drawing.Size(172, 33);
            this.Generatebtn.TabIndex = 1;
            this.Generatebtn.Text = "Generate";
            this.Generatebtn.UseVisualStyleBackColor = true;
            this.Generatebtn.Click += new System.EventHandler(this.Generatebtn_Click);
            this.Generatebtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Generatebtn_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount :";
            // 
            // AmountNum
            // 
            this.AmountNum.Location = new System.Drawing.Point(65, 71);
            this.AmountNum.Name = "AmountNum";
            this.AmountNum.Size = new System.Drawing.Size(110, 20);
            this.AmountNum.TabIndex = 5;
            // 
            // Captchagb
            // 
            this.Captchagb.Controls.Add(this.CaptchaPanel);
            this.Captchagb.Location = new System.Drawing.Point(182, 13);
            this.Captchagb.Name = "Captchagb";
            this.Captchagb.Size = new System.Drawing.Size(263, 150);
            this.Captchagb.TabIndex = 6;
            this.Captchagb.TabStop = false;
            this.Captchagb.Text = "Captcha";
            // 
            // CaptchaPanel
            // 
            this.CaptchaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaptchaPanel.Location = new System.Drawing.Point(3, 16);
            this.CaptchaPanel.Name = "CaptchaPanel";
            this.CaptchaPanel.Size = new System.Drawing.Size(257, 131);
            this.CaptchaPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(182, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 131);
            this.panel1.TabIndex = 0;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(3, 267);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(172, 33);
            this.Submitbtn.TabIndex = 8;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Openbtn
            // 
            this.Openbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Openbtn.Location = new System.Drawing.Point(3, 210);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(172, 23);
            this.Openbtn.TabIndex = 7;
            this.Openbtn.Text = "Open";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // Texttb
            // 
            this.Texttb.Location = new System.Drawing.Point(12, 241);
            this.Texttb.Name = "Texttb";
            this.Texttb.Size = new System.Drawing.Size(155, 20);
            this.Texttb.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 344);
            this.Controls.Add(this.Texttb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Openbtn);
            this.Controls.Add(this.Captchagb);
            this.Controls.Add(this.AmountNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Generatebtn);
            this.Controls.Add(this.Selectbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Captcha Generator";
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
            this.Captchagb.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Button Generatebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AmountNum;
        private System.Windows.Forms.GroupBox Captchagb;
        private System.Windows.Forms.Panel CaptchaPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Button Openbtn;
        private System.Windows.Forms.TextBox Texttb;
    }
}


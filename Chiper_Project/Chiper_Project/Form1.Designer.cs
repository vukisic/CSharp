namespace Chiper_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HashInputtb = new System.Windows.Forms.TextBox();
            this.HashOutputtb = new System.Windows.Forms.TextBox();
            this.Hashbtn = new System.Windows.Forms.Button();
            this.MD5cb = new System.Windows.Forms.CheckBox();
            this.SHA1cb = new System.Windows.Forms.CheckBox();
            this.Inputtb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HashGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DOuttb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DKeytb = new System.Windows.Forms.TextBox();
            this.Decbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EOuttb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ETexttb = new System.Windows.Forms.TextBox();
            this.EKeytb = new System.Windows.Forms.TextBox();
            this.Encbtn = new System.Windows.Forms.Button();
            this.HashGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HashInputtb
            // 
            this.HashInputtb.Location = new System.Drawing.Point(203, 36);
            this.HashInputtb.Multiline = true;
            this.HashInputtb.Name = "HashInputtb";
            this.HashInputtb.Size = new System.Drawing.Size(545, 34);
            this.HashInputtb.TabIndex = 3;
            // 
            // HashOutputtb
            // 
            this.HashOutputtb.Location = new System.Drawing.Point(203, 79);
            this.HashOutputtb.Multiline = true;
            this.HashOutputtb.Name = "HashOutputtb";
            this.HashOutputtb.Size = new System.Drawing.Size(545, 34);
            this.HashOutputtb.TabIndex = 4;
            // 
            // Hashbtn
            // 
            this.Hashbtn.FlatAppearance.BorderSize = 0;
            this.Hashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hashbtn.Image = ((System.Drawing.Image)(resources.GetObject("Hashbtn.Image")));
            this.Hashbtn.Location = new System.Drawing.Point(6, 86);
            this.Hashbtn.Name = "Hashbtn";
            this.Hashbtn.Size = new System.Drawing.Size(75, 44);
            this.Hashbtn.TabIndex = 0;
            this.Hashbtn.UseVisualStyleBackColor = true;
            this.Hashbtn.Click += new System.EventHandler(this.Hashbtn_Click);
            // 
            // MD5cb
            // 
            this.MD5cb.AutoSize = true;
            this.MD5cb.Location = new System.Drawing.Point(6, 39);
            this.MD5cb.Name = "MD5cb";
            this.MD5cb.Size = new System.Drawing.Size(61, 24);
            this.MD5cb.TabIndex = 1;
            this.MD5cb.Text = "MD5";
            this.MD5cb.UseVisualStyleBackColor = true;
            // 
            // SHA1cb
            // 
            this.SHA1cb.AutoSize = true;
            this.SHA1cb.Location = new System.Drawing.Point(6, 63);
            this.SHA1cb.Name = "SHA1cb";
            this.SHA1cb.Size = new System.Drawing.Size(66, 24);
            this.SHA1cb.TabIndex = 2;
            this.SHA1cb.Text = "SHA1";
            this.SHA1cb.UseVisualStyleBackColor = true;
            // 
            // Inputtb
            // 
            this.Inputtb.AutoSize = true;
            this.Inputtb.Location = new System.Drawing.Point(129, 39);
            this.Inputtb.Name = "Inputtb";
            this.Inputtb.Size = new System.Drawing.Size(54, 20);
            this.Inputtb.TabIndex = 5;
            this.Inputtb.Text = "Input :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output :";
            // 
            // HashGroup
            // 
            this.HashGroup.BackColor = System.Drawing.Color.White;
            this.HashGroup.Controls.Add(this.MD5cb);
            this.HashGroup.Controls.Add(this.label2);
            this.HashGroup.Controls.Add(this.Hashbtn);
            this.HashGroup.Controls.Add(this.Inputtb);
            this.HashGroup.Controls.Add(this.SHA1cb);
            this.HashGroup.Controls.Add(this.HashOutputtb);
            this.HashGroup.Controls.Add(this.HashInputtb);
            this.HashGroup.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashGroup.Location = new System.Drawing.Point(12, 12);
            this.HashGroup.Name = "HashGroup";
            this.HashGroup.Size = new System.Drawing.Size(766, 136);
            this.HashGroup.TabIndex = 7;
            this.HashGroup.TabStop = false;
            this.HashGroup.Text = "Hash";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DOuttb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DKeytb);
            this.groupBox1.Controls.Add(this.Decbtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EOuttb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ETexttb);
            this.groupBox1.Controls.Add(this.EKeytb);
            this.groupBox1.Controls.Add(this.Encbtn);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 268);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cryptography";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dec :";
            // 
            // DOuttb
            // 
            this.DOuttb.Location = new System.Drawing.Point(460, 154);
            this.DOuttb.Multiline = true;
            this.DOuttb.Name = "DOuttb";
            this.DOuttb.Size = new System.Drawing.Size(302, 105);
            this.DOuttb.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Key :";
            // 
            // DKeytb
            // 
            this.DKeytb.Location = new System.Drawing.Point(460, 28);
            this.DKeytb.Multiline = true;
            this.DKeytb.Name = "DKeytb";
            this.DKeytb.Size = new System.Drawing.Size(302, 34);
            this.DKeytb.TabIndex = 14;
            // 
            // Decbtn
            // 
            this.Decbtn.FlatAppearance.BorderSize = 0;
            this.Decbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decbtn.Image = ((System.Drawing.Image)(resources.GetObject("Decbtn.Image")));
            this.Decbtn.Location = new System.Drawing.Point(687, 111);
            this.Decbtn.Name = "Decbtn";
            this.Decbtn.Size = new System.Drawing.Size(75, 37);
            this.Decbtn.TabIndex = 13;
            this.Decbtn.UseVisualStyleBackColor = true;
            this.Decbtn.Click += new System.EventHandler(this.Decbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enc :";
            // 
            // EOuttb
            // 
            this.EOuttb.Location = new System.Drawing.Point(58, 157);
            this.EOuttb.Multiline = true;
            this.EOuttb.Name = "EOuttb";
            this.EOuttb.Size = new System.Drawing.Size(302, 105);
            this.EOuttb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key :";
            // 
            // ETexttb
            // 
            this.ETexttb.Location = new System.Drawing.Point(58, 74);
            this.ETexttb.Multiline = true;
            this.ETexttb.Name = "ETexttb";
            this.ETexttb.Size = new System.Drawing.Size(302, 34);
            this.ETexttb.TabIndex = 8;
            // 
            // EKeytb
            // 
            this.EKeytb.Location = new System.Drawing.Point(58, 28);
            this.EKeytb.Multiline = true;
            this.EKeytb.Name = "EKeytb";
            this.EKeytb.Size = new System.Drawing.Size(302, 34);
            this.EKeytb.TabIndex = 7;
            // 
            // Encbtn
            // 
            this.Encbtn.FlatAppearance.BorderSize = 0;
            this.Encbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encbtn.Image = ((System.Drawing.Image)(resources.GetObject("Encbtn.Image")));
            this.Encbtn.Location = new System.Drawing.Point(285, 114);
            this.Encbtn.Name = "Encbtn";
            this.Encbtn.Size = new System.Drawing.Size(75, 37);
            this.Encbtn.TabIndex = 1;
            this.Encbtn.UseVisualStyleBackColor = true;
            this.Encbtn.Click += new System.EventHandler(this.Encbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HashGroup);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simple Chiper";
            this.HashGroup.ResumeLayout(false);
            this.HashGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HashInputtb;
        private System.Windows.Forms.TextBox HashOutputtb;
        private System.Windows.Forms.Button Hashbtn;
        private System.Windows.Forms.CheckBox MD5cb;
        private System.Windows.Forms.CheckBox SHA1cb;
        private System.Windows.Forms.Label Inputtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox HashGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DOuttb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DKeytb;
        private System.Windows.Forms.Button Decbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EOuttb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ETexttb;
        private System.Windows.Forms.TextBox EKeytb;
        private System.Windows.Forms.Button Encbtn;
    }
}


namespace ClientGUI
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDAddTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.JSONBtn = new System.Windows.Forms.Button();
            this.IDRemoveTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FileNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewAll = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.IDAddTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LastNameTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FirstNameTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddPerson";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IDRemoveTb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RemoveBtn);
            this.groupBox2.Location = new System.Drawing.Point(199, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RemovePerson";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewAll);
            this.groupBox3.Controls.Add(this.ShowBtn);
            this.groupBox3.Location = new System.Drawing.Point(385, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 323);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.FileNameTb);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.JSONBtn);
            this.groupBox4.Location = new System.Drawing.Point(571, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 323);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "JSON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(74, 19);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTb.TabIndex = 1;
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(74, 45);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(100, 20);
            this.LastNameTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // IDAddTb
            // 
            this.IDAddTb.Location = new System.Drawing.Point(74, 71);
            this.IDAddTb.Name = "IDAddTb";
            this.IDAddTb.Size = new System.Drawing.Size(100, 20);
            this.IDAddTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID :";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(99, 294);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(99, 294);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(99, 294);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 8;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // JSONBtn
            // 
            this.JSONBtn.Location = new System.Drawing.Point(97, 294);
            this.JSONBtn.Name = "JSONBtn";
            this.JSONBtn.Size = new System.Drawing.Size(75, 23);
            this.JSONBtn.TabIndex = 9;
            this.JSONBtn.Text = "JSON";
            this.JSONBtn.UseVisualStyleBackColor = true;
            this.JSONBtn.Click += new System.EventHandler(this.JSONBtn_Click);
            // 
            // IDRemoveTb
            // 
            this.IDRemoveTb.Location = new System.Drawing.Point(74, 22);
            this.IDRemoveTb.Name = "IDRemoveTb";
            this.IDRemoveTb.Size = new System.Drawing.Size(100, 20);
            this.IDRemoveTb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID of Person:";
            // 
            // FileNameTb
            // 
            this.FileNameTb.Location = new System.Drawing.Point(72, 15);
            this.FileNameTb.Name = "FileNameTb";
            this.FileNameTb.Size = new System.Drawing.Size(100, 20);
            this.FileNameTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "File Name :";
            // 
            // listViewAll
            // 
            this.listViewAll.FullRowSelect = true;
            this.listViewAll.GridLines = true;
            this.listViewAll.Location = new System.Drawing.Point(6, 22);
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(168, 266);
            this.listViewAll.TabIndex = 9;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(35, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Example : name.json";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 348);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox IDAddTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IDRemoveTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewAll;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox FileNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button JSONBtn;
        private System.Windows.Forms.Label label6;
    }
}
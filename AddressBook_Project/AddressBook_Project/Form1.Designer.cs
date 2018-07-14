namespace AddressBook_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PeopleListView = new System.Windows.Forms.ListView();
            this.groupbox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.Addresstb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Emailtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Birthdaydp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Notesttb = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupbox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PeopleListView);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People";
            // 
            // PeopleListView
            // 
            this.PeopleListView.ContextMenuStrip = this.contextMenuStrip1;
            this.PeopleListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeopleListView.Location = new System.Drawing.Point(3, 16);
            this.PeopleListView.Name = "PeopleListView";
            this.PeopleListView.Size = new System.Drawing.Size(194, 297);
            this.PeopleListView.TabIndex = 0;
            this.PeopleListView.UseCompatibleStateImageBehavior = false;
            this.PeopleListView.SelectedIndexChanged += new System.EventHandler(this.PeopleListView_SelectedIndexChanged);
            // 
            // groupbox3
            // 
            this.groupbox3.Controls.Add(this.RemoveBtn);
            this.groupbox3.Controls.Add(this.AddBtn);
            this.groupbox3.Controls.Add(this.SaveBtn);
            this.groupbox3.Controls.Add(this.Notesttb);
            this.groupbox3.Controls.Add(this.label5);
            this.groupbox3.Controls.Add(this.Birthdaydp);
            this.groupbox3.Controls.Add(this.label4);
            this.groupbox3.Controls.Add(this.Emailtb);
            this.groupbox3.Controls.Add(this.label3);
            this.groupbox3.Controls.Add(this.Addresstb);
            this.groupbox3.Controls.Add(this.label2);
            this.groupbox3.Controls.Add(this.Nametb);
            this.groupbox3.Controls.Add(this.label1);
            this.groupbox3.Location = new System.Drawing.Point(219, 12);
            this.groupbox3.Name = "groupbox3";
            this.groupbox3.Size = new System.Drawing.Size(361, 315);
            this.groupbox3.TabIndex = 2;
            this.groupbox3.TabStop = false;
            this.groupbox3.Text = "Person Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(72, 24);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(260, 20);
            this.Nametb.TabIndex = 1;
            // 
            // Addresstb
            // 
            this.Addresstb.Location = new System.Drawing.Point(72, 62);
            this.Addresstb.Name = "Addresstb";
            this.Addresstb.Size = new System.Drawing.Size(260, 20);
            this.Addresstb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address :";
            // 
            // Emailtb
            // 
            this.Emailtb.Location = new System.Drawing.Point(88, 100);
            this.Emailtb.Name = "Emailtb";
            this.Emailtb.Size = new System.Drawing.Size(244, 20);
            this.Emailtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday :";
            // 
            // Birthdaydp
            // 
            this.Birthdaydp.Location = new System.Drawing.Point(72, 138);
            this.Birthdaydp.Name = "Birthdaydp";
            this.Birthdaydp.Size = new System.Drawing.Size(260, 20);
            this.Birthdaydp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notes :";
            // 
            // Notesttb
            // 
            this.Notesttb.Location = new System.Drawing.Point(9, 197);
            this.Notesttb.Multiline = true;
            this.Notesttb.Name = "Notesttb";
            this.Notesttb.Size = new System.Drawing.Size(323, 64);
            this.Notesttb.TabIndex = 9;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(6, 282);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 23);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save Changes";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(122, 282);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 23);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add Contact";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(238, 282);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(110, 23);
            this.RemoveBtn.TabIndex = 12;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 335);
            this.Controls.Add(this.groupbox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Address Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupbox3.ResumeLayout(false);
            this.groupbox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView PeopleListView;
        private System.Windows.Forms.GroupBox groupbox3;
        private System.Windows.Forms.DateTimePicker Birthdaydp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Emailtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Addresstb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Notesttb;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}


namespace EmailSender_Project
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxText = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailTextBox.Location = new System.Drawing.Point(3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(560, 29);
            this.EmailTextBox.TabIndex = 0;
            this.EmailTextBox.Text = "someone@example.com";
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Font = new System.Drawing.Font("Ubuntu", 14.25F);
            this.SubjectTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SubjectTextBox.Location = new System.Drawing.Point(3, 37);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(560, 29);
            this.SubjectTextBox.TabIndex = 1;
            this.SubjectTextBox.Text = "Subject";
            this.SubjectTextBox.Click += new System.EventHandler(this.SubjectTextBox_Click);
            // 
            // TextBoxText
            // 
            this.TextBoxText.Font = new System.Drawing.Font("Ubuntu", 14.25F);
            this.TextBoxText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextBoxText.Location = new System.Drawing.Point(3, 73);
            this.TextBoxText.Multiline = true;
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.Size = new System.Drawing.Size(560, 194);
            this.TextBoxText.TabIndex = 3;
            this.TextBoxText.Text = "Text...";
            this.TextBoxText.Click += new System.EventHandler(this.TextBoxText_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.SendBtn.FlatAppearance.BorderSize = 0;
            this.SendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Font = new System.Drawing.Font("Ubuntu Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SendBtn.Location = new System.Drawing.Point(3, 265);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(560, 33);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(565, 299);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.TextBoxText);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Mail Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.TextBox TextBoxText;
        private System.Windows.Forms.Button SendBtn;
    }
}
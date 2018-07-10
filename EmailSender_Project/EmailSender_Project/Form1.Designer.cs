namespace EmailSender_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "LogIn";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Ubuntu", 20.25F);
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EmailTextBox.Location = new System.Drawing.Point(12, 72);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(215, 39);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.Text = "e-mail";
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 127);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(215, 39);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "password";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogInBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogInBtn.FlatAppearance.BorderSize = 0;
            this.LogInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Ubuntu Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogInBtn.Location = new System.Drawing.Point(14, 182);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(211, 41);
            this.LogInBtn.TabIndex = 3;
            this.LogInBtn.Text = "LogIn";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(243, 245);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LogInBtn;
    }
}


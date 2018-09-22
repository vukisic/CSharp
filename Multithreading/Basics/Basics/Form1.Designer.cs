namespace Basics
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
            this.TimeButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TimeButton
            // 
            this.TimeButton.Location = new System.Drawing.Point(29, 13);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(319, 23);
            this.TimeButton.TabIndex = 0;
            this.TimeButton.Text = "Time Consuming Operation";
            this.TimeButton.UseVisualStyleBackColor = true;
            this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(29, 42);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(319, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Print Numbers";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(29, 84);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(319, 173);
            this.listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 268);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.TimeButton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Basics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ListBox listBox;
    }
}


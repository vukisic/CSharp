namespace AsyncAndAwait
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
            this.ButtonNormal = new System.Windows.Forms.Button();
            this.ButtonAsync = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ButtonParallel = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ButtonNormal
            // 
            this.ButtonNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonNormal.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNormal.Location = new System.Drawing.Point(4, 6);
            this.ButtonNormal.Name = "ButtonNormal";
            this.ButtonNormal.Size = new System.Drawing.Size(217, 50);
            this.ButtonNormal.TabIndex = 0;
            this.ButtonNormal.Text = "Normal Execution";
            this.ButtonNormal.UseVisualStyleBackColor = true;
            this.ButtonNormal.Click += new System.EventHandler(this.ButtonNormal_Click);
            // 
            // ButtonAsync
            // 
            this.ButtonAsync.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonAsync.Location = new System.Drawing.Point(233, 62);
            this.ButtonAsync.Name = "ButtonAsync";
            this.ButtonAsync.Size = new System.Drawing.Size(216, 50);
            this.ButtonAsync.TabIndex = 1;
            this.ButtonAsync.Text = "Async Execution";
            this.ButtonAsync.UseVisualStyleBackColor = true;
            this.ButtonAsync.Click += new System.EventHandler(this.ButtonAsync_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 176);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(437, 253);
            this.TextBox.TabIndex = 2;
            // 
            // ButtonParallel
            // 
            this.ButtonParallel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonParallel.Location = new System.Drawing.Point(233, 6);
            this.ButtonParallel.Name = "ButtonParallel";
            this.ButtonParallel.Size = new System.Drawing.Size(217, 50);
            this.ButtonParallel.TabIndex = 3;
            this.ButtonParallel.Text = "Parallel Async Execution";
            this.ButtonParallel.UseVisualStyleBackColor = true;
            this.ButtonParallel.Click += new System.EventHandler(this.ButtonParallel_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.Brown;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.SystemColors.Info;
            this.ButtonCancel.Location = new System.Drawing.Point(4, 62);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(217, 50);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel Operation";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 132);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(437, 23);
            this.ProgressBar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 442);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonParallel);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ButtonAsync);
            this.Controls.Add(this.ButtonNormal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AsyncAndAwait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonNormal;
        private System.Windows.Forms.Button ButtonAsync;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button ButtonParallel;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}


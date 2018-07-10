namespace MP3Player_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.SeekSlider = new System.Windows.Forms.TrackBar();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseBtn = new System.Windows.Forms.Button();
            this.FullLabel = new System.Windows.Forms.Label();
            this.CurrLabel = new System.Windows.Forms.Label();
            this.NowLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.VolumeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SeekSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.Transparent;
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.OpenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenBtn.Image")));
            this.OpenBtn.Location = new System.Drawing.Point(12, 30);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(32, 32);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.BackColor = System.Drawing.Color.Transparent;
            this.LeftBtn.FlatAppearance.BorderSize = 0;
            this.LeftBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.LeftBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.LeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftBtn.Image = ((System.Drawing.Image)(resources.GetObject("LeftBtn.Image")));
            this.LeftBtn.Location = new System.Drawing.Point(120, 30);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(32, 32);
            this.LeftBtn.TabIndex = 3;
            this.LeftBtn.UseVisualStyleBackColor = false;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayBtn.Image")));
            this.PlayBtn.Location = new System.Drawing.Point(162, 30);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(32, 32);
            this.PlayBtn.TabIndex = 4;
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.BackColor = System.Drawing.Color.Transparent;
            this.RightBtn.FlatAppearance.BorderSize = 0;
            this.RightBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.RightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.RightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightBtn.Image = ((System.Drawing.Image)(resources.GetObject("RightBtn.Image")));
            this.RightBtn.Location = new System.Drawing.Point(204, 30);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(32, 32);
            this.RightBtn.TabIndex = 5;
            this.RightBtn.UseVisualStyleBackColor = false;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.FlatAppearance.BorderSize = 0;
            this.StopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.StopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopBtn.Image")));
            this.StopBtn.Location = new System.Drawing.Point(288, 30);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(32, 32);
            this.StopBtn.TabIndex = 6;
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // SeekSlider
            // 
            this.SeekSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(93)))));
            this.SeekSlider.Location = new System.Drawing.Point(41, 114);
            this.SeekSlider.Maximum = 100;
            this.SeekSlider.Name = "SeekSlider";
            this.SeekSlider.Size = new System.Drawing.Size(300, 45);
            this.SeekSlider.TabIndex = 7;
            this.SeekSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SeekSlider.Scroll += new System.EventHandler(this.SeekSlider_Scroll);
            this.SeekSlider.ValueChanged += new System.EventHandler(this.SeekSlider_ValueChanged);
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(93)))));
            this.VolumeSlider.Location = new System.Drawing.Point(77, 144);
            this.VolumeSlider.Maximum = 1000;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(148, 45);
            this.VolumeSlider.TabIndex = 8;
            this.VolumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeSlider.ValueChanged += new System.EventHandler(this.VolumeSlider_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(351, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(31, 29);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FullLabel
            // 
            this.FullLabel.AutoSize = true;
            this.FullLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullLabel.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FullLabel.Location = new System.Drawing.Point(1, 95);
            this.FullLabel.Name = "FullLabel";
            this.FullLabel.Size = new System.Drawing.Size(35, 16);
            this.FullLabel.TabIndex = 12;
            this.FullLabel.Text = "00.00";
            // 
            // CurrLabel
            // 
            this.CurrLabel.AutoSize = true;
            this.CurrLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrLabel.Font = new System.Drawing.Font("Ubuntu", 8.25F);
            this.CurrLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrLabel.Location = new System.Drawing.Point(347, 98);
            this.CurrLabel.Name = "CurrLabel";
            this.CurrLabel.Size = new System.Drawing.Size(35, 16);
            this.CurrLabel.TabIndex = 13;
            this.CurrLabel.Text = "00.00";
            // 
            // NowLabel
            // 
            this.NowLabel.AutoSize = true;
            this.NowLabel.BackColor = System.Drawing.Color.Transparent;
            this.NowLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowLabel.ForeColor = System.Drawing.Color.Transparent;
            this.NowLabel.Location = new System.Drawing.Point(24, 75);
            this.NowLabel.Name = "NowLabel";
            this.NowLabel.Size = new System.Drawing.Size(97, 20);
            this.NowLabel.TabIndex = 14;
            this.NowLabel.Text = "NowPlaying:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(127, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 17);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "None";
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.SystemColors.ControlText;
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProgressBar.Location = new System.Drawing.Point(41, 98);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(300, 10);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 16;
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBtn.FlatAppearance.BorderSize = 0;
            this.VolumeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.VolumeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.VolumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolumeBtn.Image = ((System.Drawing.Image)(resources.GetObject("VolumeBtn.Image")));
            this.VolumeBtn.Location = new System.Drawing.Point(231, 135);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(32, 32);
            this.VolumeBtn.TabIndex = 17;
            this.VolumeBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "I do see the beauty in the rules, the invisible code of chaos... ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(384, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VolumeBtn);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NowLabel);
            this.Controls.Add(this.CurrLabel);
            this.Controls.Add(this.FullLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.VolumeSlider);
            this.Controls.Add(this.SeekSlider);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.OpenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3Player";
            ((System.ComponentModel.ISupportInitialize)(this.SeekSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TrackBar SeekSlider;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label FullLabel;
        private System.Windows.Forms.Label CurrLabel;
        private System.Windows.Forms.Label NowLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button VolumeBtn;
        private System.Windows.Forms.Label label1;
    }
}


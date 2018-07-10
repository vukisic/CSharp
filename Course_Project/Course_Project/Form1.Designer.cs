namespace Course_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatisticBtn = new System.Windows.Forms.Button();
            this.GridBtn = new System.Windows.Forms.Button();
            this.SaveAsBtn = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveAs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.pbX = new System.Windows.Forms.ProgressBar();
            this.pb10 = new System.Windows.Forms.ProgressBar();
            this.pb9 = new System.Windows.Forms.ProgressBar();
            this.pb8 = new System.Windows.Forms.ProgressBar();
            this.pb7 = new System.Windows.Forms.ProgressBar();
            this.pb6 = new System.Windows.Forms.ProgressBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedCheckBox = new System.Windows.Forms.CheckBox();
            this.GradeTextBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.ECTSTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FinalECTS = new System.Windows.Forms.Label();
            this.FinalGrade = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SaveAsBtn.SuspendLayout();
            this.GridPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StatisticBtn);
            this.panel1.Controls.Add(this.GridBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 396);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistic";
            // 
            // StatisticBtn
            // 
            this.StatisticBtn.FlatAppearance.BorderSize = 0;
            this.StatisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticBtn.Image = ((System.Drawing.Image)(resources.GetObject("StatisticBtn.Image")));
            this.StatisticBtn.Location = new System.Drawing.Point(3, 210);
            this.StatisticBtn.Name = "StatisticBtn";
            this.StatisticBtn.Size = new System.Drawing.Size(85, 49);
            this.StatisticBtn.TabIndex = 2;
            this.StatisticBtn.UseVisualStyleBackColor = true;
            this.StatisticBtn.Click += new System.EventHandler(this.StatisticBtn_Click);
            // 
            // GridBtn
            // 
            this.GridBtn.FlatAppearance.BorderSize = 0;
            this.GridBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridBtn.Image = ((System.Drawing.Image)(resources.GetObject("GridBtn.Image")));
            this.GridBtn.Location = new System.Drawing.Point(3, 66);
            this.GridBtn.Name = "GridBtn";
            this.GridBtn.Size = new System.Drawing.Size(87, 62);
            this.GridBtn.TabIndex = 1;
            this.GridBtn.UseVisualStyleBackColor = true;
            this.GridBtn.Click += new System.EventHandler(this.GridBtn_Click);
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SaveAsBtn.Controls.Add(this.label6);
            this.SaveAsBtn.Controls.Add(this.SaveAs);
            this.SaveAsBtn.Controls.Add(this.label5);
            this.SaveAsBtn.Controls.Add(this.SaveBtn);
            this.SaveAsBtn.Controls.Add(this.label4);
            this.SaveAsBtn.Controls.Add(this.OpenBtn);
            this.SaveAsBtn.Location = new System.Drawing.Point(94, 315);
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(486, 81);
            this.SaveAsBtn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(306, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "SaveAs";
            // 
            // SaveAs
            // 
            this.SaveAs.FlatAppearance.BorderSize = 0;
            this.SaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs.Image")));
            this.SaveAs.Location = new System.Drawing.Point(294, 8);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(77, 37);
            this.SaveAs.TabIndex = 6;
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(207, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Save";
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Location = new System.Drawing.Point(193, 8);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(77, 37);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Open";
            // 
            // OpenBtn
            // 
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenBtn.Image")));
            this.OpenBtn.Location = new System.Drawing.Point(92, 8);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(77, 37);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.StatusPanel);
            this.GridPanel.Controls.Add(this.dataGridView1);
            this.GridPanel.Location = new System.Drawing.Point(94, 0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(486, 317);
            this.GridPanel.TabIndex = 3;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.pbX);
            this.StatusPanel.Controls.Add(this.pb10);
            this.StatusPanel.Controls.Add(this.pb9);
            this.StatusPanel.Controls.Add(this.pb8);
            this.StatusPanel.Controls.Add(this.pb7);
            this.StatusPanel.Controls.Add(this.pb6);
            this.StatusPanel.Controls.Add(this.label13);
            this.StatusPanel.Controls.Add(this.label12);
            this.StatusPanel.Controls.Add(this.label11);
            this.StatusPanel.Controls.Add(this.label10);
            this.StatusPanel.Controls.Add(this.label9);
            this.StatusPanel.Controls.Add(this.label3);
            this.StatusPanel.Location = new System.Drawing.Point(0, 3);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(484, 311);
            this.StatusPanel.TabIndex = 1;
            // 
            // pbX
            // 
            this.pbX.Location = new System.Drawing.Point(60, 251);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(342, 23);
            this.pbX.TabIndex = 28;
            // 
            // pb10
            // 
            this.pb10.Location = new System.Drawing.Point(60, 207);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(342, 23);
            this.pb10.TabIndex = 27;
            // 
            // pb9
            // 
            this.pb9.Location = new System.Drawing.Point(60, 163);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(342, 23);
            this.pb9.TabIndex = 26;
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(60, 119);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(342, 23);
            this.pb8.TabIndex = 25;
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(60, 75);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(342, 23);
            this.pb7.TabIndex = 24;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(60, 31);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(342, 23);
            this.pb6.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(38, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(32, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.ECTS,
            this.Grade,
            this.Passed});
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.Width = 140;
            // 
            // ECTS
            // 
            this.ECTS.HeaderText = "ECTS";
            this.ECTS.Name = "ECTS";
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // Passed
            // 
            this.Passed.HeaderText = "Passed";
            this.Passed.Name = "Passed";
            // 
            // PassedCheckBox
            // 
            this.PassedCheckBox.Checked = true;
            this.PassedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PassedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PassedCheckBox.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold);
            this.PassedCheckBox.ForeColor = System.Drawing.Color.White;
            this.PassedCheckBox.Location = new System.Drawing.Point(585, 155);
            this.PassedCheckBox.Name = "PassedCheckBox";
            this.PassedCheckBox.Size = new System.Drawing.Size(70, 35);
            this.PassedCheckBox.TabIndex = 22;
            this.PassedCheckBox.Text = "Passed";
            this.PassedCheckBox.UseVisualStyleBackColor = true;
            // 
            // GradeTextBox1
            // 
            this.GradeTextBox1.Location = new System.Drawing.Point(585, 127);
            this.GradeTextBox1.MaxLength = 2;
            this.GradeTextBox1.Name = "GradeTextBox1";
            this.GradeTextBox1.Size = new System.Drawing.Size(229, 20);
            this.GradeTextBox1.TabIndex = 21;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(586, 107);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 17);
            this.label.TabIndex = 20;
            this.label.Text = "Grade :";
            // 
            // ECTSTextBox
            // 
            this.ECTSTextBox.Location = new System.Drawing.Point(585, 82);
            this.ECTSTextBox.MaxLength = 2;
            this.ECTSTextBox.Name = "ECTSTextBox";
            this.ECTSTextBox.Size = new System.Drawing.Size(229, 20);
            this.ECTSTextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(586, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "ECTS :";
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Location = new System.Drawing.Point(585, 37);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(229, 20);
            this.CourseTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Ubuntu Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(586, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Course :";
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.AddBtn.FlatAppearance.BorderSize = 2;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Ubuntu Light", 11.25F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(588, 198);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(226, 33);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(606, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 22);
            this.label14.TabIndex = 23;
            this.label14.Text = "ECTS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Ubuntu Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(694, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 22);
            this.label15.TabIndex = 8;
            this.label15.Text = "Average Grade";
            // 
            // FinalECTS
            // 
            this.FinalECTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalECTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalECTS.Font = new System.Drawing.Font("Ubuntu Light", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalECTS.ForeColor = System.Drawing.Color.Gold;
            this.FinalECTS.Location = new System.Drawing.Point(589, 291);
            this.FinalECTS.Name = "FinalECTS";
            this.FinalECTS.Size = new System.Drawing.Size(81, 34);
            this.FinalECTS.TabIndex = 24;
            this.FinalECTS.Text = "0";
            this.FinalECTS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FinalGrade
            // 
            this.FinalGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalGrade.Font = new System.Drawing.Font("Ubuntu Light", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalGrade.ForeColor = System.Drawing.Color.Gold;
            this.FinalGrade.Location = new System.Drawing.Point(698, 291);
            this.FinalGrade.Name = "FinalGrade";
            this.FinalGrade.Size = new System.Drawing.Size(103, 34);
            this.FinalGrade.TabIndex = 25;
            this.FinalGrade.Text = "0";
            this.FinalGrade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(822, 396);
            this.Controls.Add(this.FinalGrade);
            this.Controls.Add(this.FinalECTS);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PassedCheckBox);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.GradeTextBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SaveAsBtn);
            this.Controls.Add(this.ECTSTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CourseChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SaveAsBtn.ResumeLayout(false);
            this.SaveAsBtn.PerformLayout();
            this.GridPanel.ResumeLayout(false);
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SaveAsBtn;
        private System.Windows.Forms.Button StatisticBtn;
        private System.Windows.Forms.Button GridBtn;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.CheckBox PassedCheckBox;
        private System.Windows.Forms.TextBox GradeTextBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox ECTSTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passed;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label FinalECTS;
        private System.Windows.Forms.Label FinalGrade;
        private System.Windows.Forms.ProgressBar pbX;
        private System.Windows.Forms.ProgressBar pb10;
        private System.Windows.Forms.ProgressBar pb9;
        private System.Windows.Forms.ProgressBar pb8;
        private System.Windows.Forms.ProgressBar pb7;
        private System.Windows.Forms.ProgressBar pb6;
    }
}


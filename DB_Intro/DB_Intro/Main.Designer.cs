namespace DB_Intro
{
    partial class Main
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
            this.labelTransformer = new System.Windows.Forms.Label();
            this.listBoxTransfromer = new System.Windows.Forms.ListBox();
            this.listBoxPlace = new System.Windows.Forms.ListBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPAddition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAdditional = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PowerUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxNewPlaces = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddPlaceBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTransformer
            // 
            this.labelTransformer.AutoSize = true;
            this.labelTransformer.Location = new System.Drawing.Point(6, 23);
            this.labelTransformer.Name = "labelTransformer";
            this.labelTransformer.Size = new System.Drawing.Size(74, 13);
            this.labelTransformer.TabIndex = 0;
            this.labelTransformer.Text = "Transformers :";
            // 
            // listBoxTransfromer
            // 
            this.listBoxTransfromer.FormattingEnabled = true;
            this.listBoxTransfromer.Location = new System.Drawing.Point(6, 40);
            this.listBoxTransfromer.Name = "listBoxTransfromer";
            this.listBoxTransfromer.Size = new System.Drawing.Size(212, 251);
            this.listBoxTransfromer.TabIndex = 1;
            this.listBoxTransfromer.SelectedIndexChanged += new System.EventHandler(this.listBoxTransfromer_SelectedIndexChanged);
            // 
            // listBoxPlace
            // 
            this.listBoxPlace.FormattingEnabled = true;
            this.listBoxPlace.Location = new System.Drawing.Point(6, 310);
            this.listBoxPlace.Name = "listBoxPlace";
            this.listBoxPlace.Size = new System.Drawing.Size(212, 30);
            this.listBoxPlace.TabIndex = 3;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 294);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(40, 13);
            this.labelPlace.TabIndex = 2;
            this.labelPlace.Text = "Place :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPAddition);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPPower);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxTransfromer);
            this.groupBox1.Controls.Add(this.listBoxPlace);
            this.groupBox1.Controls.Add(this.labelTransformer);
            this.groupBox1.Controls.Add(this.labelPlace);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 454);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // textBoxPAddition
            // 
            this.textBoxPAddition.Location = new System.Drawing.Point(6, 389);
            this.textBoxPAddition.Multiline = true;
            this.textBoxPAddition.Name = "textBoxPAddition";
            this.textBoxPAddition.Size = new System.Drawing.Size(209, 50);
            this.textBoxPAddition.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Additional : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MW";
            // 
            // textBoxPPower
            // 
            this.textBoxPPower.Location = new System.Drawing.Point(55, 343);
            this.textBoxPPower.Name = "textBoxPPower";
            this.textBoxPPower.Size = new System.Drawing.Size(75, 20);
            this.textBoxPPower.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Power :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAdditional);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PowerUpDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Location = new System.Drawing.Point(251, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 454);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Transformer";
            // 
            // textBoxAdditional
            // 
            this.textBoxAdditional.Location = new System.Drawing.Point(10, 122);
            this.textBoxAdditional.Multiline = true;
            this.textBoxAdditional.Name = "textBoxAdditional";
            this.textBoxAdditional.Size = new System.Drawing.Size(178, 99);
            this.textBoxAdditional.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Additional :";
            // 
            // PowerUpDown
            // 
            this.PowerUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PowerUpDown.Location = new System.Drawing.Point(10, 81);
            this.PowerUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PowerUpDown.Name = "PowerUpDown";
            this.PowerUpDown.Size = new System.Drawing.Size(178, 20);
            this.PowerUpDown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Power :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(10, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(84, 409);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 30);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add New";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxNewPlaces);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AddPlaceBtn);
            this.groupBox3.Location = new System.Drawing.Point(459, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 454);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Place";
            // 
            // listBoxNewPlaces
            // 
            this.listBoxNewPlaces.FormattingEnabled = true;
            this.listBoxNewPlaces.Location = new System.Drawing.Point(13, 40);
            this.listBoxNewPlaces.Name = "listBoxNewPlaces";
            this.listBoxNewPlaces.Size = new System.Drawing.Size(168, 251);
            this.listBoxNewPlaces.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Places :";
            // 
            // AddPlaceBtn
            // 
            this.AddPlaceBtn.Location = new System.Drawing.Point(90, 409);
            this.AddPlaceBtn.Name = "AddPlaceBtn";
            this.AddPlaceBtn.Size = new System.Drawing.Size(112, 30);
            this.AddPlaceBtn.TabIndex = 0;
            this.AddPlaceBtn.Text = "Add Place";
            this.AddPlaceBtn.UseVisualStyleBackColor = true;
            this.AddPlaceBtn.Click += new System.EventHandler(this.AddPlaceBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxPName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(667, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 454);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Place";
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(10, 37);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(178, 20);
            this.textBoxPName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 483);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Transformers";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTransformer;
        private System.Windows.Forms.ListBox listBoxTransfromer;
        private System.Windows.Forms.ListBox listBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.NumericUpDown PowerUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdditional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxNewPlaces;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddPlaceBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPPower;
        private System.Windows.Forms.TextBox textBoxPAddition;
    }
}


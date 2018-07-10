namespace TicTacToe
{
    partial class TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.labelXP = new System.Windows.Forms.Label();
            this.labelOP = new System.Windows.Forms.Label();
            this.labelDP = new System.Windows.Forms.Label();
            this.resetCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(251, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(7, 29);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 1;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button_Click);
            this.button11.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button11.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(88, 29);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 75);
            this.button12.TabIndex = 2;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button_Click);
            this.button12.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button12.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(169, 29);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 75);
            this.button13.TabIndex = 3;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button_Click);
            this.button13.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button13.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(7, 110);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 75);
            this.button21.TabIndex = 4;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Button_Click);
            this.button21.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button21.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(88, 110);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 75);
            this.button22.TabIndex = 5;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Button_Click);
            this.button22.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button22.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(169, 110);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 75);
            this.button23.TabIndex = 6;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Button_Click);
            this.button23.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button23.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(7, 191);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 75);
            this.button31.TabIndex = 7;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.Button_Click);
            this.button31.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button31.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(88, 191);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 75);
            this.button32.TabIndex = 8;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.Button_Click);
            this.button32.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button32.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(169, 191);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(75, 75);
            this.button33.TabIndex = 9;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.Button_Click);
            this.button33.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.button33.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(12, 279);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(47, 13);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "X Wins";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO.Location = new System.Drawing.Point(85, 279);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(48, 13);
            this.labelO.TabIndex = 11;
            this.labelO.Text = "O Wins";
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraw.Location = new System.Drawing.Point(166, 279);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(42, 13);
            this.labelDraw.TabIndex = 12;
            this.labelDraw.Text = "Draws";
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.Location = new System.Drawing.Point(26, 292);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(13, 13);
            this.labelXP.TabIndex = 13;
            this.labelXP.Text = "0";
            // 
            // labelOP
            // 
            this.labelOP.AutoSize = true;
            this.labelOP.Location = new System.Drawing.Point(100, 292);
            this.labelOP.Name = "labelOP";
            this.labelOP.Size = new System.Drawing.Size(13, 13);
            this.labelOP.TabIndex = 14;
            this.labelOP.Text = "0";
            // 
            // labelDP
            // 
            this.labelDP.AutoSize = true;
            this.labelDP.Location = new System.Drawing.Point(178, 292);
            this.labelDP.Name = "labelDP";
            this.labelDP.Size = new System.Drawing.Size(13, 13);
            this.labelDP.TabIndex = 15;
            this.labelDP.Text = "0";
            // 
            // resetCountsToolStripMenuItem
            // 
            this.resetCountsToolStripMenuItem.Name = "resetCountsToolStripMenuItem";
            this.resetCountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetCountsToolStripMenuItem.Text = "Reset Counts";
            this.resetCountsToolStripMenuItem.Click += new System.EventHandler(this.resetCountsToolStripMenuItem_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 327);
            this.Controls.Add(this.labelDP);
            this.Controls.Add(this.labelOP);
            this.Controls.Add(this.labelXP);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.Label labelOP;
        private System.Windows.Forms.Label labelDP;
        private System.Windows.Forms.ToolStripMenuItem resetCountsToolStripMenuItem;
    }
}


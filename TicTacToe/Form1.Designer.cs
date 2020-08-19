namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.XWinCount = new System.Windows.Forms.Label();
            this.DrawCount = new System.Windows.Forms.Label();
            this.OWinCount = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.setPlayerDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(382, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.setPlayerDefaultsToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A00
            // 
            this.A00.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A00.Location = new System.Drawing.Point(73, 75);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(75, 75);
            this.A00.TabIndex = 2;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.Button_click);
            this.A00.MouseEnter += new System.EventHandler(this.button_enter);
            this.A00.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A01
            // 
            this.A01.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A01.Location = new System.Drawing.Point(154, 75);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(75, 75);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.Button_click);
            this.A01.MouseEnter += new System.EventHandler(this.button_enter);
            this.A01.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A02
            // 
            this.A02.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A02.Location = new System.Drawing.Point(235, 75);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(75, 75);
            this.A02.TabIndex = 4;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.Button_click);
            this.A02.MouseEnter += new System.EventHandler(this.button_enter);
            this.A02.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A10
            // 
            this.A10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A10.Location = new System.Drawing.Point(73, 156);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(75, 75);
            this.A10.TabIndex = 5;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.Button_click);
            this.A10.MouseEnter += new System.EventHandler(this.button_enter);
            this.A10.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A11
            // 
            this.A11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A11.Location = new System.Drawing.Point(154, 156);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(75, 75);
            this.A11.TabIndex = 6;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.Button_click);
            this.A11.MouseEnter += new System.EventHandler(this.button_enter);
            this.A11.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A12
            // 
            this.A12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A12.Location = new System.Drawing.Point(235, 156);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(75, 75);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.Button_click);
            this.A12.MouseEnter += new System.EventHandler(this.button_enter);
            this.A12.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A20
            // 
            this.A20.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A20.Location = new System.Drawing.Point(73, 237);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(75, 75);
            this.A20.TabIndex = 8;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.Button_click);
            this.A20.MouseEnter += new System.EventHandler(this.button_enter);
            this.A20.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A21
            // 
            this.A21.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A21.Location = new System.Drawing.Point(154, 237);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(75, 75);
            this.A21.TabIndex = 9;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.Button_click);
            this.A21.MouseEnter += new System.EventHandler(this.button_enter);
            this.A21.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A22
            // 
            this.A22.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A22.Location = new System.Drawing.Point(235, 237);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(75, 75);
            this.A22.TabIndex = 10;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.Button_click);
            this.A22.MouseEnter += new System.EventHandler(this.button_enter);
            this.A22.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(151, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Draw Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XWinCount
            // 
            this.XWinCount.AutoSize = true;
            this.XWinCount.Location = new System.Drawing.Point(79, 365);
            this.XWinCount.Name = "XWinCount";
            this.XWinCount.Size = new System.Drawing.Size(13, 13);
            this.XWinCount.TabIndex = 14;
            this.XWinCount.Text = "0";
            // 
            // DrawCount
            // 
            this.DrawCount.AutoSize = true;
            this.DrawCount.Location = new System.Drawing.Point(179, 365);
            this.DrawCount.Name = "DrawCount";
            this.DrawCount.Size = new System.Drawing.Size(13, 13);
            this.DrawCount.TabIndex = 15;
            this.DrawCount.Text = "0";
            // 
            // OWinCount
            // 
            this.OWinCount.AutoSize = true;
            this.OWinCount.Location = new System.Drawing.Point(286, 365);
            this.OWinCount.Name = "OWinCount";
            this.OWinCount.Size = new System.Drawing.Size(13, 13);
            this.OWinCount.TabIndex = 16;
            this.OWinCount.Text = "0";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(49, 342);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(77, 20);
            this.p1.TabIndex = 17;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(251, 342);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(82, 20);
            this.p2.TabIndex = 18;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.p2_TextChanged);
            // 
            // setPlayerDefaultsToolStripMenuItem
            // 
            this.setPlayerDefaultsToolStripMenuItem.Name = "setPlayerDefaultsToolStripMenuItem";
            this.setPlayerDefaultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPlayerDefaultsToolStripMenuItem.Text = "Set Player Defaults";
            this.setPlayerDefaultsToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDefaultsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 387);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.OWinCount);
            this.Controls.Add(this.DrawCount);
            this.Controls.Add(this.XWinCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label XWinCount;
        private System.Windows.Forms.Label DrawCount;
        private System.Windows.Forms.Label OWinCount;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDefaultsToolStripMenuItem;
    }
}


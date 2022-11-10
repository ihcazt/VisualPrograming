namespace P14_MultiForms
{
    partial class MainForm
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
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hullOfFamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HallOfFameTicTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.breakdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.hullOfFamesToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticTacToeToolStripMenuItem,
            this.matchingToolStripMenuItem,
            this.breakoutToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // ticTacToeToolStripMenuItem
            // 
            this.ticTacToeToolStripMenuItem.Name = "ticTacToeToolStripMenuItem";
            this.ticTacToeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ticTacToeToolStripMenuItem.Text = "TicTacToe";
            this.ticTacToeToolStripMenuItem.Click += new System.EventHandler(this.TicTacToeToolStripMenuItem_Click);
            // 
            // matchingToolStripMenuItem
            // 
            this.matchingToolStripMenuItem.Name = "matchingToolStripMenuItem";
            this.matchingToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.matchingToolStripMenuItem.Text = "Matching";
            // 
            // breakoutToolStripMenuItem
            // 
            this.breakoutToolStripMenuItem.Name = "breakoutToolStripMenuItem";
            this.breakoutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.breakoutToolStripMenuItem.Text = "Breakout";
            // 
            // hullOfFamesToolStripMenuItem
            // 
            this.hullOfFamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HallOfFameTicTacToeToolStripMenuItem,
            this.matchingToolStripMenuItem1,
            this.breakdownToolStripMenuItem});
            this.hullOfFamesToolStripMenuItem.Name = "hullOfFamesToolStripMenuItem";
            this.hullOfFamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hullOfFamesToolStripMenuItem.Text = "Hall of Fame";
            // 
            // HallOfFameTicTacToeToolStripMenuItem
            // 
            this.HallOfFameTicTacToeToolStripMenuItem.Name = "HallOfFameTicTacToeToolStripMenuItem";
            this.HallOfFameTicTacToeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.HallOfFameTicTacToeToolStripMenuItem.Text = "TicTacToe";
            this.HallOfFameTicTacToeToolStripMenuItem.Click += new System.EventHandler(this.HallOfFameTicTacToeToolStripMenuItem_Click);
            // 
            // matchingToolStripMenuItem1
            // 
            this.matchingToolStripMenuItem1.Name = "matchingToolStripMenuItem1";
            this.matchingToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.matchingToolStripMenuItem1.Text = "Matching";
            // 
            // breakdownToolStripMenuItem
            // 
            this.breakdownToolStripMenuItem.Name = "breakdownToolStripMenuItem";
            this.breakdownToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.breakdownToolStripMenuItem.Text = "Breakdown";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Multi Form System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticTacToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hullOfFamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HallOfFameTicTacToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem breakdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}


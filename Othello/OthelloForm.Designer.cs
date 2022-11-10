
namespace Othello
{
    partial class OthelloForm
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
            this.OteloMenuStrip = new System.Windows.Forms.MenuStrip();
            this.OthelloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HallOfFameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OteloMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OteloMenuStrip
            // 
            this.OteloMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OthelloToolStripMenuItem});
            this.OteloMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OteloMenuStrip.Name = "OteloMenuStrip";
            this.OteloMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.OteloMenuStrip.TabIndex = 0;
            // 
            // OthelloToolStripMenuItem
            // 
            this.OthelloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HallOfFameToolStripMenuItem,
            this.RestartToolStripMenuItem});
            this.OthelloToolStripMenuItem.Name = "OthelloToolStripMenuItem";
            this.OthelloToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.OthelloToolStripMenuItem.Text = "Othello";
            // 
            // HallOfFameToolStripMenuItem
            // 
            this.HallOfFameToolStripMenuItem.Name = "HallOfFameToolStripMenuItem";
            this.HallOfFameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HallOfFameToolStripMenuItem.Text = "Hall of Fame";
            this.HallOfFameToolStripMenuItem.Click += new System.EventHandler(this.HallOfFameToolStripMenuItem_Click);
            // 
            // RestartToolStripMenuItem
            // 
            this.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
            this.RestartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RestartToolStripMenuItem.Text = "Restart";
            this.RestartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // OthelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OteloMenuStrip);
            this.MainMenuStrip = this.OteloMenuStrip;
            this.Name = "OthelloForm";
            this.Text = "Othello";
            this.Load += new System.EventHandler(this.OthelloForm_Load);
            this.OteloMenuStrip.ResumeLayout(false);
            this.OteloMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OteloMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OthelloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HallOfFameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartToolStripMenuItem;
    }
}


namespace P13_BreakoutGame
{
    partial class BreakoutGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BreakoutGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "BreakoutGameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BreakoutGameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreakoutGameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BreakoutGameForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}


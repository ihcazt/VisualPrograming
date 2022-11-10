
namespace Othello
{
    partial class HallOfFameForm
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
            this.HallOfFameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HallOfFameLabel
            // 
            this.HallOfFameLabel.AutoSize = true;
            this.HallOfFameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HallOfFameLabel.Location = new System.Drawing.Point(77, 9);
            this.HallOfFameLabel.Name = "HallOfFameLabel";
            this.HallOfFameLabel.Size = new System.Drawing.Size(102, 20);
            this.HallOfFameLabel.TabIndex = 0;
            this.HallOfFameLabel.Text = "Hall Of Fame";
            // 
            // HallOfFameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 39);
            this.Controls.Add(this.HallOfFameLabel);
            this.Name = "HallOfFameForm";
            this.Text = "Hall Of Fames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HallOfFameLabel;
    }
}
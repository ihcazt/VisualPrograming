
namespace P14_MultiForms
{
    partial class TicTacToeHallOfFameFrame
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
            this.HallOfFamesDataGridView = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Losses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HallOfFamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HallOfFamesDataGridView
            // 
            this.HallOfFamesDataGridView.AllowUserToDeleteRows = false;
            this.HallOfFamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HallOfFamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.Wins,
            this.Draws,
            this.Losses,
            this.Score});
            this.HallOfFamesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.HallOfFamesDataGridView.Name = "HallOfFamesDataGridView";
            this.HallOfFamesDataGridView.ReadOnly = true;
            this.HallOfFamesDataGridView.Size = new System.Drawing.Size(544, 182);
            this.HallOfFamesDataGridView.TabIndex = 0;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // Wins
            // 
            this.Wins.HeaderText = "Wins";
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            // 
            // Draws
            // 
            this.Draws.HeaderText = "Draws";
            this.Draws.Name = "Draws";
            this.Draws.ReadOnly = true;
            // 
            // Losses
            // 
            this.Losses.HeaderText = "Losses";
            this.Losses.Name = "Losses";
            this.Losses.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // TicTacToeHallOfFameFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 181);
            this.Controls.Add(this.HallOfFamesDataGridView);
            this.Name = "TicTacToeHallOfFameFrame";
            this.Text = "TicTacToe Hall Of FameFrame";
            ((System.ComponentModel.ISupportInitialize)(this.HallOfFamesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HallOfFamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn Losses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}
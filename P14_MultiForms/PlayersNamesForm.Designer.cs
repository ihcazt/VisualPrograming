
namespace P11._1_TicTacToe
{
    partial class TwoPlayersNamesForm
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
            this.FirstPlayerNameLabel = new System.Windows.Forms.Label();
            this.SecondPlayerNameLabel = new System.Windows.Forms.Label();
            this.FirstPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstPlayerNameLabel
            // 
            this.FirstPlayerNameLabel.AutoSize = true;
            this.FirstPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FirstPlayerNameLabel.Location = new System.Drawing.Point(44, 27);
            this.FirstPlayerNameLabel.Name = "FirstPlayerNameLabel";
            this.FirstPlayerNameLabel.Size = new System.Drawing.Size(137, 20);
            this.FirstPlayerNameLabel.TabIndex = 0;
            this.FirstPlayerNameLabel.Text = "First Player Name:";
            // 
            // SecondPlayerNameLabel
            // 
            this.SecondPlayerNameLabel.AutoSize = true;
            this.SecondPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SecondPlayerNameLabel.Location = new System.Drawing.Point(44, 73);
            this.SecondPlayerNameLabel.Name = "SecondPlayerNameLabel";
            this.SecondPlayerNameLabel.Size = new System.Drawing.Size(161, 20);
            this.SecondPlayerNameLabel.TabIndex = 1;
            this.SecondPlayerNameLabel.Text = "Second Player Name:";
            // 
            // FirstPlayerNameTextBox
            // 
            this.FirstPlayerNameTextBox.Location = new System.Drawing.Point(211, 29);
            this.FirstPlayerNameTextBox.Name = "FirstPlayerNameTextBox";
            this.FirstPlayerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstPlayerNameTextBox.TabIndex = 2;
            // 
            // SecondPlayerNameTextBox
            // 
            this.SecondPlayerNameTextBox.Location = new System.Drawing.Point(211, 73);
            this.SecondPlayerNameTextBox.Name = "SecondPlayerNameTextBox";
            this.SecondPlayerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondPlayerNameTextBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubmitButton.Location = new System.Drawing.Point(146, 124);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 27);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PlayersNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 178);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SecondPlayerNameTextBox);
            this.Controls.Add(this.FirstPlayerNameTextBox);
            this.Controls.Add(this.SecondPlayerNameLabel);
            this.Controls.Add(this.FirstPlayerNameLabel);
            this.Name = "PlayersNamesForm";
            this.Text = "Players Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstPlayerNameLabel;
        private System.Windows.Forms.Label SecondPlayerNameLabel;
        private System.Windows.Forms.TextBox FirstPlayerNameTextBox;
        private System.Windows.Forms.TextBox SecondPlayerNameTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}
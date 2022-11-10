namespace P09_SimpleCalculator
{
    partial class SimpleCalculatorForm
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
            this.FirstValueLabel = new System.Windows.Forms.Label();
            this.SecondValueLabel = new System.Windows.Forms.Label();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.FirstValueTextBox = new System.Windows.Forms.TextBox();
            this.SecondValueTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTtextBox = new System.Windows.Forms.TextBox();
            this.OperatorComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstValueLabel
            // 
            this.FirstValueLabel.AutoSize = true;
            this.FirstValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstValueLabel.Location = new System.Drawing.Point(94, 74);
            this.FirstValueLabel.Name = "FirstValueLabel";
            this.FirstValueLabel.Size = new System.Drawing.Size(85, 21);
            this.FirstValueLabel.TabIndex = 1;
            this.FirstValueLabel.Text = "First Value:";
            // 
            // SecondValueLabel
            // 
            this.SecondValueLabel.AutoSize = true;
            this.SecondValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondValueLabel.Location = new System.Drawing.Point(94, 110);
            this.SecondValueLabel.Name = "SecondValueLabel";
            this.SecondValueLabel.Size = new System.Drawing.Size(106, 21);
            this.SecondValueLabel.TabIndex = 2;
            this.SecondValueLabel.Text = "Second Value:";
            // 
            // OperatorLabel
            // 
            this.OperatorLabel.AutoSize = true;
            this.OperatorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OperatorLabel.Location = new System.Drawing.Point(94, 35);
            this.OperatorLabel.Name = "OperatorLabel";
            this.OperatorLabel.Size = new System.Drawing.Size(76, 21);
            this.OperatorLabel.TabIndex = 0;
            this.OperatorLabel.Text = "Operator:";
            // 
            // FirstValueTextBox
            // 
            this.FirstValueTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstValueTextBox.Location = new System.Drawing.Point(217, 72);
            this.FirstValueTextBox.Name = "FirstValueTextBox";
            this.FirstValueTextBox.Size = new System.Drawing.Size(100, 29);
            this.FirstValueTextBox.TabIndex = 1;
            this.FirstValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstValueTextBox.Leave += new System.EventHandler(this.FirstValueTextBox_Leave);
            // 
            // SecondValueTextBox
            // 
            this.SecondValueTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondValueTextBox.Location = new System.Drawing.Point(217, 108);
            this.SecondValueTextBox.Name = "SecondValueTextBox";
            this.SecondValueTextBox.Size = new System.Drawing.Size(100, 29);
            this.SecondValueTextBox.TabIndex = 2;
            this.SecondValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondValueTextBox.Leave += new System.EventHandler(this.SecondValueTextBox_Leave);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(94, 147);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(56, 21);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Result:";
            // 
            // ResultTtextBox
            // 
            this.ResultTtextBox.Enabled = false;
            this.ResultTtextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultTtextBox.Location = new System.Drawing.Point(217, 145);
            this.ResultTtextBox.Name = "ResultTtextBox";
            this.ResultTtextBox.ReadOnly = true;
            this.ResultTtextBox.Size = new System.Drawing.Size(100, 29);
            this.ResultTtextBox.TabIndex = 3;
            this.ResultTtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OperatorComboBox
            // 
            this.OperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OperatorComboBox.FormattingEnabled = true;
            this.OperatorComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperatorComboBox.Location = new System.Drawing.Point(217, 37);
            this.OperatorComboBox.Name = "OperatorComboBox";
            this.OperatorComboBox.Size = new System.Drawing.Size(100, 29);
            this.OperatorComboBox.TabIndex = 0;
            this.OperatorComboBox.TabStop = false;
            this.OperatorComboBox.SelectedIndexChanged += new System.EventHandler(this.OperatorComboBox_SelectedIndexChanged);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(425, 208);
            this.Controls.Add(this.OperatorComboBox);
            this.Controls.Add(this.ResultTtextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SecondValueTextBox);
            this.Controls.Add(this.FirstValueTextBox);
            this.Controls.Add(this.OperatorLabel);
            this.Controls.Add(this.SecondValueLabel);
            this.Controls.Add(this.FirstValueLabel);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.SimpleCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstValueLabel;
        private System.Windows.Forms.Label SecondValueLabel;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.TextBox FirstValueTextBox;
        private System.Windows.Forms.TextBox SecondValueTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTtextBox;
        private System.Windows.Forms.ComboBox OperatorComboBox;
    }
}


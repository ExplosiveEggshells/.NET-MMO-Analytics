namespace RogersErwin_Assign3
{
    partial class Form1
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
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.OutputBoxLabel = new System.Windows.Forms.Label();
            this.PercentageOfRaceLabel = new System.Windows.Forms.Label();
            this.PercentageOfRaceComboBox = new System.Windows.Forms.ComboBox();
            this.PercentageOfMaxLvlLabel = new System.Windows.Forms.Label();
            this.MaxLvlPlayersQueryButton = new System.Windows.Forms.Button();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.AllClassTypeLabel = new System.Windows.Forms.Label();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.AllClassTypeQueryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 16;
            this.OutputListBox.Location = new System.Drawing.Point(373, 42);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(599, 516);
            this.OutputListBox.TabIndex = 0;
            // 
            // OutputBoxLabel
            // 
            this.OutputBoxLabel.AutoSize = true;
            this.OutputBoxLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBoxLabel.Location = new System.Drawing.Point(369, 15);
            this.OutputBoxLabel.Name = "OutputBoxLabel";
            this.OutputBoxLabel.Size = new System.Drawing.Size(205, 24);
            this.OutputBoxLabel.TabIndex = 1;
            this.OutputBoxLabel.Text = "Output List Box";
            // 
            // PercentageOfRaceLabel
            // 
            this.PercentageOfRaceLabel.AutoSize = true;
            this.PercentageOfRaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageOfRaceLabel.Location = new System.Drawing.Point(13, 107);
            this.PercentageOfRaceLabel.Name = "PercentageOfRaceLabel";
            this.PercentageOfRaceLabel.Size = new System.Drawing.Size(344, 20);
            this.PercentageOfRaceLabel.TabIndex = 2;
            this.PercentageOfRaceLabel.Text = "Percentage of Each Race From a Single Server";
            // 
            // PercentageOfRaceComboBox
            // 
            this.PercentageOfRaceComboBox.FormattingEnabled = true;
            this.PercentageOfRaceComboBox.Location = new System.Drawing.Point(17, 148);
            this.PercentageOfRaceComboBox.Name = "PercentageOfRaceComboBox";
            this.PercentageOfRaceComboBox.Size = new System.Drawing.Size(106, 21);
            this.PercentageOfRaceComboBox.TabIndex = 3;
            this.PercentageOfRaceComboBox.SelectedIndexChanged += new System.EventHandler(this.PercentageOfRaceComboBox_SelectedIndexChanged);
            // 
            // PercentageOfMaxLvlLabel
            // 
            this.PercentageOfMaxLvlLabel.AutoSize = true;
            this.PercentageOfMaxLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageOfMaxLvlLabel.Location = new System.Drawing.Point(12, 176);
            this.PercentageOfMaxLvlLabel.Name = "PercentageOfMaxLvlLabel";
            this.PercentageOfMaxLvlLabel.Size = new System.Drawing.Size(324, 20);
            this.PercentageOfMaxLvlLabel.TabIndex = 4;
            this.PercentageOfMaxLvlLabel.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // MaxLvlPlayersQueryButton
            // 
            this.MaxLvlPlayersQueryButton.Location = new System.Drawing.Point(17, 199);
            this.MaxLvlPlayersQueryButton.Name = "MaxLvlPlayersQueryButton";
            this.MaxLvlPlayersQueryButton.Size = new System.Drawing.Size(96, 23);
            this.MaxLvlPlayersQueryButton.TabIndex = 5;
            this.MaxLvlPlayersQueryButton.Text = "Show Results";
            this.MaxLvlPlayersQueryButton.UseVisualStyleBackColor = true;
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(17, 83);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(106, 21);
            this.ClassComboBox.TabIndex = 7;
            // 
            // AllClassTypeLabel
            // 
            this.AllClassTypeLabel.AutoSize = true;
            this.AllClassTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClassTypeLabel.Location = new System.Drawing.Point(13, 42);
            this.AllClassTypeLabel.Name = "AllClassTypeLabel";
            this.AllClassTypeLabel.Size = new System.Drawing.Size(254, 20);
            this.AllClassTypeLabel.TabIndex = 6;
            this.AllClassTypeLabel.Text = "All Class Type from a Single Server";
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.Location = new System.Drawing.Point(136, 83);
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.Size = new System.Drawing.Size(106, 21);
            this.ServerComboBox.TabIndex = 8;
            // 
            // AllClassTypeQueryButton
            // 
            this.AllClassTypeQueryButton.Location = new System.Drawing.Point(271, 81);
            this.AllClassTypeQueryButton.Name = "AllClassTypeQueryButton";
            this.AllClassTypeQueryButton.Size = new System.Drawing.Size(96, 23);
            this.AllClassTypeQueryButton.TabIndex = 9;
            this.AllClassTypeQueryButton.Text = "Show Results";
            this.AllClassTypeQueryButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllClassTypeQueryButton);
            this.Controls.Add(this.ServerComboBox);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.AllClassTypeLabel);
            this.Controls.Add(this.MaxLvlPlayersQueryButton);
            this.Controls.Add(this.PercentageOfMaxLvlLabel);
            this.Controls.Add(this.PercentageOfRaceComboBox);
            this.Controls.Add(this.PercentageOfRaceLabel);
            this.Controls.Add(this.OutputBoxLabel);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Label OutputBoxLabel;
        private System.Windows.Forms.Label PercentageOfRaceLabel;
        private System.Windows.Forms.ComboBox PercentageOfRaceComboBox;
        private System.Windows.Forms.Label PercentageOfMaxLvlLabel;
        private System.Windows.Forms.Button MaxLvlPlayersQueryButton;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label AllClassTypeLabel;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.Button AllClassTypeQueryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


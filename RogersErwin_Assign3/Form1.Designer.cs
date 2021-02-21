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
            this.GuildsPerTypeLabel = new System.Windows.Forms.Label();
            this.GuildsPerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.GuildsPerTypeCBLabel = new System.Windows.Forms.Label();
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
            // GuildsPerTypeLabel
            // 
            this.GuildsPerTypeLabel.AutoSize = true;
            this.GuildsPerTypeLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuildsPerTypeLabel.Location = new System.Drawing.Point(12, 348);
            this.GuildsPerTypeLabel.Name = "GuildsPerTypeLabel";
            this.GuildsPerTypeLabel.Size = new System.Drawing.Size(175, 22);
            this.GuildsPerTypeLabel.TabIndex = 1;
            this.GuildsPerTypeLabel.Text = "Guilds Per Type";
            // 
            // GuildsPerTypeComboBox
            // 
            this.GuildsPerTypeComboBox.FormattingEnabled = true;
            this.GuildsPerTypeComboBox.Location = new System.Drawing.Point(15, 390);
            this.GuildsPerTypeComboBox.Name = "GuildsPerTypeComboBox";
            this.GuildsPerTypeComboBox.Size = new System.Drawing.Size(168, 21);
            this.GuildsPerTypeComboBox.TabIndex = 2;
            this.GuildsPerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.GuildsPerTypeComboBox_SelectedIndexChanged);
            // 
            // GuildsPerTypeCBLabel
            // 
            this.GuildsPerTypeCBLabel.AutoSize = true;
            this.GuildsPerTypeCBLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuildsPerTypeCBLabel.Location = new System.Drawing.Point(12, 370);
            this.GuildsPerTypeCBLabel.Name = "GuildsPerTypeCBLabel";
            this.GuildsPerTypeCBLabel.Size = new System.Drawing.Size(44, 17);
            this.GuildsPerTypeCBLabel.TabIndex = 1;
            this.GuildsPerTypeCBLabel.Text = "Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 583);
            this.Controls.Add(this.GuildsPerTypeComboBox);
            this.Controls.Add(this.GuildsPerTypeCBLabel);
            this.Controls.Add(this.GuildsPerTypeLabel);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Label GuildsPerTypeLabel;
        private System.Windows.Forms.ComboBox GuildsPerTypeComboBox;
        private System.Windows.Forms.Label GuildsPerTypeCBLabel;
    }
}


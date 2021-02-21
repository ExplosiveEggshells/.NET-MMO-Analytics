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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FulfillRadioButton0 = new System.Windows.Forms.RadioButton();
            this.FulfillRadioButton2 = new System.Windows.Forms.RadioButton();
            this.FulfillRadioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 16;
            this.OutputListBox.Location = new System.Drawing.Point(359, 42);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(638, 516);
            this.OutputListBox.TabIndex = 0;
            // 
            // GuildsPerTypeLabel
            // 
            this.GuildsPerTypeLabel.AutoSize = true;
            this.GuildsPerTypeLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuildsPerTypeLabel.Location = new System.Drawing.Point(12, 300);
            this.GuildsPerTypeLabel.Name = "GuildsPerTypeLabel";
            this.GuildsPerTypeLabel.Size = new System.Drawing.Size(175, 22);
            this.GuildsPerTypeLabel.TabIndex = 1;
            this.GuildsPerTypeLabel.Text = "Guilds Per Type";
            // 
            // GuildsPerTypeComboBox
            // 
            this.GuildsPerTypeComboBox.FormattingEnabled = true;
            this.GuildsPerTypeComboBox.Location = new System.Drawing.Point(15, 342);
            this.GuildsPerTypeComboBox.Name = "GuildsPerTypeComboBox";
            this.GuildsPerTypeComboBox.Size = new System.Drawing.Size(168, 21);
            this.GuildsPerTypeComboBox.TabIndex = 2;
            this.GuildsPerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.GuildsPerTypeComboBox_SelectedIndexChanged);
            // 
            // GuildsPerTypeCBLabel
            // 
            this.GuildsPerTypeCBLabel.AutoSize = true;
            this.GuildsPerTypeCBLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuildsPerTypeCBLabel.Location = new System.Drawing.Point(12, 322);
            this.GuildsPerTypeCBLabel.Name = "GuildsPerTypeCBLabel";
            this.GuildsPerTypeCBLabel.Size = new System.Drawing.Size(44, 17);
            this.GuildsPerTypeCBLabel.TabIndex = 1;
            this.GuildsPerTypeCBLabel.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Players Not Fulfilling Potential Role";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FulfillRadioButton1);
            this.groupBox1.Controls.Add(this.FulfillRadioButton2);
            this.groupBox1.Controls.Add(this.FulfillRadioButton0);
            this.groupBox1.Location = new System.Drawing.Point(13, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FulfillRadioButton0
            // 
            this.FulfillRadioButton0.AutoSize = true;
            this.FulfillRadioButton0.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FulfillRadioButton0.Location = new System.Drawing.Point(7, 20);
            this.FulfillRadioButton0.Name = "FulfillRadioButton0";
            this.FulfillRadioButton0.Size = new System.Drawing.Size(58, 20);
            this.FulfillRadioButton0.TabIndex = 0;
            this.FulfillRadioButton0.TabStop = true;
            this.FulfillRadioButton0.Text = "Tank";
            this.FulfillRadioButton0.UseVisualStyleBackColor = true;
            this.FulfillRadioButton0.Click += new System.EventHandler(this.FulfillRadioClick);
            // 
            // FulfillRadioButton2
            // 
            this.FulfillRadioButton2.AutoSize = true;
            this.FulfillRadioButton2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FulfillRadioButton2.Location = new System.Drawing.Point(145, 21);
            this.FulfillRadioButton2.Name = "FulfillRadioButton2";
            this.FulfillRadioButton2.Size = new System.Drawing.Size(74, 20);
            this.FulfillRadioButton2.TabIndex = 0;
            this.FulfillRadioButton2.TabStop = true;
            this.FulfillRadioButton2.Text = "Damage";
            this.FulfillRadioButton2.UseVisualStyleBackColor = true;
            this.FulfillRadioButton2.Click += new System.EventHandler(this.FulfillRadioClick);
            // 
            // FulfillRadioButton1
            // 
            this.FulfillRadioButton1.AutoSize = true;
            this.FulfillRadioButton1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FulfillRadioButton1.Location = new System.Drawing.Point(65, 20);
            this.FulfillRadioButton1.Name = "FulfillRadioButton1";
            this.FulfillRadioButton1.Size = new System.Drawing.Size(74, 20);
            this.FulfillRadioButton1.TabIndex = 0;
            this.FulfillRadioButton1.TabStop = true;
            this.FulfillRadioButton1.Text = "Healer";
            this.FulfillRadioButton1.UseVisualStyleBackColor = true;
            this.FulfillRadioButton1.Click += new System.EventHandler(this.FulfillRadioClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GuildsPerTypeComboBox);
            this.Controls.Add(this.GuildsPerTypeCBLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuildsPerTypeLabel);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Label GuildsPerTypeLabel;
        private System.Windows.Forms.ComboBox GuildsPerTypeComboBox;
        private System.Windows.Forms.Label GuildsPerTypeCBLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FulfillRadioButton1;
        private System.Windows.Forms.RadioButton FulfillRadioButton2;
        private System.Windows.Forms.RadioButton FulfillRadioButton0;
    }
}


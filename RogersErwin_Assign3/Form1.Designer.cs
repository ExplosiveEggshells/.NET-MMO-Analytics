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
            this.FulfillRadioButton1 = new System.Windows.Forms.RadioButton();
            this.FulfillRadioButton2 = new System.Windows.Forms.RadioButton();
            this.FulfillRadioButton0 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PRSLRolesComboBox = new System.Windows.Forms.ComboBox();
            this.PRSLServersComboBox = new System.Windows.Forms.ComboBox();
            this.PRSLMinLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.PRSLMaxLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.PRSLRoleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRSLMinLevelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRSLMaxLevelUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputListBox
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 16;
            this.OutputListBox.Location = new System.Drawing.Point(359, 42);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(996, 516);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Players By Role and \r\nServer Within Level";
            // 
            // PRSLRolesComboBox
            // 
            this.PRSLRolesComboBox.FormattingEnabled = true;
            this.PRSLRolesComboBox.Location = new System.Drawing.Point(16, 232);
            this.PRSLRolesComboBox.Name = "PRSLRolesComboBox";
            this.PRSLRolesComboBox.Size = new System.Drawing.Size(121, 21);
            this.PRSLRolesComboBox.TabIndex = 4;
            this.PRSLRolesComboBox.SelectedIndexChanged += new System.EventHandler(this.DoPSRLSearch);
            // 
            // PRSLServersComboBox
            // 
            this.PRSLServersComboBox.FormattingEnabled = true;
            this.PRSLServersComboBox.Location = new System.Drawing.Point(158, 232);
            this.PRSLServersComboBox.Name = "PRSLServersComboBox";
            this.PRSLServersComboBox.Size = new System.Drawing.Size(121, 21);
            this.PRSLServersComboBox.TabIndex = 4;
            this.PRSLServersComboBox.SelectionChangeCommitted += new System.EventHandler(this.DoPSRLSearch);
            // 
            // PRSLMinLevelUpDown
            // 
            this.PRSLMinLevelUpDown.Location = new System.Drawing.Point(79, 265);
            this.PRSLMinLevelUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.PRSLMinLevelUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PRSLMinLevelUpDown.Name = "PRSLMinLevelUpDown";
            this.PRSLMinLevelUpDown.Size = new System.Drawing.Size(58, 20);
            this.PRSLMinLevelUpDown.TabIndex = 5;
            this.PRSLMinLevelUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PRSLMinLevelUpDown.ValueChanged += new System.EventHandler(this.PRSLUpDownChange);
            // 
            // PRSLMaxLevelUpDown
            // 
            this.PRSLMaxLevelUpDown.Location = new System.Drawing.Point(221, 265);
            this.PRSLMaxLevelUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.PRSLMaxLevelUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PRSLMaxLevelUpDown.Name = "PRSLMaxLevelUpDown";
            this.PRSLMaxLevelUpDown.Size = new System.Drawing.Size(58, 20);
            this.PRSLMaxLevelUpDown.TabIndex = 5;
            this.PRSLMaxLevelUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PRSLMaxLevelUpDown.ValueChanged += new System.EventHandler(this.PRSLUpDownChange);
            // 
            // PRSLRoleLabel
            // 
            this.PRSLRoleLabel.AutoSize = true;
            this.PRSLRoleLabel.Location = new System.Drawing.Point(15, 211);
            this.PRSLRoleLabel.Name = "PRSLRoleLabel";
            this.PRSLRoleLabel.Size = new System.Drawing.Size(29, 13);
            this.PRSLRoleLabel.TabIndex = 6;
            this.PRSLRoleLabel.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 583);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PRSLRoleLabel);
            this.Controls.Add(this.PRSLMaxLevelUpDown);
            this.Controls.Add(this.PRSLMinLevelUpDown);
            this.Controls.Add(this.PRSLServersComboBox);
            this.Controls.Add(this.PRSLRolesComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GuildsPerTypeComboBox);
            this.Controls.Add(this.GuildsPerTypeCBLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuildsPerTypeLabel);
            this.Controls.Add(this.OutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRSLMinLevelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRSLMaxLevelUpDown)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PRSLRolesComboBox;
        private System.Windows.Forms.ComboBox PRSLServersComboBox;
        private System.Windows.Forms.NumericUpDown PRSLMinLevelUpDown;
        private System.Windows.Forms.NumericUpDown PRSLMaxLevelUpDown;
        private System.Windows.Forms.Label PRSLRoleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


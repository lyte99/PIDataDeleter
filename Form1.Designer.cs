namespace PIDataDeleter
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
            this.tBoxPIServerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPITagName = new System.Windows.Forms.TextBox();
            this.dtPickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tBoxPIServerName
            // 
            this.tBoxPIServerName.Location = new System.Drawing.Point(73, 41);
            this.tBoxPIServerName.Name = "tBoxPIServerName";
            this.tBoxPIServerName.Size = new System.Drawing.Size(224, 20);
            this.tBoxPIServerName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PI Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PI Tag:";
            // 
            // tBoxPITagName
            // 
            this.tBoxPITagName.Location = new System.Drawing.Point(73, 67);
            this.tBoxPITagName.Name = "tBoxPITagName";
            this.tBoxPITagName.Size = new System.Drawing.Size(224, 20);
            this.tBoxPITagName.TabIndex = 3;
            // 
            // dtPickerStartTime
            // 
            this.dtPickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerStartTime.Location = new System.Drawing.Point(73, 116);
            this.dtPickerStartTime.Name = "dtPickerStartTime";
            this.dtPickerStartTime.Size = new System.Drawing.Size(149, 20);
            this.dtPickerStartTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date:";
            // 
            // dtPickerEndTime
            // 
            this.dtPickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerEndTime.Location = new System.Drawing.Point(73, 156);
            this.dtPickerEndTime.Name = "dtPickerEndTime";
            this.dtPickerEndTime.Size = new System.Drawing.Size(149, 20);
            this.dtPickerEndTime.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPickerEndTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxPITagName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxPIServerName);
            this.Name = "Form1";
            this.Text = "PIDataDeleter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxPIServerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPITagName;
        private System.Windows.Forms.DateTimePicker dtPickerStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPickerEndTime;
    }
}


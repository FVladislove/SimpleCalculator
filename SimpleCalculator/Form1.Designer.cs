namespace SimpleCalculator
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MultiplyCheckBox = new System.Windows.Forms.RadioButton();
            this.MinusCheckBox = new System.Windows.Forms.RadioButton();
            this.AddCheckBox = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(457, 12);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(633, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MultiplyCheckBox);
            this.groupBox2.Controls.Add(this.MinusCheckBox);
            this.groupBox2.Controls.Add(this.AddCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(218, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 279);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // MultiplyCheckBox
            // 
            this.MultiplyCheckBox.Location = new System.Drawing.Point(46, 86);
            this.MultiplyCheckBox.Name = "MultiplyCheckBox";
            this.MultiplyCheckBox.Size = new System.Drawing.Size(104, 24);
            this.MultiplyCheckBox.TabIndex = 2;
            this.MultiplyCheckBox.Text = "Multiply";
            this.MultiplyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinusCheckBox
            // 
            this.MinusCheckBox.Location = new System.Drawing.Point(46, 51);
            this.MinusCheckBox.Name = "MinusCheckBox";
            this.MinusCheckBox.Size = new System.Drawing.Size(104, 24);
            this.MinusCheckBox.TabIndex = 1;
            this.MinusCheckBox.Text = "Minus";
            this.MinusCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddCheckBox
            // 
            this.AddCheckBox.Checked = true;
            this.AddCheckBox.Location = new System.Drawing.Point(46, 21);
            this.AddCheckBox.Name = "AddCheckBox";
            this.AddCheckBox.Size = new System.Drawing.Size(104, 24);
            this.AddCheckBox.TabIndex = 0;
            this.AddCheckBox.TabStop = true;
            this.AddCheckBox.Text = "Add";
            this.AddCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(424, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 279);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton AddCheckBox;
        private System.Windows.Forms.RadioButton MinusCheckBox;
        private System.Windows.Forms.RadioButton MultiplyCheckBox;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        #endregion
    }
}
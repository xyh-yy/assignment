namespace compute_winform
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 40);
            label1.Name = "label1";
            label1.Size = new Size(99, 40);
            label1.TabIndex = 0;
            label1.Text = "运算";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(150, 123);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 1;
            label2.Text = "第一个数：";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(319, 126);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(319, 185);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(150, 182);
            label3.Name = "label3";
            label3.Size = new Size(163, 30);
            label3.TabIndex = 3;
            label3.Text = "第二个数：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(150, 244);
            label4.Name = "label4";
            label4.Size = new Size(133, 30);
            label4.TabIndex = 5;
            label4.Text = "运算符：";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "+", "-", "*", "/", "%" });
            checkedListBox1.Location = new Point(319, 244);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 6;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(603, 293);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 7;
            button1.Text = "计算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "运算";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private Button button1;
    }
}

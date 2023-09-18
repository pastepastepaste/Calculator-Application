namespace Calculator_Application
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
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.BackColor = Color.FromArgb(212, 229, 185);
            txtBoxInput1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.Location = new Point(305, 76);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(110, 26);
            txtBoxInput1.TabIndex = 0;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.BackColor = Color.FromArgb(212, 229, 185);
            txtBoxInput2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.Location = new Point(305, 162);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(110, 26);
            txtBoxInput2.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.BackColor = Color.FromArgb(212, 229, 185);
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(328, 122);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(51, 27);
            cbOperator.TabIndex = 2;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(328, 215);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(0, 19);
            lblDisplayTotal.TabIndex = 3;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(172, 205, 158);
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(305, 288);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(110, 31);
            btnEqual.TabIndex = 4;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 79);
            label1.Name = "label1";
            label1.Size = new Size(189, 19);
            label1.TabIndex = 5;
            label1.Text = "Enter First Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 170);
            label2.Name = "label2";
            label2.Size = new Size(198, 19);
            label2.TabIndex = 6;
            label2.Text = "Enter Second Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(149, 233);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 7;
            label3.Text = "Answer :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 233);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "______";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 222, 167);
            ClientSize = new Size(480, 354);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Name = "Form1";
            Text = "FrmCalculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Button btnEqual;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
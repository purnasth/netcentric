namespace PurnaCalculator
{
    partial class PurnaCalculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(202, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 52);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(202, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 52);
            textBox2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 16F);
            buttonAdd.Location = new Point(202, 334);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(61, 59);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Segoe UI", 16F);
            buttonSubtract.Location = new Point(269, 334);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(61, 59);
            buttonSubtract.TabIndex = 3;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 16F);
            buttonMultiply.Location = new Point(336, 334);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(61, 59);
            buttonMultiply.TabIndex = 4;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 16F);
            buttonDivide.Location = new Point(403, 334);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(61, 59);
            buttonDivide.TabIndex = 5;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(199, 46);
            label1.Name = "label1";
            label1.Size = new Size(360, 28);
            label1.TabIndex = 6;
            label1.Text = "Enter numbers and choose an operation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(202, 99);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Number 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(202, 199);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 8;
            label3.Text = "Number 2";
            // 
            // PurnaCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "PurnaCalculator";
            Text = "Purna Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

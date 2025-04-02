namespace Gui
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
            txtSeed = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCount = new TextBox();
            txtCapacity = new TextBox();
            btnSolve = new Button();
            txtOutput = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Ziarno (seed):";
            label1.Click += label1_Click;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(147, 22);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(100, 23);
            txtSeed.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Liczba przedmiotów:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 83);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 3;
            label3.Text = "Pojemność plecaka:";
            label3.Click += label3_Click;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(147, 51);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(100, 23);
            txtCount.TabIndex = 4;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(147, 80);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 5;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(147, 109);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(75, 23);
            btnSolve.TabIndex = 6;
            btnSolve.Text = "Rozwiąż";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += button1_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 138);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(313, 300);
            txtOutput.TabIndex = 7;
            txtOutput.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 450);
            Controls.Add(txtOutput);
            Controls.Add(btnSolve);
            Controls.Add(txtCapacity);
            Controls.Add(txtCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSeed);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSeed;
        private Label label2;
        private Label label3;
        private TextBox txtCount;
        private TextBox txtCapacity;
        private Button btnSolve;
        private RichTextBox txtOutput;
    }
}

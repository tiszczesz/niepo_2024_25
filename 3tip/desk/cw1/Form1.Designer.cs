namespace cw1
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(156, 39);
            label1.Name = "label1";
            label1.Size = new Size(43, 50);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(30, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 47);
            button1.TabIndex = 1;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F);
            button2.Location = new Point(247, 39);
            button2.Name = "button2";
            button2.Size = new Size(75, 47);
            button2.TabIndex = 2;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 149);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(12, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 139);
            panel2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(3, 16);
            button3.Name = "button3";
            button3.Size = new Size(122, 42);
            button3.TabIndex = 0;
            button3.Text = "START";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 64);
            button4.Name = "button4";
            button4.Size = new Size(122, 46);
            button4.TabIndex = 1;
            button4.Text = "Sprawdź";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 21);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Ilość prób:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(281, 16);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 3;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 43);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "podpowiedź";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}

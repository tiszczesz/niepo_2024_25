namespace cw15_colors
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
            components = new System.ComponentModel.Container();
            tbRed = new TrackBar();
            tbGreen = new TrackBar();
            tbBlue = new TrackBar();
            tbOpacity = new TrackBar();
            panel1 = new Panel();
            lbRed = new Label();
            lbGreen = new Label();
            lbBlue = new Label();
            lbOpacity = new Label();
            btnRandomColor = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOpacity).BeginInit();
            SuspendLayout();
            // 
            // tbRed
            // 
            tbRed.Location = new Point(34, 24);
            tbRed.Maximum = 255;
            tbRed.Name = "tbRed";
            tbRed.Size = new Size(244, 45);
            tbRed.TabIndex = 0;
            tbRed.ValueChanged += tbRed_ValueChanged;
            // 
            // tbGreen
            // 
            tbGreen.Location = new Point(34, 105);
            tbGreen.Maximum = 255;
            tbGreen.Name = "tbGreen";
            tbGreen.Size = new Size(244, 45);
            tbGreen.TabIndex = 1;
            tbGreen.ValueChanged += tbGreen_ValueChanged;
            // 
            // tbBlue
            // 
            tbBlue.Location = new Point(34, 186);
            tbBlue.Maximum = 255;
            tbBlue.Name = "tbBlue";
            tbBlue.Size = new Size(244, 45);
            tbBlue.TabIndex = 2;
            tbBlue.ValueChanged += tbBlue_ValueChanged;
            // 
            // tbOpacity
            // 
            tbOpacity.Location = new Point(34, 267);
            tbOpacity.Maximum = 255;
            tbOpacity.Name = "tbOpacity";
            tbOpacity.Size = new Size(244, 45);
            tbOpacity.TabIndex = 3;
            tbOpacity.Value = 255;
            tbOpacity.ValueChanged += tbOpacity_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(469, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 277);
            panel1.TabIndex = 4;
            // 
            // lbRed
            // 
            lbRed.AutoSize = true;
            lbRed.Location = new Point(290, 24);
            lbRed.Name = "lbRed";
            lbRed.Size = new Size(30, 15);
            lbRed.TabIndex = 5;
            lbRed.Text = "Red:";
            // 
            // lbGreen
            // 
            lbGreen.AutoSize = true;
            lbGreen.Location = new Point(290, 105);
            lbGreen.Name = "lbGreen";
            lbGreen.Size = new Size(41, 15);
            lbGreen.TabIndex = 6;
            lbGreen.Text = "Green:";
            // 
            // lbBlue
            // 
            lbBlue.AutoSize = true;
            lbBlue.Location = new Point(290, 186);
            lbBlue.Name = "lbBlue";
            lbBlue.Size = new Size(33, 15);
            lbBlue.TabIndex = 7;
            lbBlue.Text = "Blue:";
            // 
            // lbOpacity
            // 
            lbOpacity.AutoSize = true;
            lbOpacity.Location = new Point(290, 267);
            lbOpacity.Name = "lbOpacity";
            lbOpacity.Size = new Size(51, 15);
            lbOpacity.TabIndex = 8;
            lbOpacity.Text = "Opacity:";
            // 
            // btnRandomColor
            // 
            btnRandomColor.Location = new Point(469, 330);
            btnRandomColor.Name = "btnRandomColor";
            btnRandomColor.Size = new Size(299, 44);
            btnRandomColor.TabIndex = 9;
            btnRandomColor.Text = "Losowy kolor";
            btnRandomColor.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 342);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(157, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(256, 342);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btnRandomColor);
            Controls.Add(lbOpacity);
            Controls.Add(lbBlue);
            Controls.Add(lbGreen);
            Controls.Add(lbRed);
            Controls.Add(panel1);
            Controls.Add(tbOpacity);
            Controls.Add(tbBlue);
            Controls.Add(tbGreen);
            Controls.Add(tbRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOpacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbRed;
        private TrackBar tbGreen;
        private TrackBar tbBlue;
        private TrackBar tbOpacity;
        private Panel panel1;
        private Label lbRed;
        private Label lbGreen;
        private Label lbBlue;
        private Label lbOpacity;
        private Button btnRandomColor;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

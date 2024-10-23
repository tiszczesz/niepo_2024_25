namespace cw11_listbox
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
            tbSize = new TextBox();
            lbNumbers = new ListBox();
            btnGener = new Button();
            label2 = new Label();
            lbSum = new Label();
            lbMax = new Label();
            label4 = new Label();
            lbMin = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Ilość elementów:";
            // 
            // tbSize
            // 
            tbSize.Location = new Point(134, 26);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(100, 23);
            tbSize.TabIndex = 1;
            // 
            // lbNumbers
            // 
            lbNumbers.FormattingEnabled = true;
            lbNumbers.ItemHeight = 15;
            lbNumbers.Location = new Point(22, 101);
            lbNumbers.Name = "lbNumbers";
            lbNumbers.Size = new Size(212, 559);
            lbNumbers.TabIndex = 2;
            // 
            // btnGener
            // 
            btnGener.Location = new Point(25, 58);
            btnGener.Name = "btnGener";
            btnGener.Size = new Size(209, 37);
            btnGener.TabIndex = 3;
            btnGener.Text = "Generuj";
            btnGener.UseVisualStyleBackColor = true;
            btnGener.Click += btnGener_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma liczb:";
            // 
            // lbSum
            // 
            lbSum.AutoSize = true;
            lbSum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbSum.ForeColor = SystemColors.HotTrack;
            lbSum.Location = new Point(340, 103);
            lbSum.Name = "lbSum";
            lbSum.Size = new Size(152, 25);
            lbSum.TabIndex = 5;
            lbSum.Text = "tu będzie wynik";
            // 
            // lbMax
            // 
            lbMax.AutoSize = true;
            lbMax.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbMax.ForeColor = SystemColors.HotTrack;
            lbMax.Location = new Point(340, 148);
            lbMax.Name = "lbMax";
            lbMax.Size = new Size(152, 25);
            lbMax.TabIndex = 7;
            lbMax.Text = "tu będzie wynik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 156);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 6;
            label4.Text = "Max:";
            // 
            // lbMin
            // 
            lbMin.AutoSize = true;
            lbMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbMin.ForeColor = SystemColors.HotTrack;
            lbMin.Location = new Point(340, 196);
            lbMin.Name = "lbMin";
            lbMin.Size = new Size(152, 25);
            lbMin.TabIndex = 9;
            lbMin.Text = "tu będzie wynik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 204);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 8;
            label6.Text = "Min:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 676);
            Controls.Add(lbMin);
            Controls.Add(label6);
            Controls.Add(lbMax);
            Controls.Add(label4);
            Controls.Add(lbSum);
            Controls.Add(label2);
            Controls.Add(btnGener);
            Controls.Add(lbNumbers);
            Controls.Add(tbSize);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbSize;
        private ListBox lbNumbers;
        private Button btnGener;
        private Label label2;
        private Label lbSum;
        private Label lbMax;
        private Label label4;
        private Label lbMin;
        private Label label6;
    }
}

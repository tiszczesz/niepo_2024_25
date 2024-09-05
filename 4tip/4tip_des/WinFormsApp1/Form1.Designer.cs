namespace WinFormsApp1
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
            label3 = new Label();
            label4 = new Label();
            tbTitle = new TextBox();
            tbAuthor = new TextBox();
            tbYear = new TextBox();
            tbPrice = new TextBox();
            btnDec = new Button();
            btnInc = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 34);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Tytuł";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 103);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 172);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Rok wydania";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 241);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Cena";
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbTitle.ForeColor = SystemColors.MenuHighlight;
            tbTitle.Location = new Point(159, 23);
            tbTitle.Name = "tbTitle";
            tbTitle.ReadOnly = true;
            tbTitle.Size = new Size(267, 33);
            tbTitle.TabIndex = 4;
            // 
            // tbAuthor
            // 
            tbAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbAuthor.ForeColor = SystemColors.MenuHighlight;
            tbAuthor.Location = new Point(159, 92);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.ReadOnly = true;
            tbAuthor.Size = new Size(267, 33);
            tbAuthor.TabIndex = 5;
            // 
            // tbYear
            // 
            tbYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbYear.ForeColor = SystemColors.MenuHighlight;
            tbYear.Location = new Point(159, 161);
            tbYear.Name = "tbYear";
            tbYear.ReadOnly = true;
            tbYear.Size = new Size(267, 33);
            tbYear.TabIndex = 6;
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbPrice.ForeColor = SystemColors.MenuHighlight;
            tbPrice.Location = new Point(159, 230);
            tbPrice.Name = "tbPrice";
            tbPrice.ReadOnly = true;
            tbPrice.Size = new Size(267, 33);
            tbPrice.TabIndex = 7;
            // 
            // btnDec
            // 
            btnDec.Enabled = false;
            btnDec.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnDec.Location = new Point(57, 335);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(75, 47);
            btnDec.TabIndex = 8;
            btnDec.Text = "<<";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += btnDec_Click;
            // 
            // btnInc
            // 
            btnInc.Enabled = false;
            btnInc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnInc.Location = new Point(181, 335);
            btnInc.Name = "btnInc";
            btnInc.Size = new Size(75, 47);
            btnInc.TabIndex = 9;
            btnInc.Text = ">>";
            btnInc.UseVisualStyleBackColor = true;
            btnInc.Click += btnInc_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(496, 19);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(211, 63);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Pobierz";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnInc);
            Controls.Add(btnDec);
            Controls.Add(tbPrice);
            Controls.Add(tbYear);
            Controls.Add(tbAuthor);
            Controls.Add(tbTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTitle;
        private TextBox tbAuthor;
        private TextBox tbYear;
        private TextBox tbPrice;
        private Button btnDec;
        private Button btnInc;
        private Button btnLoad;
    }
}

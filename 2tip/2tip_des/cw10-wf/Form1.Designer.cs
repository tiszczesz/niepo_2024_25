namespace cw10_wf
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
            lbResult = new Label();
            numA = new NumericUpDown();
            numB = new NumericUpDown();
            cbChoice = new ComboBox();
            btnRun = new Button();
            ((System.ComponentModel.ISupportInitialize)numA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(116, 34);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "A = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(116, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 1;
            label2.Text = "B = ";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbResult.ForeColor = SystemColors.MenuHighlight;
            lbResult.Location = new Point(186, 288);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(65, 25);
            lbResult.TabIndex = 2;
            lbResult.Text = "label3";
            // 
            // numA
            // 
            numA.Font = new Font("Segoe UI", 14.25F);
            numA.Location = new Point(171, 32);
            numA.Name = "numA";
            numA.Size = new Size(120, 33);
            numA.TabIndex = 3;
            // 
            // numB
            // 
            numB.Font = new Font("Segoe UI", 14.25F);
            numB.Location = new Point(169, 74);
            numB.Name = "numB";
            numB.Size = new Size(120, 33);
            numB.TabIndex = 4;
            // 
            // cbChoice
            // 
            cbChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChoice.Font = new Font("Segoe UI", 14.25F);
            cbChoice.FormattingEnabled = true;
            cbChoice.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbChoice.Location = new Point(169, 131);
            cbChoice.Name = "cbChoice";
            cbChoice.Size = new Size(120, 33);
            cbChoice.TabIndex = 5;
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.RosyBrown;
            btnRun.Font = new Font("Segoe UI", 14.25F);
            btnRun.Location = new Point(164, 193);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(127, 45);
            btnRun.TabIndex = 6;
            btnRun.Text = "Oblicz";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(450, 354);
            Controls.Add(btnRun);
            Controls.Add(cbChoice);
            Controls.Add(numB);
            Controls.Add(numA);
            Controls.Add(lbResult);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Okno główne";
            ((System.ComponentModel.ISupportInitialize)numA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbResult;
        private NumericUpDown numA;
        private NumericUpDown numB;
        private ComboBox cbChoice;
        private Button btnRun;
    }
}

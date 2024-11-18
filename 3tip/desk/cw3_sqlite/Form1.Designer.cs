namespace cw3_sqlite
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
            panel1 = new Panel();
            tbBirthDate = new TextBox();
            tbSpecies = new TextBox();
            tbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(tbBirthDate);
            panel1.Controls.Add(tbSpecies);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 450);
            panel1.TabIndex = 0;
            // 
            // tbBirthDate
            // 
            tbBirthDate.Location = new Point(145, 137);
            tbBirthDate.Name = "tbBirthDate";
            tbBirthDate.Size = new Size(100, 23);
            tbBirthDate.TabIndex = 5;
            // 
            // tbSpecies
            // 
            tbSpecies.Location = new Point(145, 82);
            tbSpecies.Name = "tbSpecies";
            tbSpecies.Size = new Size(100, 23);
            tbSpecies.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(145, 31);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Data urodzenia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Gatunek:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(352, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(448, 450);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbBirthDate;
        private TextBox tbSpecies;
        private TextBox tbName;
    }
}

namespace cw16_sqlite
{
    partial class AddProductform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            tbDescription = new TextBox();
            nudPrice = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 94);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Opis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 177);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // tbName
            // 
            tbName.Location = new Point(115, 46);
            tbName.Name = "tbName";
            tbName.Size = new Size(173, 23);
            tbName.TabIndex = 3;
            // 
            // tnbDescription
            // 
            tbDescription.Location = new Point(115, 91);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(173, 77);
            tbDescription.TabIndex = 4;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(115, 175);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(173, 23);
            nudPrice.TabIndex = 5;
            nudPrice.TabStop = false;
            nudPrice.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // btnSave
            // 
            btnSave.Location = new Point(31, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(180, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 33);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddProductform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 329);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nudPrice);
            Controls.Add(tbDescription);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddProductform";
            Text = "Dodaj produkt";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private TextBox tbDescription;
        private NumericUpDown nudPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}
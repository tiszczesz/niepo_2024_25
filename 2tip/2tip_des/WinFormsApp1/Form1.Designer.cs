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
            tbName = new TextBox();
            cbItems = new ComboBox();
            calDate = new MonthCalendar();
            btnShow = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(65, 42);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 0;
            // 
            // cbItems
            // 
            cbItems.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItems.FormattingEnabled = true;
            cbItems.Items.AddRange(new object[] { "Red", "Green", "Blue", "Yellow" });
            cbItems.Location = new Point(44, 95);
            cbItems.Name = "cbItems";
            cbItems.Size = new Size(121, 23);
            cbItems.TabIndex = 1;
            // 
            // calDate
            // 
            calDate.Location = new Point(18, 154);
            calDate.Name = "calDate";
            calDate.TabIndex = 2;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(33, 354);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(254, 48);
            btnShow.TabIndex = 3;
            btnShow.Text = "button1";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(calDate);
            Controls.Add(cbItems);
            Controls.Add(tbName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private ComboBox cbItems;
        private MonthCalendar calDate;
        private Button btnShow;
    }
}

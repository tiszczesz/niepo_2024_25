namespace winForms;

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
        tb1 = new TextBox();
        tb2 = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // tb1
        // 
        tb1.Location = new Point(395, 71);
        tb1.Name = "tb1";
        tb1.Size = new Size(100, 23);
        tb1.TabIndex = 0;
        // 
        // tb2
        // 
        tb2.Location = new Point(402, 144);
        tb2.Name = "tb2";
        tb2.Size = new Size(100, 23);
        tb2.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new Point(608, 106);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 2;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(tb2);
        Controls.Add(tb1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox tb1;
    private TextBox tb2;
    private Button button1;
}

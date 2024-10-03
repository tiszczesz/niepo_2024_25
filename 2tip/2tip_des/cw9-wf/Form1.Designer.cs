
namespace cw9_wf;

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
        pColor = new Panel();
        label2 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = Color.FromArgb(255, 255, 128);
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
        label1.ForeColor = Color.Purple;
        label1.Location = new Point(346, 58);
        label1.Name = "label1";
        label1.Size = new Size(100, 100);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // button1
        // 
        button1.Location = new Point(343, 12);
        button1.Name = "button1";
        button1.Size = new Size(103, 43);
        button1.TabIndex = 1;
        button1.Text = "Pokaż/Ukryj";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(49, 58);
        button2.Name = "button2";
        button2.Size = new Size(103, 43);
        button2.TabIndex = 2;
        button2.Text = "zmień kolor";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // pColor
        // 
        pColor.Location = new Point(32, 113);
        pColor.Name = "pColor";
        pColor.Size = new Size(151, 223);
        pColor.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(275, 91);
        label2.Name = "label2";
        label2.Size = new Size(0, 15);
        label2.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button2);
        Controls.Add(pColor);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

   

    #endregion

    private Label label1;
    private Button button1;
    private Button button2;
    private Panel pColor;
    private Label label2;
}

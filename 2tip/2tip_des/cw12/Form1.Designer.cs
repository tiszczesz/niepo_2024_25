namespace cw12;

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
        button3 = new Button();
        button2 = new Button();
        btnLoad = new Button();
        tbContent = new TextBox();
        openFileDialog1 = new OpenFileDialog();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(255, 255, 192);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(btnLoad);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 450);
        panel1.TabIndex = 0;
        // 
        // button3
        // 
        button3.Location = new Point(12, 136);
        button3.Name = "button3";
        button3.Size = new Size(166, 43);
        button3.TabIndex = 2;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Enabled = false;
        button2.Location = new Point(12, 74);
        button2.Name = "button2";
        button2.Size = new Size(166, 43);
        button2.TabIndex = 1;
        button2.Text = "Informacje o tekście";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // btnLoad
        // 
        btnLoad.Location = new Point(12, 12);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new Size(166, 43);
        btnLoad.TabIndex = 0;
        btnLoad.Text = "Wczytaj plik tekstowy";
        btnLoad.UseVisualStyleBackColor = true;
        btnLoad.Click += btnLoad_Click;
        // 
        // tbContent
        // 
        tbContent.Dock = DockStyle.Fill;
        tbContent.Location = new Point(200, 0);
        tbContent.Multiline = true;
        tbContent.Name = "tbContent";
        tbContent.Size = new Size(600, 450);
        tbContent.TabIndex = 1;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        openFileDialog1.Filter = "pliki tekstow|*.txt|wszystkie pliki|*.*";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tbContent);
        Controls.Add(panel1);
        MinimumSize = new Size(500, 300);
        Name = "Form1";
        Text = "Form1";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private TextBox tbContent;
    private Button button3;
    private Button button2;
    private Button btnLoad;
    private OpenFileDialog openFileDialog1;
}

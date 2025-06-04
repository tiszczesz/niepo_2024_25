namespace cwXX_tab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetTab();

        }
        private void SetTab()
        {
            

            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(100, 130); // szerokość, wysokość

            tabControl1.DrawItem += (s, e) =>
            {
                Graphics g = e.Graphics;
                TabPage tabPage = tabControl1.TabPages[e.Index];
                Rectangle tabBounds = tabControl1.GetTabRect(e.Index);

                // Rysowanie tła
                g.FillRectangle(SystemBrushes.Control, tabBounds);

                // Rysowanie tekstu poziomo
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(tabPage.Text, tabControl1.Font, Brushes.Black, tabBounds, sf);
                }
            };

            tabControl1.SelectedIndex = 0;
        }
    }
}

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(this);// Create an instance of Form2
            form2.ShowDialog();// Show Form2 as Dialog
        }
        public TextBox GetName() {
            return tbName;
        }
        public ComboBox GetItems() {
            return cbItems;
        }
        public MonthCalendar GetDate()
        {
            return calDate;
        }
    }
}

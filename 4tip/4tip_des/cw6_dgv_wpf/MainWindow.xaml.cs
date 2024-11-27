using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cw6_dgv_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<DataItem> DataItems { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataItems = new ObservableCollection<DataItem>();
            DataGrid1.ItemsSource = DataItems;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Create a new TextColumn
            DataGridTextColumn textColumn = new DataGridTextColumn();
            textColumn.Header = "Text Column";
            textColumn.Binding = new Binding("TextProperty");

            // Create a new CheckBoxColumn
            DataGridCheckBoxColumn checkBoxColumn = new DataGridCheckBoxColumn();
            checkBoxColumn.Header = "CheckBox Column";
            checkBoxColumn.Binding = new Binding("CheckBoxProperty");

            // Add columns to DataGrid
           // DataGrid1.Columns.Add(textColumn);
           // DataGrid1.Columns.Add(checkBoxColumn);
            DataItems.Add(new DataItem { TextProperty = "Sample Tex1t", CheckBoxProperty = true });
            DataItems.Add(new DataItem { TextProperty = "Sample Text2", CheckBoxProperty = false });
            DataItems.Add(new DataItem { TextProperty = "Sample Text3", CheckBoxProperty = true });
        }

        private void Button_OnClick(object sender, RoutedEventArgs e) {
            new SecondWindow().ShowDialog();
        }
    }
}
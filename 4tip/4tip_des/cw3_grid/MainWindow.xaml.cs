using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cw3_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
            MessageBox.Show("Hello");
        }

        private void TbA_OnPreviewTextInput(object sender, TextCompositionEventArgs e) {
            e.Handled = IsTextAllowed(e.Text);
        }
        private bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]+"); // Tylko cyfry
            return regex.IsMatch(text);
        }
    }
}
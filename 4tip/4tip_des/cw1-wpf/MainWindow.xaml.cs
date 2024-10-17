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

namespace cw1_wpf
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
            try {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                
                
                if (cbChoice.SelectedIndex == 0) {
                    int result = Models.Nwd.NwdRec(a, b);
                    lbResult.Content = $"Rekurencyjnie NWD({a},{b}) = " 
                                       + result.ToString();
                }
                else {
                    int result = Models.Nwd.NwdIter(a, b);
                    lbResult.Content = $"Iteracyjniee NWD({a},{b}) = " 
                                       + result.ToString();
                }
                
            }
            catch (FormatException ex) {
               MessageBox.Show("Podaj poprawne liczby");
            }
            
        }
    }
}
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

namespace cw5_binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private int _boundNumber;
        public int BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                _boundNumber = value;
                info.Content = _boundNumber;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged ;

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Reset_OnClick(object sender, RoutedEventArgs e) {
           
            BoundNumber = 0; 
            MessageBox.Show(BoundNumber.ToString());
        }
    }
}
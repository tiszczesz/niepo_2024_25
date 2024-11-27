using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cw6_dgv_wpf
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public ObservableCollection<DataItem> DataItems { get; set; }
        public SecondWindow()
        {
            InitializeComponent();
            DataItems = new ObservableCollection<DataItem>
            {
                new DataItem { TextProperty = "Sample Text1", CheckBoxProperty = true },
                new DataItem { TextProperty = "Sample Text2", CheckBoxProperty = false },
                new DataItem { TextProperty = "Sample Text3", CheckBoxProperty = true },
                new DataItem { TextProperty = "Sample Text4", CheckBoxProperty = false },
                new DataItem { TextProperty = "Sample Text5", CheckBoxProperty = false },
                new DataItem { TextProperty = "Sample Text6", CheckBoxProperty = true }
            };
            DataContext = this;
        }

       
    }
}

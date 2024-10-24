using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using cw3_grid.Models;

namespace cw3_grid;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
        //MessageBox.Show("Hello");
        try {
            var a = Convert.ToInt32(tbA.Text);
            var b = Convert.ToInt32(tbB.Text);
            var result = Nwd.Run(a, b);
            lbResult.Content = $"NWD({a},{b}) = {result.ToString()}";
        }
        catch (FormatException ex) {
            MessageBox.Show("Podaj liczby całkowite");
        }
    }

    private void TbA_OnPreviewTextInput(object sender, TextCompositionEventArgs e) {
        e.Handled = IsTextAllowed(e.Text);
    }

    private bool IsTextAllowed(string text) {
        var regex = new Regex("[^0-9]+"); // Tylko cyfry
        return regex.IsMatch(text);
    }
}
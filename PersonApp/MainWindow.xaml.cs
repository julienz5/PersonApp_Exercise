using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PersonApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> data = new List<string>();
            data.Add("M");
            data.Add("F");
            Sexe.ItemsSource = data;
            Sexe.SelectedIndex = 0;
        }

        private void Sexe_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string selected = e.AddedItems[0] as string;
        }

    }
}

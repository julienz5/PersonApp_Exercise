using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

            List<string> myList = new List<string>();
            myList.Add("M");
            myList.Add("F");
            Sexe.ItemsSource = myList;
            Sexe.SelectedIndex = 0;

            ImgPerson.Source = null;// GetImage("");
        }

        private void Sexe_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string selected = e.AddedItems[0] as string;
            
        }

        private void textbox1_click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Prénom.Text = "";
        }

        private ImageSource GetImage(string name)
        {
            return new BitmapImage(new Uri("pack://application:,,,/PersonApp;component/Resources/" + name));
        }
    }
}

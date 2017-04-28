using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace PersonApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string sexeSelect;
 
        public MainWindow()
        {
            InitializeComponent();

            var myList = new List<string>();
            myList.Add("M");
            myList.Add("F");
            Sexe.ItemsSource = myList;
            Sexe.SelectedIndex = 0;
            ImgPerson.Source = null;// GetImage("");
        }
 
   
        // click champs vides
        private void TextBox_click(object sender, MouseButtonEventArgs e)
        {
            var textbox = (TextBox)sender;
            switch (textbox.Name)
            {
                case "Prénom":
                    Prénom.Text = "";
                    break;
                case "Age":
                    Age.Text = "";
                    break;
            }
        }
        
        //récup sexe
        public void Sexe_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            sexeSelect = e.AddedItems[0] as string;
            if (ImgPerson != null)
                ImgPerson.Source = GetImage();
        }

        private ImageSource GetImage()
        {
            if (string.IsNullOrEmpty(Age?.Text) || Age.Text == "Age")
                return null;

            int agePerson;
            bool success = Int32.TryParse(Age.Text, out agePerson);
            if (!success)
            {
                Age.BorderBrush = Brushes.IndianRed;
                return null;
            }

            Age.BorderBrush = Brushes.Black;
            string name = null;

            if (agePerson <= 3)
            {
                name = "silhouette_bébé.png";
            }
            else if (agePerson > 3)
            {
                if (sexeSelect == "M")
                {
                    name = "silhouette_homme.jpg";
                }
                if (sexeSelect == "F")
                {
                    name = "silhouette_femme.jpg";
                }
            }

            if (name == null)
                return null;
            return new BitmapImage(new Uri("pack://application:,,,/PersonApp;component/Resources/" + name));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ImgPerson != null)
                ImgPerson.Source = GetImage();
        }
    }
}

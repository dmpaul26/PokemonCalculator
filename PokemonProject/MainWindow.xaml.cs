using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace PokemonProject
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!File.Exists(pathTextBox.Text))
            {
                ErrorLabel.Content = "ERROR: Invalid file name.";
                return;
            }
            DamageWindow dmg = new DamageWindow(pathTextBox.Text, getNames(pathTextBox.Text));
            dmg.Show();
            Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if(!File.Exists(pathTextBox.Text))
            {
                ErrorLabel.Content = "ERROR: Invalid file name.";
                return;
            }
            CaptureWindow cap = new CaptureWindow(pathTextBox.Text, getNames(pathTextBox.Text));
            cap.Show();
            Close();
        }

        private List<string> getNames(string path)
        {
            TextFieldParser parser = new TextFieldParser(path);

            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            parser.TrimWhiteSpace = true;

            List<string> names = new List<string>();

            bool firstline = true;
            while (!parser.EndOfData)
            {
                string[] fieldRow = parser.ReadFields();

                if (firstline)
                {
                    firstline = false;
                    continue;
                }

                names.Add(fieldRow[1]);
            }

            return names;

        }
    }
}

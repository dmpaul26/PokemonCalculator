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
using System.Windows.Shapes;
using Microsoft.VisualBasic.FileIO;

namespace PokemonProject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DamageWindow : Window
    {
        List<string> namesList;
        string filePath;
        public DamageWindow(string path, List<string> pokemonList)
        {
            InitializeComponent();
            filePath = path;
            namesList = pokemonList;
            Pokemon1.ItemsSource = namesList;
            Pokemon2.ItemsSource = namesList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pokemon pokemon1 = new Pokemon(), pokemon2 = new Pokemon();
            TextFieldParser parser = new TextFieldParser(filePath);

            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            parser.TrimWhiteSpace = true;

            bool firstline = true;
            while (!parser.EndOfData)
            {
                string[] fieldRow = parser.ReadFields();

                if (firstline)
                {
                    firstline = false;
                    continue;
                }

                if(fieldRow[1] == Pokemon1.Text)
                {
                    pokemon1 = new Pokemon(fieldRow);
                }

                if(fieldRow[1] == Pokemon2.Text)
                {
                    pokemon2 = new Pokemon(fieldRow);
                }
            }

            pokemon1.UpdateStats();
            pokemon2.UpdateStats();

            pokemon1.Attack(pokemon2);
        }
    }
}

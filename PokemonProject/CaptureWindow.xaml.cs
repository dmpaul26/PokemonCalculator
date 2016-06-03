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

namespace PokemonProject
{
    /// <summary>
    /// Interaction logic for CaptureWindow.xaml
    /// </summary>
    public partial class CaptureWindow : Window
    {
        List<string> namesList;
        string filePath;
        public CaptureWindow(string path, List<string> pokemonList)
        {
            InitializeComponent();
            filePath = path;
            namesList = pokemonList;
        }
    }
}

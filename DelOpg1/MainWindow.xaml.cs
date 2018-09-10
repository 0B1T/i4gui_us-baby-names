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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace DelOpg1
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

        void OnLoad(object sender, RoutedEventArgs ea)
        {
            string filename = @"05-babynames.txt";

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    // Reads the 10 first lines from the file and outputs them in the ListBox.
                    for (int i = 0; i < 10; ++i)
                        firstDecadeTopNames.Items.Add(sr.ReadLine());
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.Write("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}

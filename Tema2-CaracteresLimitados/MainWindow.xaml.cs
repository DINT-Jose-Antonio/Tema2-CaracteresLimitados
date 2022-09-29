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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void CuadroTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ContadorTextBlock.Text = CuadroTextBox.Text.Length.ToString() + "/140";
            if (ContadorTextBlock.Text == "140/140")
            {
                CuadroTextBox.IsReadOnly = true;
            }
        }
    }
}

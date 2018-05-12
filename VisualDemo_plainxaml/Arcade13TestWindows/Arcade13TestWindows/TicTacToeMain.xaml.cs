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

namespace Arcade13TestWindows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class TicTacToeMain : Window
    {
        public TicTacToeMain()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            TicTacToeGame x = new TicTacToeGame();
            x.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            GameList x = new GameList();
            x.Show();
            this.Close();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            GameList x = new GameList();
            x.Show();
            this.Close();
        }
        private void Trophy_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}

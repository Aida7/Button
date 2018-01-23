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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mouse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clik_Mouse(object sender, MouseEventArgs e)
        {
            int maxLeft = Convert.ToInt32(grid.ActualWidth - clik.Width);
            int maxTop = Convert.ToInt32(grid.ActualHeight - clik.Height);
            Random rand = new Random();
            clik.Margin = new Thickness(rand.Next(maxLeft), rand.Next(maxTop), 0, 0);
        }
       
    }
    }

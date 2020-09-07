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

namespace MoskalButton
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

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random randX = new Random();
            Random randX1 = new Random();
            Random randY = new Random();
            Random randY1 = new Random();

            double valueX = randX.Next(0, 450);
            double valueY = randY.Next(0, 300);
            double valueX1 = randX.Next(0, 450);
            double valueY1 = randY.Next(0, 300);

            Canvas.SetLeft(Moskal, valueX);
            Canvas.SetRight(Moskal, valueY);
            Canvas.SetTop(Moskal, valueX1);
            Canvas.SetBottom(Moskal, valueY1);
        }
    }
}

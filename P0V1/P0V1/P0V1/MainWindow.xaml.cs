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
using System.Windows.Media.Animation;

namespace P0V1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int stage = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (stage == 0)
            {
                Storyboard sb = this.FindResource("Storyboard1") as Storyboard;
                //Storyboard.SetTarget(sb, this.Button1);
                sb.Begin();
            }
            if (stage == 1)
            {
                Storyboard sb = this.FindResource("Storyboard2") as Storyboard;
                //Storyboard.SetTarget(sb, this.Button1);
                sb.Begin();
            }
            if (stage == 2)
            {
                Storyboard sb = this.FindResource("Storyboard3") as Storyboard;
                //Storyboard.SetTarget(sb, this.Button1);
                sb.Begin();
            }
            if (stage == 3)
            {
                Storyboard sb = this.FindResource("Storyboard4") as Storyboard;
                //Storyboard.SetTarget(sb, this.Button1);
                sb.Begin();
                
            }

            stage++;
            if (stage == 4)
            {
                stage = 0;
            }
        }
    }
}

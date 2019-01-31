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
        string[] images = { "Bedroom1.jpg", "Estate1.jpg", "Golf2.jpg", "Hotel1.jpg", "Newsroom1.jpg", "Plane.jpg", "Podium1.png" };
        string ourImage = "Bedroom1.jpg";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            Background.Source = new BitmapImage(new Uri(@"C:\Users\user\Documents\GitHub\CPSC581Project0\P0V1\P0V1\P0V1\" + ourImage));
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
            if (stage == 4 ) 
            {
                stage = 0;
                if (ourImage != "Podium1.png")
                {
                    ourImage = images[Array.IndexOf(images, ourImage) + 1];

                }
                else
                {
                    ourImage = images[0];
                    Console.WriteLine(ourImage);

                }
            }
        }
    }
}
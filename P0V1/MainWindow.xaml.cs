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
        int sbTrumpHairCounter = 0;
        int backgroundCounter = 1;
        String[] sbTrumpHair;
        String[] backgroundList;


        public MainWindow()
        {
            InitializeComponent();
            sbTrumpHair = new string[]{"sbTrumpHair1", "sbTrumpHair2", "sbTrumpHair3", "sbTrumpHair4" };

            backgroundList = new string[] { "golf1.jpg", "Hotel3.jpg", "Wall2.jpg"};
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (sbTrumpHairCounter < sbTrumpHair.Length)
            {
                Storyboard sb = this.FindResource(sbTrumpHair[sbTrumpHairCounter]) as Storyboard;
                sb.Begin();
            }
           
            sbTrumpHairCounter++;

            if (sbTrumpHairCounter > sbTrumpHair.Length)
            {
                sbTrumpHairCounter = 0;

                Background1.Source = new BitmapImage(new Uri(backgroundList[backgroundCounter], UriKind.Relative));
                if (backgroundCounter >= 0)
                {
                    Golfball.Visibility = Visibility.Collapsed;
                }
                else
                {
                    Golfball.Visibility = Visibility.Visible;
                }

                backgroundCounter++;
                if (backgroundCounter >= backgroundList.Length)
                {
                    backgroundCounter = 0;
                }
            }

        }
    }
}

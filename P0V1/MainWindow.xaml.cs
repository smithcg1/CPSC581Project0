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
using System.Diagnostics;

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
        int brickcounter = 0;


        public MainWindow()
        {
            InitializeComponent();
            sbTrumpHair = new string[]{"sbTrumpHair1", "sbTrumpHair2", "sbTrumpHair3", "sbTrumpHair4" };

            backgroundList = new string[] {"Bedroom1.jpg", "Golf1.jpg", "Hotel3.jpg", "Desert1.jpg", "Podium1.png", "Estate1.jpg", "Estate3.jpg", "miss_universe1.jpg"};
        }

        private void irs_botton_clicked(object sender, RoutedEventArgs e)
        {
            Storyboard sb1 = this.FindResource("sbclosedsign") as Storyboard;
            sb1.Begin();
            Debug.WriteLine("IRS VISIBLE");

        }


        private void constructionButton_clicked(object sender, RoutedEventArgs e)
        {
            if(brickcounter == 1) {
                brick1.Visibility = Visibility.Visible;
            }
            if (brickcounter == 2)
            {
                brick2.Visibility = Visibility.Visible;
            }
            if (brickcounter == 3)
            {
                brick3.Visibility = Visibility.Visible;
            }
            if (brickcounter == 4)
            {
                brick4.Visibility = Visibility.Visible;
            }
            if (brickcounter == 5)
            {
                brick5.Visibility = Visibility.Visible;
            }
            if (brickcounter == 6)
            {
                brick5.Visibility = Visibility.Collapsed;
            }
            if (brickcounter == 7)
            {
                brick4.Visibility = Visibility.Collapsed;
            }
            if (brickcounter == 8)
            {
                brick3.Visibility = Visibility.Collapsed;
            }
            if (brickcounter == 9)
            {
                brick2.Visibility = Visibility.Collapsed;
            }
            if (brickcounter == 10)
            {
                brick1.Visibility = Visibility.Collapsed;
                brickcounter = 0;
            }
            brickcounter++;

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

                Debug.WriteLine(backgroundCounter);
                Background1.Source = new BitmapImage(new Uri(backgroundList[backgroundCounter], UriKind.Relative));
                if (backgroundCounter >= 0)
                {
                    Golfball.Visibility = Visibility.Collapsed;
                    speachbubble1.Visibility = Visibility.Collapsed;


                }
                if (backgroundCounter == 1)
                {
                    Debug.WriteLine("IRS SIGN SHOULD BE VISIBLE");

                    Golfball.Visibility = Visibility.Visible;
                    speachbubble3.Visibility = Visibility.Visible;

                }

                if (backgroundCounter == 2)
                {
                    closedsign.Visibility = Visibility.Visible;
                    constructionButton.Visibility = Visibility.Visible;
                    
                    closedsign.Visibility = Visibility.Collapsed;
                    speachbubble1.Visibility = Visibility.Visible;

                }

                if(backgroundCounter == 4)
                {
                    IRS.Visibility = Visibility.Visible;
                    twitter.Visibility = Visibility.Visible;
                }

                else
                {
                    //these two can stay visible
                   
                    speachbubble1.Visibility = Visibility.Visible;
                    constructionButton.Visibility = Visibility.Collapsed;
  




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

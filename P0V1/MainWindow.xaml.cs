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

                //Hide all interactables
                 Paper.Visibility = Visibility.Collapsed;
                 Golfball.Visibility = Visibility.Collapsed;
                travellers.Visibility = Visibility.Collapsed;
            
                Brick1.Visibility = Visibility.Collapsed;
                Brick2.Visibility = Visibility.Collapsed;
                Brick3.Visibility = Visibility.Collapsed;
                Brick4.Visibility = Visibility.Collapsed;
                Brick5.Visibility = Visibility.Collapsed;
                Brick6.Visibility = Visibility.Collapsed;
                Brick7.Visibility = Visibility.Collapsed;

                IRS.Visibility = Visibility.Collapsed;
                twitter.Visibility = Visibility.Collapsed;
                plane.Visibility = Visibility.Collapsed;
                respectwomen.Visibility = Visibility.Collapsed;
                Fired.Visibility = Visibility.Collapsed;
                meatLoaf.Visibility = Visibility.Collapsed;

                //Show interactables for current scene
                switch (backgroundList[backgroundCounter])
                {
                    case "Bedroom1.jpg":
                        Paper.Visibility = Visibility.Visible;
                        break;
                    case "Golf1.jpg":
                        Golfball.Visibility = Visibility.Visible;
                        break;
                    case "Hotel3.jpg":
                        travellers.Visibility = Visibility.Visible;
                        break;
                    case "Desert1.jpg":
                        Brick1.Visibility = Visibility.Visible;
                        Brick2.Visibility = Visibility.Visible;
                        Brick3.Visibility = Visibility.Visible;
                        Brick4.Visibility = Visibility.Visible;
                        Brick5.Visibility = Visibility.Visible;
                        Brick6.Visibility = Visibility.Visible;
                        Brick7.Visibility = Visibility.Visible;
                        break;
                    case "Podium1.png":
                        IRS.Visibility = Visibility.Visible;
                        twitter.Visibility = Visibility.Visible;
                        break;
                    case "Estate1.jpg":
                        plane.Visibility = Visibility.Visible;
                        break;
                    case "Estate3.jpg":
                        meatLoaf.Visibility = Visibility.Visible;
                        Fired.Visibility = Visibility.Visible;
                        break;
                    case "miss_universe1.jpg":
                        respectwomen.Visibility = Visibility.Visible;
                        break;
                }



                backgroundCounter = (backgroundCounter + 1) % backgroundList.Length;        //Increment counter and loop if at last entry
            }

        }
    }
}

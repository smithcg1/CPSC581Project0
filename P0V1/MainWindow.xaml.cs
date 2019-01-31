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
        int stageCounter = 0;
        int backgroundCounter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String storyboardRef = "";
            if (stageCounter == 0){storyboardRef = "Storyboard1";}
            else if (stageCounter == 1) { storyboardRef = "Storyboard2";}
            else if (stageCounter == 2) { storyboardRef = "Storyboard3"; }
            else if (stageCounter == 3) { storyboardRef = "Storyboard4"; }

            Storyboard sb = this.FindResource(storyboardRef) as Storyboard;
            sb.Begin();

            stageCounter++;
            if (stageCounter == 4)
            {
                stageCounter = 0;

                String imageFileName = "";
                if(backgroundCounter == 0){ imageFileName = "golf_course.jpg"; }
                else if (backgroundCounter == 1) { imageFileName = "Hotel3.jpg"; }
                else if (backgroundCounter == 2) { imageFileName = "Wall2.jpg"; }
                else if (backgroundCounter == 3) { imageFileName = "Hotel3.jpg"; }

                Background1.Source = new BitmapImage(new Uri(imageFileName, UriKind.Relative));

                backgroundCounter++;
                if(backgroundCounter > 3) { backgroundCounter = 0; }
            }
        }
    }
}

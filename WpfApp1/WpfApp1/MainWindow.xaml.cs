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
using System.Windows.Threading;
using System.Diagnostics;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 1;

        private int seconds; 
                private DispatcherTimer timer;

        public MainWindow()
        {



            InitializeComponent();

            Button btn = new Button();
            btn.Name = "btn1";
            btn.Click += btn1_Click;





           // timer = new DispatcherTimer();
            //timer.Tick += Timer_Tick;
            //timer.Interval = System.TimeSpan.FromMilliseconds(1000);
            //timer.Start();


            DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();


        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {


            var CurrentDateTime = System.DateTime.Now;


            lblSeconds.Content = CurrentDateTime;


            if (CurrentDateTime.Hour > 12 && CurrentDateTime.Hour < 14)
            {
                lblSeconds.Content = "some time in the afternoon";

                Debug.WriteLine("some time in the afternoon");


            }


        }

        public void btn1_Click(object sender, RoutedEventArgs e)
        {
            tbSettingText.Text = "of trump";
            if (DateTime.Now.Hour > 12 && System.DateTime.Now.Hour < 15)
            {
                if (count == 1)
                {
                    lblSeconds.Content = "LETS BUILD A WALL";
               
                    brick1.Visibility = Visibility.Visible;
                }

                if (count == 2)
                {
                    lblSeconds.Content = "LETS BUILD A WALL";

                    brick3.Visibility = Visibility.Visible;
                }
                if (count == 3)
                {
                    lblSeconds.Content = "LETS BUILD A WALL";

                    brick4.Visibility = Visibility.Visible;
                }
                if (count == 4)
                {
                    lblSeconds.Content = "LETS BUILD A WALL";

                    brick5.Visibility = Visibility.Visible;
                }
            }

            count++;
            Debug.WriteLine(count);



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblSeconds.Content = "" + seconds++;}


        }









    }

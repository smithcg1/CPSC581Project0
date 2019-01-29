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

namespace WpfApp1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int seconds; 
                private DispatcherTimer timer;

        public MainWindow()
        {

            InitializeComponent();

            Button btn = new Button();
            btn.Name = "btn1";
            btn.Click += btn1_Click;





            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = System.TimeSpan.FromMilliseconds(1000);
            timer.Start();
        }
        public void btn1_Click(object sender, RoutedEventArgs e)
        {
            tbSettingText.Text = "of trump";
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lblSeconds.Content = "" + seconds++;}


        }






    }

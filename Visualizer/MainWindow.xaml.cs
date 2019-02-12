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

namespace Visualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer soundTrack;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpenSound_Click(object sender, RoutedEventArgs e)
        {
            soundTrack = new MediaPlayer();
            Uri uri = new Uri(@"C:\Users\Pénzesné Tóth Márta\Downloads\SugarCoatedShit.wav");
            soundTrack.Open(uri);
            soundTrack.Play();
        }
    }
}

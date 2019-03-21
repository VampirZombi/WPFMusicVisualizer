using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using NAudio;
using WPFSoundVisualizationLib;

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

            NAudioEngine soundEngine = NAudioEngine.Instance;
            soundEngine.PropertyChanged += SoundEngine_PropertyChanged;

            //UIHelper.Bind(soundEngine, "CanStop", StopButton, Button.IsEnabledProperty);
            //UIHelper.Bind(soundEngine, "CanPlay", PlayButton, Button.IsEnabledProperty);
            //UIHelper.Bind(soundEngine, "CanPause", PauseButton, Button.IsEnabledProperty);
            //UIHelper.Bind(soundEngine, "SelectionBegin", repeatStartTimeEdit, TimeEditor.ValueProperty, BindingMode.TwoWay);
            //UIHelper.Bind(soundEngine, "SelectionEnd", repeatStopTimeEdit, TimeEditor.ValueProperty, BindingMode.TwoWay);

            spectrumAnalyzer.RegisterSoundPlayer(soundEngine);
            //waveformTimeline.RegisterSoundPlayer(soundEngine);

            //LoadExpressionDarkTheme();
        }

        private void SoundEngine_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void BtnOpenSound_Click(object sender, RoutedEventArgs e)
        {
            soundTrack = new MediaPlayer();
            string uri;
            Microsoft.Win32.OpenFileDialog openDialog = new Microsoft.Win32.OpenFileDialog();
            openDialog.Filter = "(*.mp3)|*.mp3";
            if (openDialog.ShowDialog() == true)
            {
                NAudioEngine.Instance.OpenFile(openDialog.FileName);
                this.Title = openDialog.FileName;
            }

        }
    }
}

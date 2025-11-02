using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace SigmaAudioHelper
{
    public partial class MainForm : Form
    {
        private MMDevice _micro = new MMDeviceEnumerator().GetDefaultAudioEndpoint
                    (DataFlow.Capture, Role.Communications);

        private bool _buttonIsOptimized = false;
        private bool _isMuted;
        
        public MainForm()
        {
            InitializeComponent();

            _isMuted = _micro.AudioEndpointVolume.Mute;

            buttonMuteMic.Text = _isMuted ? "Вкл. микрофон" : "Замутиться";

            pictureMicProperty.Image = _isMuted 
                ? Properties.Resources.micOff 
                : Properties.Resources.micOn;

            pictureMicFix.Image = Properties.Resources.mudriyDub;
        }

        private async void buttonFixMic_Click(object sender, EventArgs e)
        {
            if (!_buttonIsOptimized)
            {
                buttonFixMic.Text = "Фиксатор включен";
                _buttonIsOptimized = true;
                pictureMicFix.Image = Properties.Resources.sigma;

                while (_buttonIsOptimized && !_isMuted)
                {
                    try
                    {
                        if (_micro.AudioEndpointVolume.MasterVolumeLevelScalar != 1.0f)
                        {
                            _micro.AudioEndpointVolume.MasterVolumeLevelScalar = 1.0f;
                        }
                    }
                    catch { /* если устройство пропало, то ничего страшного */ }

                    await Task.Delay(30000);
                }
            }

            else if (_buttonIsOptimized)
            {
                buttonFixMic.Text = "Фиксировать уровень микрофона";
                _buttonIsOptimized = false;
                pictureMicFix.Image = Properties.Resources.mudriyDub;
            }
        }

        private void buttonMuteMic_Click(object sender, EventArgs e)
        {
            if (!_isMuted)
            {
                _micro.AudioEndpointVolume.Mute = true;
                _isMuted = true;
                buttonMuteMic.Text = "Вкл. микрофон";
                pictureMicProperty.Image = Properties.Resources.micOff;
            }
            else if (_isMuted)
            {
                _micro.AudioEndpointVolume.Mute = false;
                _isMuted = false;
                buttonMuteMic.Text = "Замутиться";
                pictureMicProperty.Image = Properties.Resources.micOn;
            }
        }
    }
}

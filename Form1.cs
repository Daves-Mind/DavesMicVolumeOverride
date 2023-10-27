using NAudio.CoreAudioApi;

namespace WinMicReset
{
    public partial class Form1 : Form
    {
        static float volume = 0.5f;
        static bool updatevolume = false;
        static bool muted = false;
        public Form1()
        {
            InitializeComponent();

            var enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();


            Console.WriteLine($"Monitoring microphone levels...");
            foreach (var device in devices)
            {
                device.AudioEndpointVolume.OnVolumeNotification += (data) =>
                {
                    if (data.MasterVolume != volume && updatevolume)
                    {
                        // Console.WriteLine($"{DateTime.Now} Microphone {device.FriendlyName} level changed to {data.MasterVolume * 100}%. Resetting to {volume * 100}%...");
                        device.AudioEndpointVolume.MasterVolumeLevelScalar = volume;
                    }
                };
            }

        }

        private void TurnOn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                updatevolume = true;

                setvolume();

            }
            else
            {
                updatevolume = false;
            }
        }

        private void MicGain_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            if (trackBar != null)
            {
                volume = trackBar.Value / 100f;
                setvolume();
            }
        }
        private void setvolume()
        {
            if (updatevolume && !muted)
            {
                var enumerator = new MMDeviceEnumerator();
                var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();

                Console.WriteLine($"Setting all microphone levels to {volume * 100}%...");
                foreach (var device in devices)
                {
                    device.AudioEndpointVolume.MasterVolumeLevelScalar = volume;
                }
            }

        }

        private void Mute_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {

                volume = 0;
                setvolume();
                muted = true;
            }
            else
            {
                volume = MicGain.Value / 100f;
            }
        }

    }
}
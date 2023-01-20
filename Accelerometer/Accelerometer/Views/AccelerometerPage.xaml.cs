using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Accelerometer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccelerometerPage : ContentPage
    {
        SensorSpeed speed = SensorSpeed.UI;
        public AccelerometerPage()
        {
            InitializeComponent();
            Xamarin.Essentials.Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
            Xamarin.Essentials.Accelerometer.Start(speed);


        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => {
                var data = e.Reading;
                ReadingsText.Text = $"Reading: X: {data.Acceleration.X}, Y: {data.Acceleration.Y}, Z: {data.Acceleration.Z}";
            });
        }

        private void MonitorSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (Xamarin.Essentials.Accelerometer.IsMonitoring)
                Xamarin.Essentials.Accelerometer.Stop();
            else
                Xamarin.Essentials.Accelerometer.Start(speed);
        }
    }
}
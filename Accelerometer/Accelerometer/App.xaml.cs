using Accelerometer.Services;
using Accelerometer.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Accelerometer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Views.AccelerometerPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using Accelerometer.ViewModels;
using Accelerometer.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Accelerometer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

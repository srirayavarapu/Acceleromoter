using Accelerometer.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Accelerometer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
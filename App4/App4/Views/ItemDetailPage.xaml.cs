using System.ComponentModel;
using Xamarin.Forms;
using App4.ViewModels;

namespace App4.Views
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
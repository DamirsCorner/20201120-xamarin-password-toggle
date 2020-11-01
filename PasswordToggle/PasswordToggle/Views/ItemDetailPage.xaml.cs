using System.ComponentModel;
using Xamarin.Forms;
using PasswordToggle.ViewModels;

namespace PasswordToggle.Views
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
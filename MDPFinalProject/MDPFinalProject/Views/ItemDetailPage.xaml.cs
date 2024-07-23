using MDPFinalProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MDPFinalProject.Views
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
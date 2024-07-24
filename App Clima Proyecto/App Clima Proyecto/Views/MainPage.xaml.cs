using App_Clima_Proyecto.ViewModels;
using Xamarin.Forms;

namespace App_Clima_Proyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}

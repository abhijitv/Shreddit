using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using Shreddit.ViewModels;
using Shreddit.Views;


namespace Shreddit
{
    public partial class MainPage : ContentPage
    {

        public MainVm _mainVM { get; set; }
        public MainPage()
        {
            InitializeComponent();
            _mainVM = new MainVm();
            this.BindingContext = _mainVM;
           

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnShowMe_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyDietHistory());
        }
    }
}

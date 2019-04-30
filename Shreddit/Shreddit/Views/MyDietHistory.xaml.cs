using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shreddit.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shreddit.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyDietHistory : ContentPage
	{
        
        public MyDietHistory ()
		{
			InitializeComponent ();
            MyDietHistoryVM viewmodel = new MyDietHistoryVM();
            this.BindingContext = viewmodel;
            this.lsvDietHistory.ItemsSource = viewmodel.MyDietHistory;
        }
	}
}
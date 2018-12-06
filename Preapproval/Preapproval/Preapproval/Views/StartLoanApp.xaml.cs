using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Preapproval.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartLoanApp : ContentPage
	{
		public StartLoanApp ()
		{
			InitializeComponent();
		}

        private async void StartLoanApp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new PersonalPage()));
        }
    }
}
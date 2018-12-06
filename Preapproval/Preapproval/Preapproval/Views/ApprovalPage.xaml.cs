using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Preapproval.Models;
using Preapproval.ViewModels;

namespace Preapproval.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApprovalPage : ContentPage
    {
        PersonalViewModel _viewModel;

        public ApprovalPage(PersonalViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        private async void Done_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
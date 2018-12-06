using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Preapproval.Models;
using Preapproval.ViewModels;

namespace Preapproval.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalPage : ContentPage
    {
        PersonalViewModel viewModel;
        public Item Item { get; set; }

        public PersonalPage()
        {
            InitializeComponent();

            Item = new Item();
            viewModel = new PersonalViewModel();

            BindingContext = viewModel;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new ApprovalPage(viewModel)));
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
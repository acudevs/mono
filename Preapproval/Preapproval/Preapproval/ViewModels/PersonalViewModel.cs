using System;

using Preapproval.Models;
using Preapproval.Views;
using Xamarin.Forms;

namespace Preapproval.ViewModels
{
    public class PersonalViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public PersonalViewModel()
        {
            var item = DataStore.GetItemAsync().Result;
            Title = item?.Name;
            Item = item;
        }
    }
}

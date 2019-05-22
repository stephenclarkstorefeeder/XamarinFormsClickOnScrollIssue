using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ClickOnScrollIssue.Models;
using ClickOnScrollIssue.Views;
using ClickOnScrollIssue.ViewModels;

namespace ClickOnScrollIssue.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
           
            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel()));

        }

        void AddItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Click", "You clicked", "OK");
           //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

    }
}
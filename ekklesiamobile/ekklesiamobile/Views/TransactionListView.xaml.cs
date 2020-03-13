using ekklesiamobile.Models.TransactionModel;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ekklesiamobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransactionListView : ContentPage
    {
        public List<Transaction> Transactions { get; set; }
        public TransactionListView()
        {
            InitializeComponent();
            this.Transactions = new List<Transaction>();            
            this.BindingContext = this;
        }

        private void listViewTransactions_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewTransactionView());
        }
    }
}
using ekklesiamobile.Models.TransactionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ekklesiamobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTransactionView : ContentPage
    {
        public Transaction Transaction { get; set; }
        public List<string> TransactionTypeList
        {
            get
            {
                return Enum.GetNames(typeof(TransactionType)).ToList();
            }

        }

        private string _value;
        public string Value
        {
            get
            {
                return Transaction.Value.ToString();
            }
            set
            {
                if (_value != value)
                {
                    _value = value;                
                   
                }

            }
        }

        private string _selectedTransactionType;
        public string SelectedTransactionType
        {
            get
            {
                return _selectedTransactionType;
            }
            set
            {
                if (_selectedTransactionType != value)
                {
                    _selectedTransactionType = value;
                    Enum.TryParse(value, out TransactionType transactionType);
                    Transaction.Type = transactionType;
                }

            }
        }
        public NewTransactionView()
        {
            this.Transaction = new Transaction();
            this.BindingContext = this;
            InitializeComponent();
        }

        private void buttonSave_Clicked(object sender, EventArgs e)
        {
            Transaction.Value = decimal.Parse(_value.Replace("R$", ""));
            DisplayAlert("Teste", $"Data: {Transaction.Date} Categoria: " +
                $"{Transaction.Category} Valor: {Transaction.Value.ToString()} " +
                $"Tipo: {Transaction.Type.ToString()}", "ok");

        }
    }
}
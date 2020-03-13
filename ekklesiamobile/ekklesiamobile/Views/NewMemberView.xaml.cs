using ekklesiamobile.Models;
using ekklesiamobile.Models.MemberModel;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ekklesiamobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewMemberView : ContentPage
    {

        public Member Member { get; set; }
        
        public List<string> PositionList
        {
            get
            {
                return Enum.GetNames(typeof(Position)).ToList();
            }
        }
        private string _selectedPosition;
        public string SelectedPosition
        {
            get
            {
                return _selectedPosition;
            }
            set
            {
                if (_selectedPosition != value)
                {
                    _selectedPosition = value;
                    Enum.TryParse(value, out Position position);
                    Member.Position = position;
                }
               
            }
        }

        public NewMemberView()
        {
            this.Member = new Member();
            InitializeComponent();            
            this.BindingContext = this;
        }

        private void buttonSave_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Salvar", $"Membro: {Member.Name} " +
                $"Telefone: {Member.Phone} Cargo: {Member.Position.ToString()}", "Ok"); 
        }
                
    }
}
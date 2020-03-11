using ekklesiamobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ekklesiamobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsView : ContentPage
    {
        public Member Member { get; set; }

        public DetailsView(Member member)
        {
            InitializeComponent();
            this.Member = member;
            this.BindingContext = this;
        }

        private void buttonEdit_Clicked(object sender, EventArgs e)
        {

        }
    }
}
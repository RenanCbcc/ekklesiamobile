using ekklesiamobile.Models;
using ekklesiamobile.Models.MemberModel;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace ekklesiamobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MemberListView : ContentPage
    {
        public List<Member> Members { get; set; }

        public MemberListView()
        {
            InitializeComponent();
            
            this.Members = new List<Member>
            {
                new Member {
                    Id=1,Name = "José Guilherme Marcelo Bernardes",
                    Phone = "(82) 99192-2526",
                    Position = Position.Lider
                },
                new Member {
                    Id=2,Name = "Levi Joaquim Marcos Cardoso",
                    Phone = "(82) 99192-2526",
                    Position = Position.Membro
                },
                new Member {
                    Id=3,Name = "Sophie Ayla Fernanda da Rocha",
                    Phone = "(62) 98987-4705",
                    Position = Position.Membro
                },
                new Member {
                    Id=4,Name = "Caroline Emilly Almeida",
                    Phone = "(81) 98151-9042",
                    Position = Position.Membro
                }
            };
            this.BindingContext = this;
            
        }

        private void listViewMembers_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var member = (Member) e.Item;
            Navigation.PushAsync(new DetailsView(member));            
        }

        private void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewMemberView());
        }
    }
}

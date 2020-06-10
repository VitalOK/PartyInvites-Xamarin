using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PartyInvites
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Thanks : ContentPage
    {
        public Thanks(bool willAttend, string attendyName)
        {
            InitializeComponent();

            header.Text = "Thank you, " + attendyName +"!";

            if (willAttend)
            {
                response.Text = "It's great that you're coming. The drinks are already in the fridge!";
            }
            else
            {
                response.Text = "Sorry to hear that you can't make it, but thanks for letting us know.";
            }
        }
    }
}
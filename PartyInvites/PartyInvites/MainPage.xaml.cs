using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PartyInvites
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            helloWorld.Text = DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon!";
        }

        async void OnRSVPNowButtonClicked(object sender, EventArgs e)
        {
            var response = (GuestResponse)BindingContext;
            //SAVE await App.Database.SaveNoteAsync(note);
            await Navigation.PushAsync(new RsvpForm
            {
                BindingContext = new GuestResponse()
            }, false);
        }

        async void Test(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RsvpForm
            {
                BindingContext = new GuestResponse()
            }, false);
        }
    }
}

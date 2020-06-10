using PartyInvites.Models;
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
    public partial class RsvpForm : ContentPage
    {
        public RsvpForm()
        {
            InitializeComponent();
        }

        async void OnSubmitRSVPClicked(object sender, EventArgs e)
        {
            var response = (GuestResponse)BindingContext;

            //ValidationStart
            if (string.IsNullOrEmpty(response.Name))
            {
                lblerrorName.Text = "Name is required";
                lblerrorName.TextColor = Color.Red;
            }
            else
            {
                lblerrorName.Text = "";
                lblerrorName.TextColor = Color.Default;
            }

            if (string.IsNullOrEmpty(response.Email))
            {
                lblerrorEmail.Text = "Email is required";
                lblerrorEmail.TextColor = Color.Red;
            }
            else
            {
                lblerrorEmail.Text = "";
                lblerrorEmail.TextColor = Color.Default;
            }

            if (string.IsNullOrEmpty(response.Phone))
            {
                lblerrorPhone.Text = "Phone is required";
                lblerrorPhone.TextColor = Color.Red;
            }
            else
            {
                lblerrorPhone.Text = "";
                lblerrorPhone.TextColor = Color.Default;
            }
            if(lblerrorName.Text.Length != 0 || lblerrorEmail.Text.Length != 0 || lblerrorPhone.Text.Length != 0)
            {
                return;
            }
            else
            {
                //if (entrypassword.text.length < 9)
                //{
                //    lblerror1.Text = "Password must be 8 characters";
                //    return;
                //}
                //if (entrypassword.text != entryconfirmpassword.text)
                //{
                //    lblerror2.Text = "Passwords are not match";
                //    return;
                //}
                //else
                //{
                // your button click code
                if (!response.WillAttend.HasValue) response.WillAttend = false;

                await Navigation.PushAsync(new Thanks(response.WillAttend.Value, response.Name), false);
                //}
            }
            //ValidationEnd



        }
    }
}
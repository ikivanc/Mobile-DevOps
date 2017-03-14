using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HockeyApp;


using Xamarin.Forms;

namespace HockeyAppInsight
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            HockeyApp.MetricsManager.TrackEvent("Home Page Visited");            
        }

        public async void Button_Click(object sender, EventArgs args)
        {
            MetricsManager.TrackEvent("Error Generation Button Clicked");

            btnClick.Text = "Clicked";
            throw new DivideByZeroException("Divide By Zero Exception");       
        }


        public async void btnCustom_Click(object sender, EventArgs args)
        {
            MetricsManager.TrackEvent("Custom Event Button Clicked");
            btnCustomClick.Text = "Sent";

            HockeyApp.MetricsManager.TrackEvent("Custom Event created manually");

            await this.Navigation.PushModalAsync(new DetailPage());

        }
    }
}

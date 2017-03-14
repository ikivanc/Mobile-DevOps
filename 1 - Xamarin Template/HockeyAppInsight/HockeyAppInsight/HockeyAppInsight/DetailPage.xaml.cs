using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HockeyAppInsight
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
            HockeyApp.MetricsManager.TrackEvent("Detail Page Visited");
        }

        public async void btnCustom_Click(object sender, EventArgs args)
        {
            HockeyApp.MetricsManager.TrackEvent("Detail Page Custom Event");
            btnCustomClick.Text = "Sent";
        }
    }
}

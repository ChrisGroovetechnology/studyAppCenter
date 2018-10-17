using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace StudyAppCenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Analytics.TrackEvent("Video clicked", new Dictionary<string, string>()
            {
                { "Login", "aaa" },
            });
            InitializeComponent();
        }
    }
}
